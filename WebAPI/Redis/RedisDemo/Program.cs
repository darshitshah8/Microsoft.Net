using RedisDemo.Data;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
    options.InstanceName = "RedisDemo_";
}); 
#endregion

var app = builder.Build();

#region Configure
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
#endregion

#region Middleware
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting(); 
#endregion

#region End Points
app.MapBlazorHub();
app.MapFallbackToPage("/_Host"); 
#endregion

app.Run();
