using MauiApp1.Services.Interfaces;
using MauiApp1.ViewModels;

namespace MauiApp1.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<StudentViewModel> _allStudents;

        public StudentService()
        {
            _allStudents = Enumerable.Range(1, 150)
                .Select(i => new StudentViewModel
                {
                    Id = i,
                    Name = $"Студент {i}",
                    Age = 18 + i % 5,
                    Email = $"student{i}@university.by",
                    Group = $"Группа {(char)('A' + i % 3)}",
                    EnrollmentYear = 2020 + (i % 4)
                }).ToList();
        }

        public async Task<List<StudentViewModel>> GetStudentsAsync(int page, int pageSize)
        {
            await Task.Delay(1500);
            return _allStudents
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
