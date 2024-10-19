namespace LabsManager.DTO
{
    public class AddPassModelDTO
    {
        public int labId { get; set; }

        public int studentId { get; set; }

        public int teacherId { get;set; }

        public IFormFile report { get; set; }
    }
}
