using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using MonitoringApi.HealthChecks;
using WatchDog;

// https://github.com/Xabaril/AspNetCore.Diagnoistics.HealthChecks not working
// https://github.com/IzyPro/WatchDog

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks()
    .AddCheck<RandomHealthCheck>("Site Health Check")
    .AddCheck<RandomHealthCheck>("Database Health Check");

//watchdog dependency injection
builder.Services.AddWatchDogServices();

builder.Services.AddHealthChecksUI(opts =>
{
    opts.AddHealthCheckEndpoint("api", "/health");
    opts.SetEvaluationTimeInSeconds(5);
    opts.SetMinimumSecondsBetweenFailureNotifications(10);
}).AddInMemoryStorage();

var app = builder.Build();

//Log in watchdog if any exception occurs
app.UseWatchDogExceptionLogger();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});
app.MapHealthChecksUI();

//watchdog username and password from secrets
app.UseWatchDog(opts =>
{
    opts.WatchPageUsername = app.Configuration.GetValue<string>("WatchDog:UserName");
    opts.WatchPagePassword = app.Configuration.GetValue<string>("WatchDog:Password");
    opts.Blacklist = "health"; //to not log the info of the following 
});

app.Run();
