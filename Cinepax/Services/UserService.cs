
using System.Collections.Generic;
using Cinepax.Models;
using System.Linq;
using System;

namespace Cinepax.Services
{
    public class UserService
    {
        public UserService()
        {

        }

        public User Login(User user)
        {
            using(CinepaxContext cinepaxContext = new CinepaxContext())
            {
                User result = cinepaxContext
                    .Users
                    .Where(item => item.Email == user.Email && item.Password == user.Password)
                    .FirstOrDefault();

                if(result == null) {
                    throw new Exception("Identifiant et/ou mot de passe invalide");
                }
                return result;

            }
        }
    }
}