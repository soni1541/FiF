using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FuF
{
    class Database_Query
    {
        private string connection_string;
        private SqlConnection connection;

        public Database_Query()
        {
            connection_string = @"Data Source=.\SQLEXPRESS; Initial Catalog=game; Integrated Security=True";
            connection = new SqlConnection(connection_string);
        }

        public int get_count_nuts(int id)
        {
            string SqlExpression = "SELECT nuts" +
                " FROM users" +
                " WHERE user_id = @iu";
            connection.Open();
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            SqlParameter iu_param = new SqlParameter("@iu", id);
            command.Parameters.Add(iu_param);
            var dt = command.ExecuteReader();
            dt.Read();
            int count_nuts = Convert.ToInt32(dt.GetValue(0).ToString());
            connection.Close();
            return count_nuts;
        }

        public int get_level(int id)
        {
            string SqlExpression = "SELECT level" +
                " FROM users" +
                " WHERE user_id = @iu";
            connection.Open();
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            SqlParameter iu_param = new SqlParameter("@iu", id);
            command.Parameters.Add(iu_param);
            var dt = command.ExecuteReader();
            dt.Read();
            int level = Convert.ToInt32(dt.GetValue(0).ToString());
            connection.Close();
            return level;
        }

        public int update_count_nuts(int id, int count_append)
        {
            string SqlExpression = "UPDATE users" +
                " SET nuts = nuts + @ca" +
                " WHERE user_id = @iu";

            connection.Open();
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            SqlParameter ca_param = new SqlParameter("@ca", count_append);
            SqlParameter iu_param = new SqlParameter("@iu", id);
            command.Parameters.Add(ca_param);
            command.Parameters.Add(iu_param);
            int count_update = command.ExecuteNonQuery();
            connection.Close();

            return count_update;
        }

        public int update_level(int id)
        {
            string SqlExpression = "UPDATE users" +
                " SET level = level + 1" +
                " WHERE user_id = @iu";

            connection.Open();
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            SqlParameter iu_param = new SqlParameter("@iu", id);
            command.Parameters.Add(iu_param);
            int count_update = command.ExecuteNonQuery();
            connection.Close();

            return count_update;
        }
    }
}
