using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bida.DAO
{
    class DataProvider
    {
        public const string onStr = "Data Source = DESKTOP-8H4958A;Initial Catalog = Bida;Integrated Security = SSPI";
        SqlConnection conn;
        private SqlCommand command;

        public DataProvider()
        {
            conn = new SqlConnection(onStr);
        }

        public void Connect()
        {
            conn.Open();
        }

        public void Disconnect()
        {
            conn.Close();
        }

        public SqlDataReader ExcuteReader(String sql)
        {
            command = new SqlCommand(sql, conn);
            return command.ExecuteReader();
        }
        public void executeNonQuery(string sql)
        {
            this.command = new SqlCommand(sql, conn);
             this.command.ExecuteNonQuery();
        }
        


    }
}
