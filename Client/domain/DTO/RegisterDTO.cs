using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.domain.DTO
{
    public class RegisterDTOBase
    {
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }

    public class RegisterStudentDTO: RegisterDTOBase
    {
        
        public string group { get; set; }
    }

    public class RegisterTeacherDTO: RegisterDTOBase
    {
        public string cafedra { get; set; }
    }
}
