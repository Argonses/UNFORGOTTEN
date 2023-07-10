using System.Net.Http.Json;
using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Client.Services.EventService
{
    public class EventService : IEventService
    {
        private readonly HttpClient _http;

        public EventService(HttpClient http)
        {
            _http = http;
        }

        public List<Event> Events { get; set; } = new List<Event>();

        public async Task GetEvents()
        {
            var result = await _http.GetFromJsonAsync<List<Event>>("api/Events");
            if (result != null)
            {
                Events = result;
            }
        }
    }
}
