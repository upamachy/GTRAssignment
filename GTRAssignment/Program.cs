using GTRAssignment.Data;
using GTRAssignment.RepositoryData.IRepository;
using GTRAssignment.RepositoryData.Repository;
using GTRAssignment.ServiceData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDBContext>(x => x.UseSqlServer(connectionstring));

//Add repositories
builder.Services.AddScoped(typeof(ICommonRepository<>), typeof(CommonRepository<>));
builder.Services.AddScoped<IBrandRepository,BrandRepository>();
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<IPurchaseRepository,PurchaseRepository>();
builder.Services.AddScoped<ISaleRepository,SaleRepository>();
builder.Services.AddScoped<ISuppilerRepository,SuppilerRepository>();
builder.Services.AddScoped<IWarehouseRepository,WarehouseRepository>();

//Add Service
builder.Services.AddScoped<IGTRService,GTRService>();


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
