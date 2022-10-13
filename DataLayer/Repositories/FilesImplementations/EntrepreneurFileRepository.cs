using DataLayer.Entities;
using DataLayer.Repositories.Interfaces;

namespace DataLayer.Repositories.FilesImplementations
{
    public class EntrepreneurFileRepository : IEntrepreneurRepository
    {
        private FileRepository<Entrepreneur> _repository = new FileRepository<Entrepreneur>();

        public void Add(Entrepreneur entity) => _repository.Add(entity);

        public void Delete(string id) => _repository.Delete(id);

        public Entrepreneur Get(string id) => _repository.Get(id);

        public IEnumerable<Entrepreneur> GetAll() => _repository.GetAll().Where(o => o is Entrepreneur);

        public void Update(Entrepreneur entity) => _repository.Update(entity);
    }
}
