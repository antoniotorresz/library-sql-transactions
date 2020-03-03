using Modelo;
using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DLibro
    {
        //Funciones para poder manipular los datos de la tabla de provedores 
        public DataTable ListarLibros()
        {
            SqlDataReader resultado; // lee una secuencia de filas en la tabla
            DataTable tabla = new DataTable();

            SqlConnection sqlCon = new SqlConnection(); // Con este objeto hacemos al conexion a la base de datos
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion(); //Utilizamos la variable tipo sql connection que obtenemos desde la calse conexion
                SqlCommand comando = new SqlCommand("ObtenerLibros", sqlCon); // este es el comando que se va a ejecutar el la base de datos
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                //Se ejecuta el comando
                resultado = comando.ExecuteReader();
                //se carga en el objeto tabla
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            { // Este codigo se va a ejecutar aunque haya alguna excepcion. **SIEMPRE SE CERRARÁ LA CONEXIÓN**

                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public string InsertarLibroAutor(Libro l, List<int> idAutores, List<string> pags)
        {
            string resultado = "";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection = Conexion.getInstancia().CrearConexion();
            SqlTransaction trx = sqlConnection.BeginTransaction();
            try
            {
                int idLibro = InsertarLibro(l);



                trx.Commit();
            }
            catch {
                trx.Rollback();
            }

            return null;
        }

        public int InsertarLibro(Libro libro)
        {
            int idGenerado = 0;
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("InsertarLibro", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@titulo", SqlDbType.VarChar).Value = libro.titulo;
                command.Parameters.Add("@editorial", SqlDbType.VarChar).Value = libro.editorial;
                command.Parameters.Add("@fechaPublicacion", SqlDbType.Date).Value = libro.fechaPublicacion;
                command.Parameters.Add("@pais", SqlDbType.VarChar).Value = libro.pais;
                command.Parameters.Add("@isbn", SqlDbType.VarChar).Value = libro.isbn;
                command.Parameters.Add("@imageUrl", SqlDbType.VarChar).Value = libro.imageUrl;

                //Aqui debemos de hacer la transaccion... 

                //Abrimos la conexion y guardamos el resultado en respuesta

                sqlConnection.Open();

                if (command.ExecuteNonQuery() == 1) // el 1 respresenta un resultado exitoso
                {
                    //Esto quiere decir que se ingresó el provedor correctamente
                    //respuesta = "OK";
                }
                else
                {
                    //respuesta = "No se pudo completar la solicitud...";
                }


            }
            catch (Exception e)
            {
                //respuesta = e.ToString();
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return idGenerado;
        }

    }
}
