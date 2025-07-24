using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels
{
    public partial class Page3ViewModel : ObservableObject
    {
        private readonly Dictionary<string, string> _optionUrlMap = new()
        {
            { "Основной", "https://avatai.my/" },
            { "Видео", "https://video.avatai.my/" }
        };

        [ObservableProperty]
        private string selectedOption;

        [ObservableProperty]
        private string currentUrl;

        [ObservableProperty]
        private bool isLoading;

        public Page3ViewModel()
        {
            SelectedOption = _optionUrlMap.First().Key;
            IsLoading = true;
        }

        partial void OnSelectedOptionChanged(string oldValue, string newValue)
        {
            if (newValue is null)
                return;

            if (_optionUrlMap.TryGetValue(newValue, out var newUrl) && newUrl != CurrentUrl)
            {
                IsLoading = true;
                CurrentUrl = newUrl;
            }
        }

        public void OnPageLoaded() => IsLoading = false;
    }
}
