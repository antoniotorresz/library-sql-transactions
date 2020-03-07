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
        public string ExecuteSqlTransaction(Libro libro, List<int> idAutores, List<string> pags)
        {
            int idGenerado;
            string result = null;
            using (SqlConnection connection = new SqlConnection("Server=ANTONIO-TORRES\\SQLEXPRESS; Database=Biblioteca;Integrated Security = SSPI"))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "insert into Libro(titulo, editorial, fechaPublicacion, pais, isbn, imageUrl)" +
                        " OUTPUT INSERTED.idLibro" +
                        " values(@titulo, @editorial, @fechaPublicacion, @pais, @isbn, @imageUrl)";
                    command.Parameters.Add("@titulo", SqlDbType.VarChar).Value = libro.titulo;
                    command.Parameters.Add("@editorial", SqlDbType.VarChar).Value = libro.editorial;
                    command.Parameters.Add("@fechaPublicacion", SqlDbType.Date).Value = libro.fechaPublicacion;
                    command.Parameters.Add("@pais", SqlDbType.VarChar).Value = libro.pais;
                    command.Parameters.Add("@isbn", SqlDbType.VarChar).Value = libro.isbn;
                    command.Parameters.Add("@imageUrl", SqlDbType.VarChar).Value = libro.imageUrl;


                    idGenerado = Convert.ToInt32(command.ExecuteScalar());

                    for (int i = 0; i < idAutores.Count; i++)
                    {
                        command.Parameters.Clear();
                        command.CommandText = "insert into libroAutor(idLibro, idAutor, numPaginas)" +
                            " values (@idLib, @idAut, @npags)";
                        command.Parameters.AddWithValue("@idLib", idGenerado);
                        command.Parameters.AddWithValue("@idAut", idAutores[i]);
                        command.Parameters.AddWithValue("@npags", Convert.ToInt32(pags[i]));

                        command.ExecuteNonQuery();
                    }

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    result = libro.titulo + " agregado a la base de datos.";
                }
                catch (Exception ex)
                {
                    result = ex.ToString();
                    Console.WriteLine("NO COMMIT EXCEP:" + result);
                    
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
            return result;
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
