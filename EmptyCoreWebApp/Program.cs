var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddMvc(); ; // If you plan to use MVC controllers


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/Tobi", () => "Tobias is a great name!");

app.MapGet("/index.html", (HttpContext ctx) => { 
    ctx.Response.ContentType = "text/html";
    ctx.Response.WriteAsync($"<html><body><h1>Hello World!</h1><p>{DateTime.Now.ToLongTimeString()}</p></body></html>");
});

//app.MapGet("/test.html", (HttpContext ctx) => { 
//    ctx.Response.ContentType = "text/html";
//    ctx.Response.WriteAsync(System.IO.File.ReadAllText("wwwroot/test.html"));
//});

app.UseStaticFiles();
//app.UseAuthentication();

app.Run();