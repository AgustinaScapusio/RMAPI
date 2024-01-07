using Microsoft.AspNetCore.Mvc;
using RMAPI.Models;
using RMAPI.NasaAPI;
using System.Diagnostics;

namespace RMAPI.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly INasaApi _nasaApi;

        public HomeController( INasaApi nasaApi)
        {
          
            _nasaApi = nasaApi;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(new IndexViewModel());
        }
        [HttpPost("/")]
        public async Task<IActionResult> Index(IndexViewModel model)
        {
           
         var roverResponse = await _nasaApi.GetRoverResponse(model.Sol, model.Camera);
         model.RoverResponse = roverResponse;
           
        return View(model);
        }
        
    }
}
