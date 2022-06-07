using Wormhunt;

var builder = WebApplication.CreateBuilder(args);
Bootstrapper.Bootstrap(builder);

var app = builder.Build();
Bootstrapper.Bootstrap(app);

app.Run();
