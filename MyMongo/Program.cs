using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using MyMongo.Contexts;
using MyMongo.Repo.Services.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.Configure<ShopexDatabaseSettings>(builder.Configuration.GetSection(nameof(ShopexDatabaseSettings)));
builder.Services.AddSingleton<IShopexDatabaseSettings>(sp => sp.GetRequiredService<IOptions<ShopexDatabaseSettings>>().Value);
builder.Services.AddSingleton<UserService>();


builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "MyMongo", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyMongo v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
