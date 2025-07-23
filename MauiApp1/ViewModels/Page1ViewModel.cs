using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Services.Interfaces;
using MauiApp1.Views;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModels
{
    public partial class Page1ViewModel : ObservableObject
    {
        private readonly IStudentService _studentService;

        private int _currentPage = 1;
        private const int PageSize = 15;
        private bool _isLoading = false;
        private bool _hasMoreItems = true;
        private StudentViewModel? _lastSelectedStudent;

        [ObservableProperty]
        private ObservableCollection<StudentViewModel> students = new ObservableCollection<StudentViewModel>();

        [ObservableProperty]
        private StudentViewModel? selectedStudent;

        public Page1ViewModel(IStudentService studentService)
        {
            _studentService = studentService;

            LoadInitialDataCommand.Execute(null);
        }

        [RelayCommand]
        private async Task LoadInitialDataAsync()
        {
            Students.Clear();
            _currentPage = 1;
            _hasMoreItems = true;
            await LoadMoreAsync();
        }

        [RelayCommand]
        private async Task LoadMoreAsync()
        {
            if (_isLoading || !_hasMoreItems) return;

            _isLoading = true;

            var newStudents = await _studentService.GetStudentsAsync(_currentPage, PageSize);

            foreach (var student in newStudents)
                Students.Add(student);

            if (newStudents.Count < PageSize)
                _hasMoreItems = false;
            else
                _currentPage++;

            _isLoading = false;
        }

        [RelayCommand]
        private async Task StudentTapped(StudentViewModel tappedStudent)
        {
            if (_lastSelectedStudent != null)
                _lastSelectedStudent.IsSelected = false;

            tappedStudent.IsSelected = true;
            _lastSelectedStudent = tappedStudent;

            await Shell.Current.GoToAsync(nameof(Page4), new Dictionary<string, object>
            {
                { "Student", tappedStudent }
            });
        }
    }
}
