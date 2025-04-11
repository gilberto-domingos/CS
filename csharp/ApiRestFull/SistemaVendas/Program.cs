using Microsoft.EntityFrameworkCore;
using SistemaVendas.Data;
using SistemaVendas.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<HelloService>();
builder.Services.AddControllers();

builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();