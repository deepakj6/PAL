using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/env")]
    public class EnvController: Controller
    {
        [HttpGet]
        public IActionResult GetEnv()
        {
            return Json(cfInfo);
        }

        private CloudFoundryInfo cfInfo;

        public EnvController(CloudFoundryInfo info)
        {
            cfInfo = info;
        }

    }
}