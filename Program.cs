
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Register API controllers.
builder.Services.AddControllers();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

// Enable API routes.
app.MapControllers();

app.Run();
