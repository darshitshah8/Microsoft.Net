using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(opts =>
{
    var title = "Our Versioned API";
    var description = "This is a web api that demonstrates Version";
    var terms = new Uri("https://localhost:7034//terms");
    var license = new OpenApiLicense()
    {
        Name = "This is my full license information or link to it",
    };
    var contact = new OpenApiContact()
    {
        Name = "Darshit Shah",
        Email = "darshitshah@gmail.com",
        Url = new Uri("https://github.com/darshit30"),
    };
    opts.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = $"{title} v1 (deprecated)",
        Description = description,
        TermsOfService = terms,
        License = license,
        Contact = contact,

    });
    opts.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2",
        Title = $"{title} v2",
        Description = description,
        TermsOfService = terms,
        License = license,
        Contact = contact,

    });
});

builder.Services.AddApiVersioning(opts =>
{
    opts.AssumeDefaultVersionWhenUnspecified = true;
    opts.DefaultApiVersion = new(1, 0);
    opts.ReportApiVersions = true;
});

builder.Services.AddVersionedApiExplorer(opts =>
{
    opts.GroupNameFormat = "'v'VVV";
    opts.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opts => 
    {
        opts.SwaggerEndpoint("/swagger/v2/swagger.json", "v2");
        opts.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
