# An ASP.NET backend for the Coeden project

This is a .NET backend for the Coeden tree mapper project. The frontend can be seen [here](https://github.com/rrramsurrun/CoedenReactTS).

The code in this repo is called in Program.cs using the following:

    builder.Services.AddCoedenServices(builder.Configuration);

    var app = builder.Build();

    app.MapControllers();
