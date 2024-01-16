using accounting_api.Data;
using accounting_api.Data.Unitofwork;
using Microsoft.EntityFrameworkCore; 

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("db_main");
var connectionStringAt = builder.Configuration.GetConnectionString("db_at");

builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseSqlServer(connectionString));

builder.Services.AddDbContext<ApplicationAtDBContext>(options =>
options.UseSqlServer(connectionStringAt));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<UnitOfWork>();
builder.Services.AddMemoryCache();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 

//var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>()
//                .UseSqlServer(builder.Configuration.GetConnectionString("db_main"));
 
//using (var dbContext = new ApplicationDBContext(optionsBuilder.Options))
//{
//    // Attempt to open a connection
//    dbContext.Database.OpenConnection();

//    // Check if the connection is open
//    if (dbContext.Database.CanConnect())
//    { 
//        Console.WriteLine("Database connection is open and working.");
//    }
//    else
//    {
//        Console.WriteLine("Database connection is not open.");
//    }
//}
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.MapControllers();

app.Run();
