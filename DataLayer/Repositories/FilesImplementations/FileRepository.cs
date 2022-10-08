using DataLayer.Entities;
using DataLayer.Repositories.Interfaces;
using System.Text.Json;

namespace DataLayer.Repositories.FilesImplementations
{
    public class FileRepository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private const string _filePath = @"../../db.txt";

        public FileRepository()
        {
            if (File.Exists(_filePath) == false)
                File.Create(_filePath);
        }

        public void Add(TEntity entity)
        {
            if (entity == null) 
                throw new ArgumentNullException(nameof(entity));

            if (Get(entity.Id) != null)
                throw new InvalidOperationException("entity with this id is already exists");

            string nameEntity = nameof(entity);
            string json = JsonSerializer.Serialize(entity);

            using StreamWriter fileStream = new(_filePath);
            fileStream.WriteLine($"{nameEntity} ${entity.Id}");
            fileStream.WriteLine(json);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(string id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        private TEntity EntityIsExists(string id)
        {
            throw new NotImplementedException();
        }
    }
}
