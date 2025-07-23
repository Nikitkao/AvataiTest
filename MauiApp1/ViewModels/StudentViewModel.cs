using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModels
{
    public partial class StudentViewModel : ObservableObject
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Group { get; set; }
        public int EnrollmentYear { get; set; }

        [ObservableProperty]
        private bool isSelected;
    }
}
