using domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsManager.domain.DTO
{
    public class LoginStResponse
    {
        public bool isLoggedIn { get; set; }
        public Student student { get; set; }
    }

    public class LoginTeResponse
    {
        public bool isLoggedIn { get; set; }
        public Teacher teacher { get; set; }
    }
}
