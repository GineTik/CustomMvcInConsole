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

            string nameEntity = entity.GetType().Name;
            string json = JsonSerializer.Serialize(entity);

            using StreamWriter fileStream = new(_filePath, append: true);
            fileStream.WriteLine($"{nameEntity} {entity.Id}");
            fileStream.WriteLine(json);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(string id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public List<TEntity> GetAll()
        {
            using StreamReader reader = new StreamReader(_filePath);

            List<TEntity> entities = new List<TEntity>();
            while(reader.EndOfStream == false)
            {
                string header = reader.ReadLine();
                string json = reader.ReadLine();

                TEntity entity = JsonSerializer.Deserialize<TEntity>(json);

                entities.Add(entity);
            }
            return entities;
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
