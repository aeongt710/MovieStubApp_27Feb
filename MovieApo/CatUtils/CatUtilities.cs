using MovieApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.CatUtils
{
    public class CatUtilities
    {
        public static List<Category> SelectAll()
            {
                CatData md = new CatData();
                return md.CatSelectAll();
            }
        }
}
