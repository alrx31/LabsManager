using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.entities
{
    public class PersonsBase
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string faculty { get; set; }

    }


    public class Student:PersonsBase
    {
        [Required]
        public int group { get; set; }
        

        public List<FollowStudentSubject> subjects { get; set; }
    }

    public class Teacher:PersonsBase
    {
        [Required]
        public string cafedra { get; set; }
        public bool isAdmin { get; set; }

        public List<Subject> subjects { get; set; }       
    }
}
