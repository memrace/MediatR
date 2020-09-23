using System;
using System.Threading.Tasks;
using MediatR.CQRS;

namespace MediatR.Database
{
    public interface IRepository
    {
        public void Create(Guid id); // Better async imho.
        public Task<SpeechDto> Get(Guid id);
    }
}