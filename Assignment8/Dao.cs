using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Dao
    {
        SqlConnection sc;
    public SqlConnection connect()
        {
        string str = @"Data Source = ;Initial Catalog =  ;Securety = ture";
        sc = new SqlConnection(str);
        sc.Open();
        return sc;
    
     }
        
    public SqlCommand command(string sql)
    {
        SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
    }
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();
        }
    }
}
