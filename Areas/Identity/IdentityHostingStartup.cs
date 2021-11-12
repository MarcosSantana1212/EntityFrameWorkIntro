using System;
using EntityFrameWorkIntro.Areas.Identity.Data;
using EntityFrameWorkIntro.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EntityFrameWorkIntro.Areas.Identity.IdentityHostingStartup))]
namespace EntityFrameWorkIntro.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LoginContextContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LoginContextContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<LoginContextContext>();
            });
        }
    }
}