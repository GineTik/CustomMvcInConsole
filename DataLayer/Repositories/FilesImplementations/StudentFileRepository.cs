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

        public List<Student> GetAll() => _repository.GetAll();

        public void Update(Student entity) => _repository.Update(entity);
    }
}
