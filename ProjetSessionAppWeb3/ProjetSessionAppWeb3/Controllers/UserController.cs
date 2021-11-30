﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetSessionAppWeb3.Models;
using ProjetSessionAppWeb3.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Controllers
{
    public class UserController : Controller
    {
        // GET: UtilisateurController
        private UserRepository ur;
            
            
        private static int incrementedId;
        
        public UserController(UserRepository u)
        {
            ur = u;
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


        public ActionResult doRegister(string username, string password, string password2, string email)
        {
            if (password.Equals(password2))
            {


                incrementedId++;
                User userRegister = new User();
                userRegister.Email = email;
                userRegister.Username = username;
                userRegister.Password = password;
                userRegister.IdUser = incrementedId;

                ur.Create(userRegister);
            }


            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password) 
        {
           /* if (!username.equals("") && !password.equals(""))
            { 
                
            }*/
   

            return Index();
        }

        // GET: UtilisateurController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UtilisateurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UtilisateurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UtilisateurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
