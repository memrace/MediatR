using System;
using System.Threading.Tasks;

namespace MediatR.Database
{
    public class SpeechCatalogRepository: IRepository
    {
        private DbContext _db;
        public SpeechCatalogRepository(DbContext db) => _db = db;
        public async void Create(Guid id)
        {
            // I Create Speech in DB...
        }

        public async Task<SpeechDto> Get(Guid id)
        {
           return await _db.GetAsync(id);  // I can get for you some speech by id...
        }
    }
}