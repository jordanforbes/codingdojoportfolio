using Microsoft.AspNetCore.Mvc;
namespace NewProject.Controllers //be sure to use your own project's namespace!
{
    public class HelloController : Controller //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")] //type of request
        // [Route ("")] //associated route string (exclude the leading /)
        public string Index () {
            return "This is my Index!";
        }
        [HttpGet("about")]

        public string About()
        {
            return "about";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "these are my projects!";
        }

        [HttpGet("contacts")]
        public string Contacts()
        {
            return "These are my contacts!";
        }
        [HttpPost]
        [Route("submission")]

        public string FormSubmission(string formInput)
        {
            return formInput;
        }
    }
}