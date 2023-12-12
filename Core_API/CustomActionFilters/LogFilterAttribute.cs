using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Core_API.CustomActionFilters
{
    /// <summary>
    /// ActionFilterAttribute: The Abstract base class for Creating Custom Filters
    /// </summary>
    public class LogFilterAttribute : ActionFilterAttribute
    {

        private void LogRequest(string currentState, RouteData route)
        {
            string controller = route.Values["controller"].ToString();
            string action = route.Values["action"].ToString();

            Debug.WriteLine($"Current Execution State: {currentState} in Action Method : {action} of Controller : {controller}");
        }


        /// <summary>
        /// Invoked when an Action Method is hit 
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            LogRequest("OnActionExecuting", context.RouteData);
        }
        /// <summary>
        /// Executed when Actio  Method have completed its execution and Ready to Return result
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            LogRequest("OnActionExecuted", context.RouteData);
        }
        /// <summary>
        /// Invoke to Generate the Result
        /// </summary>
        /// <param name="context"></param>
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            LogRequest("OnResultExecuting", context.RouteData);
        }
        /// <summary>
        /// Executed when the Result is returned 
        /// </summary>
        /// <param name="context"></param>
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            LogRequest("OnResultExecuted", context.RouteData);
        }
    }
}
