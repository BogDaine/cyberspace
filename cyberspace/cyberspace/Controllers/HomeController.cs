using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace cyberspace.Controllers
{
    [ApiController]
    [Route("")]
    [Route("home")]
    public class HomeController : Controller //ControllerBase
    {


        [Route("girl")]
        public string aaa(int number = 1)
        {
            string[] strings = new string[] {"Maya", "Maria", "Mara"};
            int cnt = Math.Clamp(number, 0, strings.Length-1);
            ViewData["girls"] = strings;
            List<string> girls = new List<string> { "Marius", "Maria", "Marian" };
            ViewData["girls"] = girls;
            ViewData["n"] = 5;
            return HtmlEncoder.Default.Encode(strings[cnt]);
        }
        [HttpGet]
        public IActionResult Index(int n = 1)
        {


            ViewData["n"] = n;
            aaa();
            return View("Index");
        }
        [Route("aboutme")]
        [HttpGet]
        public IActionResult AboutMe()
        {
            return View("AboutMe");
        }
    }
}
