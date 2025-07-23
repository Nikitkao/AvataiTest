using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModels
{
    public partial class Page2ViewModel : ObservableObject
    {
        [ObservableProperty] private string name;
        [ObservableProperty] private int age;
        [ObservableProperty] private string email;

        [ObservableProperty]
        private bool isBusy;

        public bool CanSubmit() => !IsBusy;

        [RelayCommand(CanExecute = nameof(CanSubmit))]
        private async Task SubmitAsync()
        {
            IsBusy = true;
            SubmitCommand.NotifyCanExecuteChanged();

            try
            {
                await Task.Delay(1500);

                Name = string.Empty;
                Age = 0;
                Email = string.Empty;

                var toast = Toast.Make("Форма успешно отправлена", ToastDuration.Short);
                await toast.Show();
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Ошибка", ex.Message, "ОК");
            }
            finally
            {
                IsBusy = false;
                SubmitCommand.NotifyCanExecuteChanged();
            }
        }
    }
}
