using DataLayer.Entities;
using DataLayer.Repositories.Interfaces;

namespace DataLayer.Repositories.FilesImplementations
{
    public class StudentFileRepository : IStudentRepository
    {
        private FileRepository<Student> _repository = new FileRepository<Student>();

        public void Add(Student entity) => _repository.Add(entity);

        public void Delete(string id) => _repository.Delete(id);

        public Student Get(string id) => _repository.Get(id);

        public IEnumerable<Student> GetAll() => _repository.GetAll().Where(o => o is Student);

        public IEnumerable<Student> GetStudentsByTask()
        {
            return GetAll().Where(
                o => o.Course == 4 &&
                o.Birthday.Month >= 3 &&
                o.Birthday.Month < 6);
        }

        public void Update(Student entity) => _repository.Update(entity);
    }
}
