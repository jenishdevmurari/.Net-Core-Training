namespace MiddlewareExample.MyMiddleware
{
    public class CustomeMiddleware :IMiddleware
    {
        public async Task InvokeAsync(HttpContext context,RequestDelegate next)
        {
            Console.WriteLine("<html><body>Custom Middleware");
            await context.Response.WriteAsync("Custome Middleware");
            await next(context);
        }
    }
}
