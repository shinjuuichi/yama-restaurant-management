using Microsoft.EntityFrameworkCore;
using WebAPI;
using WebAPI.Data;
using WebAPI.Utils.Middlewares;

var apiPolicy = "YamaCorsPolicy";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureService();
builder.Services.AddWebAPIService();

builder.Services.AddCors(options =>
{
    options.AddPolicy(apiPolicy, policy =>
    {
        policy.WithOrigins(
            "http://localhost:3000",
            "https://shinjuuichi.me",
            "https://server.shinjuuichi.me",
            "https://yama-restaurant-management.vercel.app")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
    });
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await context.Database.MigrateAsync();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(apiPolicy);

app.UseMiddleware<JWTAuthenticationMiddleware>();
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
