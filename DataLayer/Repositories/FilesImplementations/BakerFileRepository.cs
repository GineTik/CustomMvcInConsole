using DataLayer.Entities;
using DataLayer.Repositories.Interfaces;

namespace DataLayer.Repositories.FilesImplementations
{
    public class BakerFileRepository : IBakerRepository
    {
        private FileRepository<Baker> _repository = new FileRepository<Baker>();

        public void Add(Baker entity) => _repository.Add(entity);

        public void Delete(string id) => _repository.Delete(id);

        public Baker Get(string id) => _repository.Get(id);

        public IEnumerable<Baker> GetAll() => _repository.GetAll().Where(o => o is Baker);

        public void Update(Baker entity) => _repository.Update(entity);
    }
}
