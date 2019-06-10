using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(IdentityRazorPageDemo.Areas.Identity.IdentityHostingStartup))]
namespace IdentityRazorPageDemo.Areas.Identity
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