using Challenge.Data.Provider;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICategoriesProvider, CategoriesProvider>();
builder.Services.AddSingleton<IContentProvider, ContentProvider>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();
app.Run();
