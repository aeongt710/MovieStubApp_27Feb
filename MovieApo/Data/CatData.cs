using MovieApp.CatUtils;
using MovieApp.Data.DataHandler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class CatData
    {
        public List<Category> CatSelectAll()
        {
            List<Category> movies = new List<Category>();
            SqlConnection con = new SqlConnection(Connections.ConnectionString());
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM [Categories]";

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    movies.Add(new Category(
                        (int)reader["CategoryId"],
                        (string)reader["Description"]));
                }
            }
            return movies;
        }
    }
}
