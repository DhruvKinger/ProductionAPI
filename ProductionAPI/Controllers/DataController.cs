using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductionAPI.Controllers
{
    public class DataController : ApiController
    {
        public IEnumerable<User> Get()
        {

            using (ProductionAppEntities entities = new ProductionAppEntities())
            {
                return entities.Users.ToList();
            }
        }


        public User Get(string Id)
        {
            using (ProductionAppEntities entities = new ProductionAppEntities())
            {
                return entities.Users.FirstOrDefault(r=>r.id == Id);
            }
        }

    }
}
