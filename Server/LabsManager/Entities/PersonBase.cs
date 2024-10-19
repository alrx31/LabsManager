using System.ComponentModel.DataAnnotations;

namespace LabsManager.Entities
{
    public class PersonBase
    {
        [Key]
        public int id { get; set; }
        
        public string name { get; set; }

        public string login { get; set; }
        public string password { get; set; }
    }
}
