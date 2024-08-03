using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.entities
{
    public class FollowStudentSubject
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public Student student { get; set; }
        public int subjectId { get; set; }
        public Subject subject { get; set; }
        public DateTime followDate { get; set; }
    }


}
