using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public class DB
    {
        MySqlConnection con = new MySqlConnection("server=localost;port=3306;username=root;password=root;datebase=recipe");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return con;
        }
    }
}
