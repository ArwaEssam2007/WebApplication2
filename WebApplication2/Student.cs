using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Grad { get; set; }
        List<Subject> Subjects { get; set; }
    }
}
