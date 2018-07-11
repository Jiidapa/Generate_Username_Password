using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAPI.Models;

namespace TestAPI.Libraries
{
    public class GenerateUserPassLibrary
    {
        private static Random random = new Random();

        public string GenerateUsername()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());       
        }

        public string GeneratePassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public UsernamePasswordModel GenUserPass()
        {
            string Username = GenerateUsername();
            string Password = GeneratePassword();

            UsernamePasswordModel user = new UsernamePasswordModel();
            user.username = Username;
            user.password = Password;

            return user;
        }
    }
}