namespace LabsManager.Entities
{
    public class PassModel
    {
        public int id { get; set; }

        public int labId { get; set; }
        public Laba lab { get; set; }

        public int studentId { get; set; }
        public Student student { get; set; }

        public int teacherId { get; set; }
        public Teacher teacher { get; set; }


        public string comment { get; set; }
        public bool isChecked { get; set; } = false;
        public bool isPassed { get; set; } = false;

        public float mark { get; set; }


        public byte[] report { get; set; }
    }
}
