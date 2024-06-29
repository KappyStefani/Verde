using MySql.Data.MySqlClient;
using System;

namespace Verde
{
    static class Conn
    {
        static private string servidor = "localhost";
        static private string bancoDados = "teste";
        static private string usuario = "root";

        static public string strConn = $"server={servidor};User Id={usuario};database={bancoDados}";
    }
}