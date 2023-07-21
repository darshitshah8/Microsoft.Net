using CustomAuthentication.Data;
using CustomAuthentication.Type;
using CustomAuthentication.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static CustomAuthentication.Type.Mutation;

var builder = WebApplication.CreateBuilder(args);


#region Services To Container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UserDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserConnectionString"));
});
builder.Services.AddScoped<IAuthLogic, AuthLogic>();
builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();


#endregion

var app = builder.Build();

#region Http Request Pipelines
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endregion

#region Middleware

app.UseRouting();   
app.UseHttpsRedirection();
app.UseAuthorization();
#endregion

#region Endpoints
app.UseEndpoints(endpoints => { endpoints.MapGraphQL(); });
app.MapControllers();

#endregion

app.Run();
