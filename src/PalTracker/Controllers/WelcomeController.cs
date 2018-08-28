using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController: Controller
    {
        [HttpGet]
        public string SayHello() => _message;

        private string _message;

        public WelcomeController(WelcomeMessage welcome)
        {
            _message = welcome.Message;
        }

    }
}