using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase5.Model
{
    [Table("Students")]
    public class Student : Person
    {
        public double Fee { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}