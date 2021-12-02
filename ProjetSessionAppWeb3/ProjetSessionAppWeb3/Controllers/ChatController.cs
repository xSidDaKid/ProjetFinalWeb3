﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjetSessionAppWeb3.Models;
using ProjetSessionAppWeb3.Respositories;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<ActionResult> Chat()
        {
            //Get Session Info
            // var user = HttpContext.Session.GetInt32("userSession");
            var user = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("userSession"));
            List<Chat> chats = (List<Chat>) await _cr.GetAllChats();
            ViewBag.chats = chats;
            ViewBag.userSession = user;
            return View(user);
        }
    }
}
