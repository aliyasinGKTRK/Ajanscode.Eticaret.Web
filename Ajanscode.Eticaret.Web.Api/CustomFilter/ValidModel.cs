using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.Api.CustomFilter
{
    public class ValidModel<TEntity> : IActionFilter where TEntity : class, ITable, new()
    {

        IGenericService<TEntity> _genericService;
        public ValidModel(IGenericService<TEntity> genericService)
        {
            _genericService = genericService;
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {
            //context.Result = !context.ModelState.IsValid ? new BadRequestObjectResult(context.ModelState) : context.Result;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

            var argument = context.ActionArguments.ToList();
            var deger = context.ActionArguments.Where(x => x.Key == "id").FirstOrDefault();
            var checkedid = (int)deger.Value;
            var entity = _genericService.FirstFilterByIdAsync(checkedid);

            if (entity == null)
            {
                context.Result = new NotFoundObjectResult($"{checkedid} li veri bulunamadı");
            }
            //if (!context.ModelState.IsValid)
            //{
            //    context.Result = new BadRequestObjectResult(context.ModelState);
            //}
        }
    }
}
