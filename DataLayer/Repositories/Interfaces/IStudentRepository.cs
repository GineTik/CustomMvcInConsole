using DataLayer.Entities;

namespace DataLayer.Repositories.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetStudentsByTask();
    }
}
