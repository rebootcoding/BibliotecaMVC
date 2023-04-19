using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BibliotecaMVC.Filters
{
	public class CustomActionFilter : Attribute, IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			if (context.HttpContext.Session.Get("user") == null)
			{
				context.Result = new UnauthorizedResult();
			}
		}
	}
}
