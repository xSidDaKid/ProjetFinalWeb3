using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetSessionAppWeb3.Respositories;

namespace ProjetSessionAppWeb3.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatRepository _cr;

        public ChatController(IChatRepository cr)
        {
            _cr = cr;
        }

        [HttpGet]
        public ActionResult Chat()
        {
            return View();
        }
    }
}
