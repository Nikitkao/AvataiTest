using MauiApp1.ViewModels;

namespace MauiApp1.Services.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentViewModel>> GetStudentsAsync(int page, int pageSize);
    }
}
