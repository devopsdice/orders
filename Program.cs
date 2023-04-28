using Order.HostedService;
using Order.MessageBroker;
using Order.Repository;
using Order.Repository.Base;
using Order.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IDapperContext, DapperContext>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddSingleton<IMessageBrokerService, RabbitMQService>();
builder.Services.AddHostedService<OrderProcessor>();
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
