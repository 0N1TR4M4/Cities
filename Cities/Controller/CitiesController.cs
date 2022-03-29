using Cities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities.Controller
{
    class CitiesController
    {
        public List<Models.Cities> GetAll()
        {
            using (CitiesDBEntities c = new CitiesDBEntities())
            {
                return c.Cities.ToList();
            }
        }

        public void CreateCity(Models.Cities s)
        {
            using (CitiesDBEntities ex = new CitiesDBEntities())
            {
                var lastCity = ex.Cities.ToList().LastOrDefault();
                if(lastCity == null)
                {
                    lastCity = new Models.Cities();
                    lastCity.Id = 0;
                }
                s.Id = lastCity.Id + 1;
                ex.Cities.Add(s);
                ex.SaveChanges();
            }
        }
    }
}

