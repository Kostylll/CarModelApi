using CarModelApi.Extension;
using CarModelRegister.Application.Infra.Data.DBContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddRepository();



builder.Services.AddDbContext<CarModelDbContext>(options =>
{
    var cnn = builder.Configuration.GetConnectionString("CarModelDB");
    options.UseSqlServer(cnn);
});



var app = builder.Build();


app.UseCors(m => m.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
