using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Cine.Entities
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Duration { get; set; }
        
        public string Actors { get; set; }  

        public string Genre { get; set; }

        public string Country { get; set; }

        public string Classification { get; set; }



    }
}
