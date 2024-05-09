namespace Solid.API.Middlewares
{
    public class ShabbatMiddleware
    {

        private readonly RequestDelegate _next;
    

        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var currentDay = DateTime.Today.DayOfWeek;

            if (currentDay == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = 400;
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("Service is inactive on Saturdays.");
            }
            else
            {
                // Continue processing the request
                await _next(context);
            }
        }

    }
}
