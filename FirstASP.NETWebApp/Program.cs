var builder = WebApplication.CreateBuilder(args); // This is the WebApplicationBuilder object

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build(); // This is the WebApplication object

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) // This is the IHostEnvironment object
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); // This method is used to serve static files like images, CSS, and JavaScript files

app.UseRouting(); // This method is used to route the incoming request to the appropriate controller

app.UseAuthorization(); // This method is used to authorize the user

app.MapControllerRoute( // This method is used to map the incoming request to the appropriate controller
    name: "default",
    pattern: "{controller=Home}/{action=Hobby}/{id?}");

app.Run(); // This method is used to run the application