using Batch4.Api.ExpenseTracker.BusinessLogic.Services;
using Batch4.Api.ExpenseTracker.DataAccess.Db;
using Batch4.Api.ExpenseTracker.DataAccess.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
},
ServiceLifetime.Transient,
ServiceLifetime.Transient);

#region register services
// Register DA_Category as a service
builder.Services.AddScoped<DA_Category>();
// Register BL_Category as a service
builder.Services.AddScoped<BL_Category>();

// Register DA_Expense as a service
builder.Services.AddScoped<DA_Expense>();
// Register BL_Expense as a service
builder.Services.AddScoped<BL_Expense>();
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
