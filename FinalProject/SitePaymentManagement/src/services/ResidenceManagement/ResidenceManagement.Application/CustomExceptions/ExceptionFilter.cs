using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.CustomExceptions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public async override Task OnExceptionAsync(ExceptionContext context)
        {
            //Fırlatılan exception'ın status code'unu bilemediğimiz durumda 
            //default olarak '500 Internal Server Error'ı belirliyoruz.
            var statusCode = HttpStatusCode.InternalServerError;

            //Fırlatılan exception DataNotFoundException ise
            //status code'u '404 Not Found' yapıyoruz.
            if (context.Exception is IsExistExeption)
                statusCode = HttpStatusCode.NotFound;
            if (context.Exception is NotFoundException)
                statusCode = HttpStatusCode.NotFound;

            //Bu request'e karşılık verilecek response'a status code'u ve
            //result'u değiştirerek dönebiliriz.
            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)statusCode;

            context.Result = new JsonResult(new
            {
                error = new[] { context.Exception.Message },
                statusCode = (int)statusCode,
                stackTrace = context.Exception.StackTrace
            });
        }
    }
}
