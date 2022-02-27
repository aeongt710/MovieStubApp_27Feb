using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.MovieUtils
{
    public class Movie
    {
        private string title;
        private string director;
        private int id;
        private int categoryID;


        public Movie(int id)
        {
            Id = id;
        }

        public Movie(int id, string title,  string director)
        {
            Id = id;
            Title = title;
            Director = director;
        }

        public Movie(int id, string title, string director,string cate)
        {
            Id = id;
            Title = title;
            Director = director;
            CategoryID= int.Parse(cate);
        }

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
    }
}



