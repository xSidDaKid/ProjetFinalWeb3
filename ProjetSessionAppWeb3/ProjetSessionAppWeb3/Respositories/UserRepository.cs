using Microsoft.EntityFrameworkCore;
using ProjetSessionAppWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionAppWeb3.Respositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataBaseContext _context;
        private int id;

        public UserRepository(DataBaseContext context)
        {
            _context = context;
            if (context.Users.Count() > 0)
            {
                id = _context.Users.AsEnumerable().Last().IdUser;
                _context.ChangeTracker.Clear();
            }
            else
            {
                id = 0;
            }
        }
        public async Task Create(User u)
        {
            _context.Users.Add(u);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsersByNom(string nom)
        {
            return await _context.Users.Where(u => u.Username.StartsWith(nom)).ToListAsync();
        }

        public async Task<User> UserLogin(string nom, string password)
        {
            IQueryable<User> query = _context.Users.Where(u => u.Username.
            Equals(nom) &&
            u.Password.Equals(password));
            if (query.Any())
            {
                return await query.FirstOrDefaultAsync();
            }
            else
            {
                User nullUtilisateur = new User
                {
                    IdUser = 0
                };
                return nullUtilisateur;
            }
        }
    }
}
