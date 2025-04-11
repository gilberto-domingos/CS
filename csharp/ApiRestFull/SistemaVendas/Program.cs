using Microsoft.EntityFrameworkCore;
using SistemaVendas.Data;
using SistemaVendas.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço HelloService
builder.Services.AddScoped<HelloService>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


app.Run();