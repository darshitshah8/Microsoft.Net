using Microsoft.EntityFrameworkCore;
using NZWalks.Api.Configuration;
using NZWalks.Api.Data;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NzWalksDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NZWalksConnectionString")));
builder.Services.AddResponseCaching(x => x.MaximumBodySize = 1024);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI() ;
}

app.UseHttpsRedirection();


app.MapControllers();
app.UseResponseCaching();
app.Use(async (context, next) =>
{
    context.Response.GetTypedHeaders().CacheControl =
    new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
    {
        Public = true,
        MaxAge = TimeSpan.FromSeconds(10)
    };
    await next();
});

app.AddGlobalErrorhandler();
app.Run();
