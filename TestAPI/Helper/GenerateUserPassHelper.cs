using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAPI.Libraries;
using TestAPI.Models;

namespace TestAPI.Helper
{
    public class GenerateUserPassHelper
    {
        public UsernamePasswordModel GenerateUsernamePassword()
        {
            return new GenerateUserPassLibrary().GenUserPass();
        }
    }
}