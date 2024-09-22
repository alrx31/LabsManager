using System.ComponentModel.DataAnnotations;

namespace LabsManager.Entities
{
    public class PersonBase
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}
