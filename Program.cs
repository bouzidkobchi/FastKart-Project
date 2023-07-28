using FastKart.Data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

using(var context = new AppDbContext(true))
{

}

app.MapGet("/", () => "Hello World! bouzid");

app.Run();
