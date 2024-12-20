using GrpcService;

var builder = WebApplication.CreateBuilder(args);

// Add gRPC services to the DI container
builder.Services.AddGrpc();

var app = builder.Build();

// Map gRPC services
app.MapGrpcService<MyProductService>();

// Add a simple HTTP route for testing
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client.");

app.Run();