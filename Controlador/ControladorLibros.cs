using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorLibros
    {
        public static DataTable ListarLibros()
        {
            DLibro datos = new DLibro();
            return datos.ListarLibros();
        }

        public static string InsertarLibroAutor(string titulo, string editorial, DateTime fechaPub, string pais, string isbn, string url,
        List<string> nombres, List<string> pags)
        {

            List<int> idAutores = new List<int>();
            Libro l = new Libro();

            l.titulo = titulo;
            l.editorial = editorial;
            l.fechaPublicacion = fechaPub;
            l.pais = pais;
            l.isbn = isbn;
            l.imageUrl = url;

            DLibro datos = new DLibro();

            foreach (string nombre in nombres)
            {
                idAutores.Add(datos.ObtenerIdAutor(nombre));
            }
                        
            return datos.InsertarLibroAutor(l, idAutores, pags);
        }
    }
}
