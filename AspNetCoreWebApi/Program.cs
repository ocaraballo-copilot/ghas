var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//comentario para probar cambios en git
// otro comentario para probar cambios en git
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
