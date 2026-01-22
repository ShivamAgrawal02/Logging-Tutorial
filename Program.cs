using NLog;
using NLog.Web;

//var logger = LogManager.Setup()
//    .LoadConfigurationFromAppSettings()
//    .GetCurrentClassLogger();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.// Remove default loggers
builder.Logging.ClearProviders();

// Use NLog
builder.Host.UseNLog();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
