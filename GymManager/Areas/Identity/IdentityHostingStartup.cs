using System;
using GymManager.Areas.Identity.Data;
using GymManager.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GymManager.Areas.Identity.IdentityHostingStartup))]
namespace GymManager.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GymManagerDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GymManagerDBContextConnection")));

                services.AddDefaultIdentity<AplicationUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                    .AddEntityFrameworkStores<GymManagerDBContext>();
            });
        }
    }
}