using BusinessManager;
using CiberModelo_WebServices.User;
using DBManager;
using Microsoft.EntityFrameworkCore;
using ModelManager;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<UserBM>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapLoginEndpoints();

app.Run();

[JsonSerializable(typeof(UserModel[]))]
[JsonSerializable(typeof(List<UserModel>))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
