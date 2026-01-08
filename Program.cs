using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpContextAccessor();
var app = builder.Build();

app.MapGet("/", ([FromServices] IHttpContextAccessor accessor) => $"Server URL: {accessor.HttpContext?.Request.Host}");

app.Run();