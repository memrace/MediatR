using System.Globalization;
using System.Threading.Tasks;
using MediatR.CQRS;
using MediatR.CQRS.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpeechCatalogController : ControllerBase
    {
        private readonly ILogger<SpeechCatalogController> _logger;
        private readonly IMediator _mediator;
        public SpeechCatalogController(ILogger<SpeechCatalogController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task CreateSpeech(SpeechCatalogCreateCommand cmd)
        {
            await _mediator.Send(cmd); // отправляем в медиатор и он там все разруливает.
        }

        [HttpGet("Get")]
        public async Task GetSpeech(SpeechCatalogGetQuery cmd)
        {
            await _mediator.Send(cmd);
        }
       
    }
}