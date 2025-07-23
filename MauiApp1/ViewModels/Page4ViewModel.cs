using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels
{
    [QueryProperty(nameof(Student), "Student")]
    public partial class Page4ViewModel : ObservableObject
    {
        [ObservableProperty]
        private StudentViewModel student;
    }
}
