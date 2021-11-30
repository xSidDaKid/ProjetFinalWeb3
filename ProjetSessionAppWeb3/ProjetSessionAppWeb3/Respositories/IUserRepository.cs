﻿using ProjetSessionAppWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Respositories
{
    interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersByNom(string nom);
        Task<User> UserLogin(string nom, string password);
        Task Create(User u);
    }
}