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
        public int id { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }

    }


    public class Student:PersonsBase
    {
        public string group { get; set; }

        public List<FollowStudentSubject> subjects { get; set; }
    }

    public class Teacher:PersonsBase
    {
        public string cafedra { get; set; }
        public bool isAdmin { get; set; }

        public List<Subject> subjects { get; set; }       
    }
}
