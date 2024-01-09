using ChinSMiniChallenge2_4.services.addnumbers;
using ChinSMiniChallenge2_4.services.greaterorless;
using ChinSMiniChallenge2_4.services.twoquestions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAddNumbersService, AddNumbersService>(); 
builder.Services.AddScoped<ITwoQuestionsService, TwoQuestionsService>();
builder.Services.AddScoped<IGreaterOrLessService, GreaterOrLessService>();

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
