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
                var category = db.Categories
                    .Where(x => x.CategoryName.Contains("Chinese"))
                    .First();

                category.CategoryName = "Chinese ONly";
                
                db.SaveChanges();                
            }
        }
    }
}
