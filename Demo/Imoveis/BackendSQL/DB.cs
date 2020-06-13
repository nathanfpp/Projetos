using System;
using System.Data.SqlClient;

namespace BackendSQL
{
    public class DB
    {
        public SqlConnection oSqlConnection;
        public SqlCommand oSqlCommand;


        public DB()
        {
            oSqlConnection = new SqlConnection(@"Data Source=(localDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Nathan Frois\Documents\ASP.NET\Demo\Imoveis\BackendSQL\BancoDeDados.mdf; Integrated Security=True; Connect Timeout=10");
            oSqlCommand = new SqlCommand();
            oSqlCommand.Connection = oSqlConnection;
        }

        public void Gravar(string oComando)
        {
            oSqlConnection.Open();
            oSqlCommand.CommandText = oComando;
            oSqlCommand.ExecuteNonQuery();
            oSqlConnection.Close();
        }
    }
}
