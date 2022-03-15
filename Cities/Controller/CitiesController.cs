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
        public List<City> GetAll()
        {
            using (CitiesDBEntities1 c = new CitiesDBEntities1())
            {
                return c.Cities.ToList();
            }
        }
    }
}

