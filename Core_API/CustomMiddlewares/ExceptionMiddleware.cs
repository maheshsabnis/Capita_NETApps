namespace Core_API.CustomMiddlewares
{
    public record ErrorInfo
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }

    /// <summary>
    /// This class will be used as Custom Exception Middleware Class 
    /// </summary>
    public class ExceptionMiddleware
    {
        RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        /// <summary>
        /// Method that contains logic for Custom Exception Middleware 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context) 
        {
            try
            {
                /* If No Error while Processing Request then goto next middleware in pipeline*/
               await _next(context);
            }
            catch (Exception ex)
            {
                /* Logic for Handling an Exception and Returning the response */
                // 1. Handle the exception so that the current request will be stopped and Runtime will hand-over the exception details in respose

                /* The ErroCode can be read from the Configuration file or may be from otehr Constants */
                context.Response.StatusCode = 500;
                string messasge = ex.Message;

                ErrorInfo errorInfo = new ErrorInfo() 
                {
                   ErrorCode = context.Response.StatusCode,
                   ErrorMessage = messasge
                };

                // 2. Write the response
                await context.Response.WriteAsJsonAsync<ErrorInfo>(errorInfo);

            }
        }
    }

    /* Add a class that will act as an extension class to register the ExceptionMiddleware class a custom middleware */

    public static class ExceptionMiddlewareExtensions
    {
        public static void UseAppExceptionHandler(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ExceptionMiddleware>();
        }
    }

}
