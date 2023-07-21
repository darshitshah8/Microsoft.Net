using EntityFrameworkType.Data;
using EntityFrameworkType.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


#region Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICakeServices, CakeServices>();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CakeConnectionString"));
}); 
#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
