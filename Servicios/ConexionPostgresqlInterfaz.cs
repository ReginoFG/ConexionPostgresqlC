﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdbcConexionPostgresql.Servicios
{
    /// <summary>
    /// Interfaz que define los métodos para generar conexiones a base de datos
    /// 270923-rfg
    /// </summary>
    internal interface ConexionPostgresqlInterfaz
    {
        /// <summary>
        /// Método que genera la conexión a postgresql
        /// </summary>
        /// <returns></returns>
        public NpgsqlConnection generarConexionPostgresql();
    
    }
}
