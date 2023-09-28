using JdbcConexionPostgresql.Dtos;
using JdbcConexionPostgresql.Servicios;
using Npgsql;

namespace JdbcConexionPostgresql
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 270923-rfg
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método main de la aplicación, puerta de entrada
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ConexionPostgresqlInterfaz conexionPostgresqlInterfaz = new ConexionPostgresqlImplementacion();
            ConsultasPostgresqlInterfaz consultasPostgresqlInterfaz = new ConsultasPostgresqlImplementacion();
            NpgsqlConnection conexion = null;
            conexion = conexionPostgresqlInterfaz.generarConexionPostgresql();

            if (conexion != null)
            {
               foreach(LibroDto libro in consultasPostgresqlInterfaz.seccionarTodosLibros(conexion))
                {
                    Console.WriteLine(libro.Titulo);
                }
               
            }

        }
    }
}