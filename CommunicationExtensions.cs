using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WaveChat.Communication;

namespace WaveChat
{
    public static class CommunicationExtensions
    {
        public static IApplicationBuilder MapWebSocketManager(this IApplicationBuilder app,
                                                             PathString path,
                                                             CommunicationHandler handler)
        {
            return app.Map(path, (_app) => _app.UseMiddleware<CommunicationMiddleware>(handler));
        }

        public static IServiceCollection AddWebSocketManager(this IServiceCollection services)
        {
            services.AddTransient<CommunicationManager>();

            foreach (var type in Assembly.GetEntryAssembly().ExportedTypes)
            {
                if (type.GetTypeInfo().BaseType == typeof(CommunicationHandler))
                {
                    services.AddSingleton(type);
                }
            }

            return services;
        }


    }
}
