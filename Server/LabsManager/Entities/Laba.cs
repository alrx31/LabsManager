using System.ComponentModel.DataAnnotations;

namespace LabsManager.Entities
{
    public class Laba
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string materials { get; set; }

        public string FileName { get; set; }
        public byte[] file { get; set; }

        public int teacherId { get; set; }
        public Teacher teacher { get; set; }

        public DateTime LastTimeToPass { get; set; }
        

        public List<PassModel> passLabs { get; set; } = new List<PassModel>();
    }
}
