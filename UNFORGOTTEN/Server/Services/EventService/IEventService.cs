using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Server.Services.EventService
{
    public interface IEventService
    {
        Task<List<Event>> GetEvents();
    }
}
