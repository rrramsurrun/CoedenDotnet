# An ASP.NET backend for the Coeden project

This is a .NET backend for the Coeden tree mapper project. The frontend can be seen [here](https://github.com/rrramsurrun/CoedenReactTS).

The code in this repo is called in Program.cs using the following:

    builder.Services.AddCodenamesServices(builder.Configuration);

    var app = builder.Build();

    var webSocketOptions = new WebSocketOptions()
    {
      KeepAliveInterval = TimeSpan.FromMinutes(2),
    };

    app.UseWebSockets(webSocketOptions);

    app.UseStaticFiles(new StaticFileOptions{
    FileProvider = new PhysicalFileProvider(
    Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "dist")),
    RequestPath = "/codenames",
    });

    app.MapControllers();
