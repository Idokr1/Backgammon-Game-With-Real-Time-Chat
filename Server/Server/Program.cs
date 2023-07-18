using DAL.Interfaces;
using DAL.Repositories;
using Logic.Interfaces;
using Logic.Services;
using Microsoft.AspNetCore.SignalR;
using Models.Models;
using Server.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR(e => {
    e.MaximumReceiveMessageSize = 102400000;
    e.EnableDetailedErrors = true;
});

builder.Services.AddSingleton<IDictionary<string, User>>(options => new Dictionary<string, User>());
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IChatRepository, ChatRepository>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IChatService, ChatService>();


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()
            .WithOrigins("http://localhost:3000");
    });
});

var app = builder.Build();

app.UseRouting();

app.UseCors();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<MainHub>("/main");
});


app.Run();

