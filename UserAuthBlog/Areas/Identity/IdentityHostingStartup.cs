using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserAuthBlog.Data;

[assembly: HostingStartup(typeof(UserAuthBlog.Areas.Identity.IdentityHostingStartup))]
namespace UserAuthBlog.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserAuthBlogContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserAuthBlogContextConnection")));

                //services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<UserAuthBlogContext>();
            });
        }
    }
}