var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Urls.Add("http://0.0.0.0:8080");

app.MapGet("/", () =>
{
    Console.WriteLine(">>> Log from inside the container!");
    return $"Hello World @ UTC: {DateTime.UtcNow}!";
})
.WithName("hello");

app.Run();
