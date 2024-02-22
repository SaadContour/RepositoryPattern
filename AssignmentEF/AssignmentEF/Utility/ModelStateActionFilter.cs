using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AssignmentEF.Utility
{
    public class ModelStateActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var controller = (Controller)context.Controller;
                var viewResult = new ViewResult
                {
                    ViewName = context.RouteData.Values["action"].ToString(),
                    ViewData = new ViewDataDictionary(
                        new EmptyModelMetadataProvider(),
                        context.ModelState
                        )
                };
                context.Result = viewResult;
            }

            base.OnActionExecuting(context);
        }
    }
}
