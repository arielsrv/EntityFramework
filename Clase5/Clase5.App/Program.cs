using Clase5.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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
                //Student student = new Student
                //{
                //    FirstName = "Cecilia",
                //    LastName = "Fernandez",
                //    Fee = 5000.0
                //};

                //db.People.Add(student);
                //db.SaveChanges();

                var result = db.People.OfType<Student>();

                foreach (var item in result)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.FirstName);
                    Console.WriteLine(item.LastName);
                }

                DbParameter parameter = new SqlParameter("@Id", 1);
                var student =  db
                    .Database
                    .SqlQuery<Student>("GetStudents @Id", parameter);

                Console.WriteLine("Resultado SP: ");

                foreach (var item in student)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.FirstName);
                    Console.WriteLine(item.LastName);
                }
            };

        }
    }
}
