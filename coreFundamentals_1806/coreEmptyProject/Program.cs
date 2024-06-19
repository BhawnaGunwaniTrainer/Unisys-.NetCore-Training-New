var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// index.html, index.htm, default.html, default.htm
// app.UseDefaultFiles();

// Configuring DefaultFileOptions
DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
defaultFilesOptions.DefaultFileNames.Clear();
defaultFilesOptions.DefaultFileNames.Add("home.html");
defaultFilesOptions.DefaultFileNames.Add("dashboard.html");

// app.UseDefaultFiles(defaultFilesOptions);
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

/*app.MapGet("/", () => "Hello World!");*/

app.Run();
