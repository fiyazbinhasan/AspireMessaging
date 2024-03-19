var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");
var messaging = builder.AddRabbitMQ("RabbitMQConnection");

var apiService = builder.AddProject<Projects.AspireMessaging_ApiService>("apiservice")
    .WithReference(messaging);

builder.AddProject<Projects.AspireMessaging_Web>("webfrontend")
    .WithReference(cache)
    .WithReference(apiService)
    .WithReference(messaging);

builder.Build().Run();


