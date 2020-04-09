using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllInOne.Models
{
    public class AuthTokenGoogle
    {
        public string token { get; set; }
        public string refreshToken { get; set; }
        public long expr { get; set; }
        public string email { get; set; }

        public AuthTokenGoogle()
        {
        }

        public AuthTokenGoogle(string token, string refreshToken, long expr, string email)
        {
            this.token = token;
            this.refreshToken = refreshToken;
            this.expr = expr;
            this.email = email;
        }
    }
}
