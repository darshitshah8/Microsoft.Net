using GraphGLDemoAPI.Data;
using GraphGLDemoAPI.Schema.Mutations;
using GraphGLDemoAPI.Schema.Queries;
using GraphGLDemoAPI.Schema.Repository;
using GraphGLDemoAPI.Schema.Subcription;
using Microsoft.EntityFrameworkCore;
    
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.


#region Services
builder.Services.AddRazorPages();
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subcription>();

builder.Services.AddGraphQLServer()
    .AddInMemorySubscriptions();

builder.Services.AddDbContext<SchoolDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
#endregion Services
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

#region Middleware
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseWebSockets();
//app.UseEndpoints(endpoints => { endpoints.MapGraphQL(); });

app.UseAuthorization();
#endregion

//app.MapRazorPages();
app.MapGraphQL();
app.Run();
