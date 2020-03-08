using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Libro
    {
        public int idLibro { get; set; }
        public string titulo { get; set; }
        public string editorial { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public string pais { get; set; }
        public string isbn { get; set; }
        public string imageUrl { get; set; }
        public string autores { get; set; }
    }
}
