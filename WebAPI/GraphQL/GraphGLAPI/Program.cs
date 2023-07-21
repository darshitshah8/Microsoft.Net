using GraphGLAPI.Context;
using GraphGLAPI.GqlTypes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ChocolateDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ChocolateConnectionString"));
});
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();
app.Run();
