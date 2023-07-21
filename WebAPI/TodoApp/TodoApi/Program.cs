using TodoApi.StatrupConfig;

var builder = WebApplication.CreateBuilder(args);

builder.AddStandardServices();
builder.AddCustomServices();
builder.AddAuthServices();
builder.AddHealthCheckServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks("/health").AllowAnonymous();
app.Run();
