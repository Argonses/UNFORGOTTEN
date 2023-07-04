using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UNFORGOTTEN.Server.Models;
using UNFORGOTTEN.Shared;

namespace UNFORGOTTEN.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    ImageUrl = "https://www.booksmith.com/sites/booksmith.com/files/SRP.jpg",
                    Name = "Quiet Book Club",
                    Date = DateTime.Now.AddDays(2),
                    Location = "Online",
                    Description = "Join our virtual book club where we read and discuss books in a relaxed and quiet environment."
                },
                new Event
                {
                    Id = 2,
                    ImageUrl = "https://img.ehowcdn.com/375/cme-data/getty%2F654b900913884eb3bb30af5cdfa25c37.jpg",
                    Name = "Introvert's Movie Night",
                    Date = DateTime.Now.AddDays(4),
                    Location = "Your Living Room",
                    Description = "Grab your favorite snacks, cozy up on the couch, and enjoy a movie night designed for introverts."
                },
                new Event
                {
                    Id = 3,
                    ImageUrl = "https://www.strathmore.org/media/twtlc1kp/creative-writing-workshop.jpg",
                    Name = "Creative Writing Workshop",
                    Date = DateTime.Now.AddDays(6),
                    Location = "Quiet Café",
                    Description = "Unleash your creativity in a peaceful setting and join our writing workshop for introverts."
                },
                new Event
                {
                    Id = 4,
                    ImageUrl = "https://i.redd.it/has7cip5ley31.jpg",
                    Name = "Nature Walk for Introverts",
                    Date = DateTime.Now.AddDays(8),
                    Location = "Tranquil Forest",
                    Description = "Embark on a peaceful nature walk designed for introverts to enjoy the beauty of the outdoors in solitude."
                },
                new Event
                {
                    Id = 5,
                    ImageUrl = "https://www.artmajeur.com/medias/standard/b/h/bhdigitalart/artwork/10599379_time-to-introvert2.jpg",
                    Name = "Introvert's Art Workshop",
                    Date = DateTime.Now.AddDays(10),
                    Location = "Cozy Art Studio",
                    Description = "Unleash your creativity and join our art workshop tailored for introverts to express themselves through art."
                },
                new Event
                {
                    Id = 6,
                    ImageUrl = "https://bizzabo.com/wp-content/uploads/2021/09/Networking-event-examples-Salesforce-min.png",
                    Name = "Introvert Networking Evening",
                    Date = DateTime.Now.AddDays(12),
                    Location = "Quiet Café",
                    Description = "Connect with fellow introverts in a relaxed and intimate setting to build meaningful connections."
                }

            );
        }


        public DbSet<Post> Posts { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}