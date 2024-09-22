namespace LabsManager.DTO
{
    public class RegisterTeacherDTO
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string Cafedra { get; set; }
        public bool IsAdmin { get; set; }
    }
}
