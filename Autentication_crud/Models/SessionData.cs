using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autentication_crud.Models
{
    public class SessionData
    {
        private String session;
        public String getSession(String valor)
        {
            this.session = Convert.ToString(HttpContext.Current.Session[valor]);

            return session;
        }
    }
}
