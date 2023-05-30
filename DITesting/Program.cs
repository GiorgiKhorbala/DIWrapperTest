using DITesting.Services;
using DITesting.Wrappers;

var builder = WebApplication.CreateBuilder(args);
//Here we're going to Register all our services
builder.Services.AddTransient<IVeryUsefulService1, VeryUsefulService1>();
builder.Services.AddTransient<IVeryUsefulService2, VeryUsefulService2>();
builder.Services.AddTransient<IDIWrapper, DIWrapper>();

var serviceProvider = builder.Services.BuildServiceProvider();
//Supply Service Provider Instance to Injector helper class
Injector.SetServiceProvider(serviceProvider);

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGet("/service", (IVeryUsefulService1 veryUsefulService1, IVeryUsefulService2 veryUsefulService2) => veryUsefulService2.DoWork());
app.MapGet("/service2", (IDIWrapper dIWrapper) => dIWrapper.veryUsefulService2.DoWork());

app.Run();

