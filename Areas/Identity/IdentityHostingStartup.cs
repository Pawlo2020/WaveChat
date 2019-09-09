using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WaveChat.Areas.Identity.Data;
using WaveChat.Models;

[assembly: HostingStartup(typeof(WaveChat.Areas.Identity.IdentityHostingStartup))]
namespace WaveChat.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WaveChatContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("WaveChatContextConnection")));

                services.AddDefaultIdentity<WaveChatUser>()
                    .AddEntityFrameworkStores<WaveChatContext>();
            });
        }
    }
}