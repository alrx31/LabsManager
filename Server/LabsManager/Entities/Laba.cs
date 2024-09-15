using System.ComponentModel.DataAnnotations;

namespace LabsManager.Entities
{
    public class Laba
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Materials { get; set; }

        public List<PassModel> passModels { get; set; }
        
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
