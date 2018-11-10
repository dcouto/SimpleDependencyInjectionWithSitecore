using Feature.GenericCallout.Services;
using System.Web.Http;

namespace Feature.GenericCallout.Controllers
{
    public class GenericCalloutApiController : ApiController
    {
        private IGenericCalloutService _genericCalloutService;

        public GenericCalloutApiController(IGenericCalloutService genericCalloutService)
        {
            _genericCalloutService = genericCalloutService;
        }

        [Route("my-solution-api/feature/generic-callout")]
        public string GetGenericCallout()
        {
            return "This is the response.";
        }
    }
}