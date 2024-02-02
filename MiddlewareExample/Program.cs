using MiddlewareExample.MyMiddleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<CustomeMiddleware>(); // injecting Custom Middleware with service
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

// Chainning Middleware
app.Use(async (context,next)=>
{
    Console.WriteLine(" Middleware ");
    await next();
});

app.Use(async (context, next) =>
{
    Console.WriteLine(" Middleware 1 ");
    await next();
});

app.Use(async (context,next) =>
{
    Console.WriteLine(" Middleware 3 ");
    
    await next(context);
});

app.Use(async (context, next) =>
{
    Console.WriteLine(" Middleware 4 ");
    await next();
});


// Conventional Middleware
app.UseMiddleware<Middleware1>();
app.UseMiddleware<Middleware2>();

app.UseMiddleware<CustomeMiddleware>();  //Custom Middleware

app.Run(async (context) =>
{
    Console.WriteLine(" End of the Pipeline ");
    await context.Response.WriteAsync("\n Hello Welcome To Bacancy!!!!!!!! ");
});

app.Run();
;