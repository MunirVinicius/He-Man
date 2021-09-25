using Microsoft.AspNetCore.Mvc;
using eternia.Models;

namespace eternia.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index(){
            var data = Character.CreateCharacters();
            return View(data);
        }
        
    }
}