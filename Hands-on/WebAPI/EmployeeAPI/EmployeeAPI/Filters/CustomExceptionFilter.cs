using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;
using System.Web.Http;

namespace EmployeeAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var error = context.Exception;
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\logs"))
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\logs");
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '-') + ".txt";
            //string filepath = @"C:\Users\Vraj\Desktop\#\Handson\WebAPI\EmployeeAPI\EmployeeAPI\log.txt";


            if (!File.Exists(filepath))
                File.Create(filepath);


            else
            {
                using (StreamWriter writer = File.AppendText(filepath))
                {
                    writer.WriteLine("******************************************");
                    writer.WriteLine("Exception Caught in API");
                    writer.WriteLine("Message: " + error.Message);
                    writer.WriteLine("Stack Trace: " + error.StackTrace);
                    writer.WriteLine(DateTime.Now);
                    writer.WriteLine("******************************************");
                }
                context.ExceptionHandled = true;
                context.Result = new ExceptionResult(error, true);
            }

        }
    }
}
