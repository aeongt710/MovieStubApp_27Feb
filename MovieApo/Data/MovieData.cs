using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Data.DataHandler;
using System.Data.SqlClient;
using MovieApp.MovieUtils;
using System.Data;

namespace MovieApp.Data
{
    public class MovieData
    {
        public List<Movie> MovieSelectAll()
        {
            List<Movie> movies = new List<Movie>();
            SqlConnection con = new
            SqlConnection(Connections.ConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT ID, Title, Director,CategoryID FROM Movies";// WHERE ([CategoryID] = @CategoryID)
            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    movies.Add(new Movie(
                        (int)reader["Id"],
                        (string)reader["Title"],
                        (string)reader["Director"],
                        (string)reader["CategoryID"]
                        ));
                }
            }
            return movies;
        }

        public List<Movie> Filter(string id)
        {
            List<Movie> movies = new List<Movie>();
            SqlConnection con = new
            SqlConnection(Connections.ConnectionString());
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = con;
            if (id != null)
            {
                cmd.CommandText = "SELECT ID, Title, Director,CategoryID FROM Movies WHERE ([CategoryID] = @id)";
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            }
                
            else
                cmd.CommandText = "SELECT ID, Title, Director,CategoryID FROM Movies";// WHERE ([CategoryID] = @CategoryID)
            
            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    movies.Add(new Movie(
                        (int)reader["Id"],
                        (string)reader["Title"],
                        (string)reader["Director"],
                        (string)reader["CategoryID"]
                        ));
                }
            }
            return movies;
        }

        public void MovieUpdate(Movie MovieToUpdate)
        {
            SqlConnection con = new
            SqlConnection(Connections.ConnectionString());
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "UPDATE Movies SET Title=@Title,Director=@Director WHERE Id=@Id";

            cmd.Parameters.AddWithValue("@Title", MovieToUpdate.Title);
            cmd.Parameters.AddWithValue("@Director", MovieToUpdate.Director);
            cmd.Parameters.AddWithValue("@Id", MovieToUpdate.Id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void MovieInsert(Movie MovieToInsert)
        {
            SqlConnection con = new
            SqlConnection(Connections.ConnectionString());
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Movies(Title, Director) VALUES (@Title, @Director)";

            cmd.Parameters.AddWithValue("@Title", MovieToInsert.Title);
            cmd.Parameters.AddWithValue("@Director", MovieToInsert.Director);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void MovieDelete(Movie MovieToDelete)
        {
            SqlConnection con = new
            SqlConnection(Connections.ConnectionString());
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Movies WHERE (Id = @ID)";

            cmd.Parameters.AddWithValue("@Id", MovieToDelete.Id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
