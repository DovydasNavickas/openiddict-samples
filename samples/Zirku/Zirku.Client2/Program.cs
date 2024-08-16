var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseStaticFiles();

// Default redirect to the index page
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
