using System;
using System.Web.Mvc;
using Dinamico.Models;
using N2.Web;
using N2.Web.Mvc;

namespace Dinamico.Controllers
{
	[Controls(typeof(ContentPage))]
	public class ContentPagesController : ContentController<ContentPage>
	{
		public override ActionResult Index()
		{
			if (CurrentItem == null)
			{
				//TODO: Maybe could search for an error page and display that instead?

				// no item to render, 404 error
				Response.StatusCode = 404;
				return new EmptyResult();
			}
			return View(CurrentItem.TemplateKey, CurrentItem);
		}
	}
}