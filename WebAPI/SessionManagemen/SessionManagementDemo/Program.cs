var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.Cookie.Name = "MySessionCookie";
    options.IdleTimeout = TimeSpan.FromSeconds(2);
    options.Cookie.IsEssential = true;
});

builder.Services.AddControllersWithViews(); 
#endregion

var app = builder.Build();

#region ExceptionHandling
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
} 
#endregion

#region Middleware

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.UseSession();
#endregion

#region EndPoints
app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

#endregion
app.Run();