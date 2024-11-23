using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using GerenciadorApi.Exceptions;
using GerenciadorApi.ViewModels;

namespace GerenciadorApi.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var resultado = new ErroVM(exception.Message);
            var codigo = HttpStatusCode.InternalServerError;
            
            if(exception is ValidacaoException) codigo = ((ValidacaoException) exception).Codigo;                                    
            
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)codigo;
            
            return context.Response.WriteAsync(JsonConvert.SerializeObject(resultado));
        }
    }
}