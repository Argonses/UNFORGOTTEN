using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Client.Services.EventService
{
    public interface IEventService 
    {
        List<Event> Events { get; set; }
        Task GetEvents();
    }
}
