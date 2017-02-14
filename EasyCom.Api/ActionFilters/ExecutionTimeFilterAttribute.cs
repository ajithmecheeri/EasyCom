using System.Diagnostics;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace EasyCom.Api.ActionFilters
{
    public class ExecutionTimeFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            actionContext.Request.Properties[actionContext.ActionDescriptor.ActionName] = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
            Stopwatch timer = (Stopwatch)actionExecutedContext.Request.Properties[actionExecutedContext.ActionContext.ActionDescriptor.ActionName];
            Trace.WriteLine(string.Format("{0} : Time taken for execution - {1}", actionExecutedContext.ActionContext.ActionDescriptor.ActionName, timer.Elapsed));
        }
    }
}