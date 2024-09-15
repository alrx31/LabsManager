namespace LabsManager.Entities
{
    public class PassModel
    {
        public int Id { get; set; }
        
        public int LabaId { get; set; }
        public Laba Laba { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public float? Mark { get; set; }
        public bool IsChecked { get; set; } = false;

        public bool IsPassed { get; set; } = false;
    }
}
