using AIResume.Domain.Dto.Configuration;
using AIResume.Domain.Interface;
using AIResume.Infra.Data.Repositories;
using AIResume.Service.Services;

var builder = WebApplication.CreateBuilder(args);
var applicationConfig = builder.Configuration.Get<ApplicationConfig>();
builder.Services.AddSingleton(applicationConfig);

#region Services
builder.Services.AddScoped<IFilesService, FilesService>();
#endregion

#region Repositories
builder.Services.AddScoped<IFilesRepository, FilesRepository>();
builder.Services.AddHttpClient<IChatGPTRepository, ChatGPTRepository>(client => 
{
    client.BaseAddress = applicationConfig.ChatGptBaseUrl;
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
