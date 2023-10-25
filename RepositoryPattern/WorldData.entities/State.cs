using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldData.entities
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryID { get; set; }
        public Country Country { get; set; }

        // navigation prop
        public List<City> Cities { get; set; }
    }
}
