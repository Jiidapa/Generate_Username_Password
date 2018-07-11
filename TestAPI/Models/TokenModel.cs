using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class TokenModel
    {
        public int id_token {get;set;}
        public string access_token { get; set; }
        public int expire_token { get; set; }
        public string refresh_token { get; set; }
        public string status_token { get; set; }
    }
}