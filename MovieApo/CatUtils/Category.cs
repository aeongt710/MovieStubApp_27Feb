using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.CatUtils
{
    public class Category
    {
            private int categoryID;
            private string description;



            public Category(int categoryID, string description)
            {
                CategoryID = categoryID;
                Description = description;
            }
            public int CategoryID
            {
                get { return categoryID; }
                set { categoryID = value; }
            }
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
       
    }
}
