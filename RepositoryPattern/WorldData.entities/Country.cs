using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldData.entities
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        // navigation prop
        public List<State> states { get; set; }
    }
}
