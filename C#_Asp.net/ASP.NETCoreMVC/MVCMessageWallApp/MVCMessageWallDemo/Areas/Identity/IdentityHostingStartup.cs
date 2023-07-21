using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCMessageWallDemo.Areas.Identity.Data;
using MVCMessageWallDemo.Data;

[assembly: HostingStartup(typeof(MVCMessageWallDemo.Areas.Identity.IdentityHostingStartup))]
namespace MVCMessageWallDemo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MVCMessageWallDemoContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MVCMessageWallDemoContextConnection")));

                services.AddDefaultIdentity<MVCMessageWallDemoUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MVCMessageWallDemoContext>();
            });
        }
    }
}