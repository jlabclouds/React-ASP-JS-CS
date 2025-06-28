var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ReactNetJS_Server>("reactnetjs-server");

builder.Build().Run();
