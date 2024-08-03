using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.entities
{
    public class Subject
    {
        public int id { get; set; }
        public string name{ get; set; }
        public string description { get; set; }
        public int needHours { get; set; }
        public int authorId { get; set; }
        public Teacher author { get; set; }

        public List<FollowStudentSubject> followStudentSubjects { get; set; }
        

        public List<Lab> labs { get; set; }
        

    }
}
