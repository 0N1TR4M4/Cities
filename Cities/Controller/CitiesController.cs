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
        public List<Models.City> GetAll()
        {
            using (CitiesDBEntities c = new CitiesDBEntities())
            {
                return c.Cities.ToList();
            }
        }

        public void CreateCity(Models.City s)
        {
            using (CitiesDBEntities ex = new CitiesDBEntities())
            {
                var lastCity = ex.Cities.ToList().LastOrDefault();
                if(lastCity == null)
                {
                    lastCity = new Models.City();
                    lastCity.Id = 0;
                }
                s.Id = lastCity.Id + 1;
                ex.Cities.Add(s);
                ex.SaveChanges();
            }
        }
    }
}

