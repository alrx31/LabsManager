using LabsManager.Entities;

namespace LabsManager.DTO
{
    public class AddLabDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Materials { get; set; }

        public int TeacherId { get; set; }

        public DateTime LastTimeToPass { get; set; }

        public IFormFile File { get; set; }
    }
}
