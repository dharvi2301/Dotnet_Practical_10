using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_04.Filters
{
	public class CustomExceptionFilter: FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            // Check if the exception is already handled
            if (!filterContext.ExceptionHandled)
            {

                // Set view result
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error"
                };

                // Mark exception as handled
                filterContext.ExceptionHandled = true;
            }
        }
    }
}