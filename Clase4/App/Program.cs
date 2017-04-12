using Model;
using System;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindDb db = new NorthwindDb())
            {
                var category = new Category
                {
                    CategoryName = "Chinese Food",
                    Description = "Food from china city",
                };

                db.Categories.Add(category);
                db.SaveChanges();                
            }
        }
    }
}
