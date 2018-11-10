using Feature.GenericCallout.Services;
using System.Web.Mvc;

namespace Feature.GenericCallout.Controllers
{
    public class GenericCalloutController : Controller
    {
        private IGenericCalloutService _genericCalloutService;

        public GenericCalloutController(IGenericCalloutService genericCalloutService)
        {
            _genericCalloutService = genericCalloutService;
        }

        public ActionResult Default()
        {
            var model = _genericCalloutService.GetGenericCallout();

            return View();
        }
    }
}