namespace MiddlewareExample.MyMiddleware
{
    public class CustomeMiddleware :IMiddleware
    {
        public async Task InvokeAsync(HttpContext context,RequestDelegate next)
        {
            Console.WriteLine("Custom Middleware");
            await context.Response.WriteAsync("Custom Middleware");
            await next(context);
        }
    }
}
