using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using Logic.Interfaces;
using Logic.Services;
using Main.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Main
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:3000")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });

            services.AddSingleton<IDictionary<string, User>>(options => new Dictionary<string, User>());

            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IChatRepository, ChatRepository>();

            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IChatService, ChatService>();

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<MainHub>("/main");
            });
        }
    }
}
