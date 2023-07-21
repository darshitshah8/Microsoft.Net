using HotelAppLibrary.Data;
using HotelAppLibrary.Databases;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config

// Add services to the container.
builder.Services.AddRazorPages();

string dbchoice = configuration.GetValue<string>("DatabaseChoice").ToLower();
if (dbchoice == "sql")
{
    builder.Services.AddTransient<IDatabaseData, SqlData>();
}
else if (dbchoice == "sqlite")
{
    builder.Services.AddTransient<IDatabaseData, SqliteData>();
}
else
{
    builder.Services.AddTransient<IDatabaseData, SqlData>();
}

builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<ISqliteDataAccess, SqliteDataAccess>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
