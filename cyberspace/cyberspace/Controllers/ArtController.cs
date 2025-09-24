using cyberspace.Data;
using cyberspace.Models;
using cyberspace.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace cyberspace.Controllers
{
    [ApiController]
    [Route("art")]
    public class ArtController : Controller
    {
        //private ArtPostCollectionService _postCollectionService;
        private readonly cyberspaceContext _context;

        public ArtController(cyberspaceContext context)
        {
            _context = context;
        }
        //public ArtController()
        //{
        //    //_context = context;
        //}
        // GET: ArtPosts
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.ArtPost.ToListAsync());
        }
        //public ArtController() {
            
        //}
        /*[HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "My Art";
            HttpContext.Items["Title"] = "My Art";
            Console.WriteLine(HttpContext.Items["Title"]);
            return View("Index");
        }*/
        //[HttpGet]
        //public IActionResult GetArtPosts()
        //{
        //    //List<ArtPost> Posts = _postCollectionService.GetAll();
        //    //return Ok(Posts);
        //    return Ok();
        //}
        [Route("images")]
        public IActionResult Images()
        {
            return View("images");
        }
    }
}
