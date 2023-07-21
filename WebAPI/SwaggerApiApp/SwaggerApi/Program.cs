using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opts =>
{
    // Information about api and licences
    opts.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title= "Our user API (this is our title)",
        Description = "This is the description about an API.",
        TermsOfService = new Uri("https://google.com"),
        Contact = new OpenApiContact
        {
            Name = "Darshit Shah (Contact Info)",
            Url = new Uri("https://google.com"),
        },
        License = new OpenApiLicense
        {
            Name = "Licence Name",
            Url = new Uri("https://google.com"),
        }
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    opts.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFile));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(opts =>
    {
        //opts.SerializeAsV2 = true;
    });
    //Custom UI - https://github.com/ostranme/swagger-ui-themes
    app.UseSwaggerUI(opts =>
    {
        opts.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        opts.RoutePrefix = String.Empty;
        opts.InjectStylesheet("css/theme-material.css");
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();