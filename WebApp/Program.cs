var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = ["Profile.html"]
});

app.Run();
