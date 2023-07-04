using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UNFORGOTTEN.Server.Services.EventService;
using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _service;

        public EventsController(IEventService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Event>> GetEvents()
        {
            return await _service.GetEvents();
        }
    }
}
