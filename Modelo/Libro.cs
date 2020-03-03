using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Libro
    {
        int idLibro { get; set; }
        string titulo { get; set; }
        string editorial { get; set; }
        DateTime fechaPublicacion { get; set; }
        string pais { get; set; }
        string isbn { get; set; }
        string imageUrl { get; set; }
    }
}
