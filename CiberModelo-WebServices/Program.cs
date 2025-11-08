using BusinessManager;
using CiberModelo_WebServices.Deceased;
using CiberModelo_WebServices.DeceasedDocuments;
using CiberModelo_WebServices.Field;
using CiberModelo_WebServices.QueryType;
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
builder.Services.AddScoped<DeceasedBM>();
builder.Services.AddScoped<DeceasedDocumentsBM>();
builder.Services.AddScoped<QueryTypeBM>();
builder.Services.AddScoped<FieldBM>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapLoginEndpoints();
app.MapDeceasedEndpoints();
app.MapDeceasedDocumentsEndpoints();
app.MapQueryTypeEndPoints();
app.MapFieldEndpoints();

app.Run();

[JsonSerializable(typeof(UserModel[]))]
[JsonSerializable(typeof(List<UserModel>))]
[JsonSerializable(typeof(DeceasedModel[]))]
[JsonSerializable(typeof(List<DeceasedModel>))]
[JsonSerializable(typeof(DeceasedDocumentsModel[]))]
[JsonSerializable(typeof(List<DeceasedDocumentsModel>))]
[JsonSerializable(typeof(QueryTypeModel[]))]
[JsonSerializable(typeof(List<QueryTypeModel>))]
[JsonSerializable(typeof(FieldModel[]))]
[JsonSerializable(typeof(List<FieldModel>))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
