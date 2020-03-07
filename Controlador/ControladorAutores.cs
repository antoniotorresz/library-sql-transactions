using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorAutores
    {

        public static DataTable ListarAutores()
        {
            DAutor datos = new DAutor();
            return datos.ListarAutores();
        }
        public static DataTable ListarNombreAutores()
        {
            DAutor datos = new DAutor();
            return datos.LlenarComboNombre();
        }
    }
}
