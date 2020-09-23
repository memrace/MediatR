using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Database;

namespace MediatR.CQRS
{
    public class SpeechCatalogCreateCommand : IRequest
    {
        public Guid Id { get;}

        public SpeechCatalogCreateCommand(Guid id)
        {
            Id = id;
        }
    }
    
    // Another File

    public class SpeechCatalogRemoveHandler : IRequestHandler<SpeechCatalogCreateCommand>
    {
        // Создаем DI  к репозиторию через констр.
        private IRepository _repository;

        public SpeechCatalogRemoveHandler(IRepository repository)
        {
            _repository = repository;
        }
        
        public Task<Unit> Handle(SpeechCatalogCreateCommand request, CancellationToken cancellationToken)
        {
            // request это класс выше, тот самый вид запроса.
            _repository.Create(request.Id);
            
            return Unit.Task; // == void
        }
    }
}