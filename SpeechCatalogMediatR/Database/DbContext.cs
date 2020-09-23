using System;
using System.Threading.Tasks;

// Заглушка.
namespace MediatR.Database
{
    public class DbContext
    {
        public DbContext(){}

        public void AddAsync(Guid id)
        {
        }

        public Task<SpeechDto> GetAsync(Guid id)
        {
            return Task<SpeechDto>(); // Заглушка хз...
        }
    }
}