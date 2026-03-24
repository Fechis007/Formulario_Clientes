using Npgsql;

namespace Formulario_Clientes
{
    internal class Conexion
    {
        private static string cadena =
        "Host=localhost;Port=5432;Username=postgres;Password=GatitoSV;Database=Formulario;";

        public static NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection con = new NpgsqlConnection(cadena);
            con.Open();
            return con;
        }
    }
}

    //private static string cadena =
    // "Server=localhost\\SQLEXPRESS;Database=FORMULARIO;Integrated Security=True;TrustServerCertificate=True;";

    //public static SqlConnection ObtenerConexion()
    //{
    //    SqlConnection con = new SqlConnection(cadena);
    //    con.Open();
    //    return con;
    //}
