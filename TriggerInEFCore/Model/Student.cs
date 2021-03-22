using EntityFrameworkCore.Triggers;
using System.ComponentModel.DataAnnotations.Schema;

namespace TriggerInEFCore.Model
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }

        static Student()
        {
            Triggers<Student>.Inserted += e =>
            {
                int a = 1;
            };
        }
    }
}
