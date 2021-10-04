using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetTraining.Filters
{
    public class AddHeaderFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                context.HttpContext.Request.Headers.Add("RookieRequest", "ABC");
            }
            catch (Exception)
            {

            }
            
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            try
            {
                context.HttpContext.Response.Headers.Add("RookieReturn", "DEF");
            }
            catch (Exception)
            {

            }
            
        }
    }
}
