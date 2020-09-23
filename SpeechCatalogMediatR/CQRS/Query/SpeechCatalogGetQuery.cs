using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Database;

namespace MediatR.CQRS.Query
{
    // Сюда всю инфу что необходима для запроса.
    public class SpeechCatalogGetQuery: IRequest<SpeechDto>
    {
        public Guid Id { get;}

        public SpeechCatalogGetQuery(Guid id)
        {
            Id = id;
        }
    }
    
    // так же можно в отдельный файл.
    public class SpeechCatalogGetHandler : IRequestHandler<SpeechCatalogGetQuery, SpeechDto>
    {
        //Опять же передаем ссылку на репу.
        private IRepository _repository;

        public SpeechCatalogGetHandler(IRepository repository)
        {
            _repository = repository;
        }
        public Task<SpeechDto> Handle(SpeechCatalogGetQuery request, CancellationToken cancellationToken)
        {
            return _repository.Get(request.Id);
        }
    }
}