using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModels
{
    public partial class Page3ViewModel : ObservableObject
    {
        private readonly Dictionary<string, string> _urlMap = new()
        {
            { "Основной", "https://avatai.my/" },
            { "Видео", "https://video.avatai.my/" }
        };

        public IEnumerable<string> UrlLabels => _urlMap.Keys;

        [ObservableProperty]
        private string selectedLabel;

        [ObservableProperty]
        private string currentUrl;

        [ObservableProperty]
        private bool isLoading;

        public Page3ViewModel()
        {
            SelectedLabel = "Основной";
            CurrentUrl = _urlMap[SelectedLabel];
            IsLoading = true;
        }

        //partial void OnSelectedLabelChanged(string oldValue, string newValue)
        //{
        //    if (_urlMap.TryGetValue(newValue, out var newUrl) && newUrl != CurrentUrl)
        //    {
        //        IsLoading = true;
        //        CurrentUrl = newUrl;
        //    }
        //}

        public void OnPageLoaded() => IsLoading = false;
    }
}
