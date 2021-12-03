using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjetSessionAppWeb3.Models;
using ProjetSessionAppWeb3.Respositories;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Controllers
{
    public class UserController : Controller
    {
        // GET: UtilisateurController
        private readonly IUserRepository _ur;
        public UserController(IUserRepository u)
        {
            _ur = u;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: UtilisateurController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Details()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {


            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Register(string username, string email, string password, string password2)
        {
            ViewBag.ErorMessage = "";
            if (username == null || email == null || password == null || password2 == null)
            {
                ViewBag.ErrorMessage = ("Remplir tous les champs");
                return View();
            }
            if (!password.Equals(password2))
            {
                ViewBag.ErrorMessage = ("Les deux mots de passes ne sont pas les memes");
                return View();
            }
            else if (password.Equals(password2))
            {
                User userRegister = new User();
                userRegister.Email = email;
                userRegister.Username = username;
                userRegister.Password = password;
                await _ur.Create(userRegister);
            }
            return View("Login");
        }

        [HttpPost]
        public async Task<ActionResult> Login(string username, string password)
        {
            ViewBag.ErrorMessage = "";
            if (username == null || password == null)
            {
                ViewBag.ErrorMessage = ("Remplir tous les champs");
                return View();
            }
            else
            {
                User user = await _ur.UserLogin(username, password);
                HttpContext.Session.SetInt32("userSession", user.IdUser);
                HttpContext.Session.SetString("userSession", JsonConvert.SerializeObject(user));
                ViewBag.userSession = ("userSession", user);
                return View("../Home/Index");
            }

            return View("../Home/Index");
        }

        [HttpGet]

        public ActionResult Logout()
        {
            ViewBag.UserSession = null;
            return View("../Home/Index");
        }

        public ActionResult UserPage() {
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("userSession"));
            ViewBag.userSession = user;
            return View(); 
        }

        public async Task<ActionResult> Change(string username, string email, string password)
        {
            User userModife = new User();
            userModife.Email = email;
            userModife.Username = username;
            userModife.Password = password;
            await _ur.Modify(userModife);
            return View("../Home/Index");
        }
    }
}
