using LabsManager.Entities;

namespace LabsManager.DTO
{
    public class LoginStudentResponse
    {
        public bool IsLoggedIn { get; set; }
        public Student Student { get; set; }
    }
}
