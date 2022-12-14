using dotnetAPI.Data;
using dotnetAPI.Repositories;
using dotnetAPI.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MySql.EntityFrameworkCore.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//connection to the DB
builder.Services.AddDbContext<NZWalksDbContext>(options => {
    options.UseMySQL(builder.Configuration.GetConnectionString("NZWalksDB"));
});

builder.Services.AddScoped<RegionRepository, RegionRepositoryImpl>();
builder.Services.AddScoped<WalksRepository, WalksRepositoryImpl>();
builder.Services.AddScoped<WalkService, WalkServiceImpl>();

//inject Mapper
//Assembly is all the program, so it will look for the Profiles and then use the maps for the data
builder.Services.AddAutoMapper(typeof(Program).Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices {
    public void ConfigureDesignTimeServices(IServiceCollection serviceCollection) {
        serviceCollection.AddEntityFrameworkMySQL();
        new EntityFrameworkRelationalDesignServicesBuilder(serviceCollection)
            .TryAddCoreServices();
    }
}
