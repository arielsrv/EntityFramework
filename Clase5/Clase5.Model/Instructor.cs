using System.ComponentModel.DataAnnotations.Schema;

namespace Clase5.Model
{
    [Table("Instructors")]
    public class Instructor : Person
    {
        public double Salary { get; set; }
        public Course Course { get; set; }
    }
}