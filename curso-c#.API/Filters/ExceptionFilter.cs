using ClassLibrary1.Execeptions.ExeptionsBase;
using curso_rocket.Communication.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace curso_c_.API.Filters;

public class ExceptionFilter : IExceptionFilter
{



    public void OnException(ExceptionContext context)
    {
        if (context.Exception is CursoCExeception cursoCExeception)
        {

           context.HttpContext.Response.StatusCode =(int)cursoCExeception.GetHttpStatusCode();

           context.Result = new ObjectResult(new ErrorMessageJson(cursoCExeception.GetErrors()));



        }
        else
        {
            ThrowUnknowError(context);

        }
    }
    private void ThrowUnknowError(ExceptionContext context) {

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(new ErrorMessageJson("Erro desconhecido"));

    }

}