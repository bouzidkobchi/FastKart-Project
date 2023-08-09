using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

// Configuring swagger service :
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "FastKart",
        Description = ".Net Api For Managing FastKart Database Operations",
    });

    // allow using xml comments :
    string xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    string xmlAbsolutePath = Path.Combine(AppContext.BaseDirectory, xmlFileName);

    options.IncludeXmlComments(xmlAbsolutePath);


});

var app = builder.Build();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.MapGet("/", () => "Hello World! bouzid");

app.Run();