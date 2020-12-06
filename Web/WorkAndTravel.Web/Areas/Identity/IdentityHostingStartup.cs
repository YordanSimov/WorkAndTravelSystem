using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WorkAndTravel.Web.Areas.Identity.IdentityHostingStartup))]

namespace WorkAndTravel.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}