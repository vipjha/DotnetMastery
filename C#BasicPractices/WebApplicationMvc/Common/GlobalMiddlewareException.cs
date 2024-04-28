namespace WebApplicationMvc.Common
{
    public class GlobalMiddlewareException
    {
        public readonly RequestDelegate _next;
        public GlobalMiddlewareException(RequestDelegate next) 
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            
        }
    }
}
