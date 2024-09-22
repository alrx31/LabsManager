using LabsManager.Entities;

namespace LabsManager.DTO
{
    public class LoginTeacherResponse
    {
        public bool IsLoggedIn { get; set; }
        public Teacher Teacher { get; set; }
    }
}
