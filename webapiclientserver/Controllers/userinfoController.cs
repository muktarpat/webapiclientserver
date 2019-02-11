using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapiclientserver.Models;
using System.Data.Entity;

namespace webapiclientserver.Controllers
{
   
    public class userinfoController : ApiController
    {
        REVIEWEntities obj = new REVIEWEntities();

        public List<userinfo> getusers()
        {
            return obj.userinfoes.ToList();
        }


        public void postuser(userinfo u)
        {
                obj.userinfoes.Add(u);
                obj.SaveChanges();

        }

    }
}
