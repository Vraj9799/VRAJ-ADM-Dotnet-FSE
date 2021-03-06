using Logging_With_Log4Net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Logging_With_Log4Net.Filters
{
    public class CustomFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomException" };
            var modelMetaData = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(modelMetaData, context.ModelState);
            result.ViewData.Add("HandleException", context.Exception);
            context.Result = result;
            context.ExceptionHandled = true;
            LoggerManager loggerManager = new LoggerManager();
            loggerManager.LogInformation("Exception : " + context.Exception.Message);
        }
    }
}
