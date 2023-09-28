using JdbcConexionPostgresql.Dtos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdbcConexionPostgresql.Servicios
{
    /// <summary>
    /// Interfaz que define las consultas a postgresql
    /// 270923-rfg
    /// </summary>
    internal interface ConsultasPostgresqlInterfaz
    {
        /// <summary>
        /// Métdo que lee todos los registros de la bas ede datos de Postgresql
        /// </summary>
        /// <param name="conexion"></param>
        /// <returns></returns>
        public List<LibroDto> seccionarTodosLibros(NpgsqlConnection conexion);

    }
}
