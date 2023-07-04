using Microsoft.EntityFrameworkCore;
using UNFORGOTTEN.Server.Data;
using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Server.Services.EventService
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _context;

        public EventService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }
    }
}
