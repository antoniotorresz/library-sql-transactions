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

            SqlTransaction trx = sqlConnection.BeginTransaction("Sample");
            try
            {
                int idLibro = InsertarLibro(l);
                SqlCommand command = new SqlCommand("InsertLibroAutor", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < idAutores.Count(); i++)
                {

                    command.Parameters.Add("@idLibro", SqlDbType.VarChar).Value = idLibro;
                    command.Parameters.Add("@idAutor", SqlDbType.VarChar).Value = idAutores[i];
                    command.Parameters.Add("@numPaginas", SqlDbType.Date).Value = Convert.ToInt32(pags[i]);
                    command.ExecuteNonQuery();

                }

                trx.Commit();
                resultado = "Toda ha salido bien";
            }
            catch (Exception ex)
            {
                trx.Rollback();
                resultado = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return resultado;
        }

        public int InsertarLibro(Libro libro)
        {
            Int32 idGenerado = 0;
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
                idGenerado = (Int32)command.ExecuteScalar();

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
                //if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return idGenerado;
        }

        public int ObtenerIdAutor(string valor)
        {
            int respuesta;
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("IdAutor", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                //Agregamos los parametros:
                command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = valor;

                //Agregamos un parametro de salida
                SqlParameter idAutor = new SqlParameter();
                idAutor.ParameterName = "@id";
                idAutor.SqlDbType = SqlDbType.Int;
                idAutor.Direction = ParameterDirection.Output;

                command.Parameters.Add(idAutor);
                //Abrimos la conexion y guardamos el resultado en respuesta
                sqlConnection.Open();

                command.ExecuteNonQuery();
                respuesta = Convert.ToInt32(idAutor.Value);

            }
            catch (Exception e)
            {
                throw e;
            }

            return respuesta;
        }

    }
}
