using MovieApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.MovieUtils
{
    public class MovieUtilities
    {
        public static List<Movie> SelectAll()
        {

            MovieData md = new MovieData();
            return md.MovieSelectAll();
        }

        public static List<Movie> SelectAll(string id)
        {

            MovieData md = new MovieData();
            return md.Filter(id);
        }

        public void Update(int id, string title, string director)
        {

            Movie MovieToUpdate = new Movie(id, title, director);
            MovieData md = new MovieData();
            md.MovieUpdate(MovieToUpdate);
        }
        public void Update(int id, string title, string director,string categoryID)
        {

            Movie MovieToUpdate = new Movie(id, title, director, categoryID);
            MovieData md = new MovieData();
            md.MovieUpdate(MovieToUpdate);
        }

        public void Insert(int id, string title, string director)
        {

            Movie MovieToInsert = new Movie(id, title, director);
            MovieData md = new MovieData();
            md.MovieInsert(MovieToInsert);
        }
        public void Delete(int id)
        {

            Movie MovieToDelete = new Movie(id);
            MovieData md = new MovieData();
            md.MovieDelete(MovieToDelete);
        }

    }
}
