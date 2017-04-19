using Clase5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UniversityDb db = new UniversityDb())
            {
                Student student = new Student
                {
                    FirstName = "Jorge",
                    LastName = "Sanchez",
                    Fee = 5000.0
                };

                //db.People.Add(student);
                //db.SaveChanges();

                Console.WriteLine(student.Id);
            };

        }
    }
}
