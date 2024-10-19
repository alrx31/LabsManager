using System.Diagnostics.Eventing.Reader;

namespace domain.entities
{
    public class Lab
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string materials { get; set; }

        public byte[] file { get; set; }

        public int teacherId { get; set; }
        public Teacher Teacher { get; set; }

        public DateTime lastTimeToPass { get; set; }

        public List<PassLabModel> passLabs { get; set; } = new List<PassLabModel>();
    }


    public class PassLabModel {
        public int id { get; set; }

        public int LabId { get; set; }
        public Lab lab { get; set; }

        public int StudentId { get; set; }
        public Student student { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        public string comment { get; set; }
        public bool isChecked { get; set; } = false;
        public bool isPassed { get; set; } = false;

        public float mark { get; set; }

        public byte[] report { get; set; }
    }

    public class LabResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string materials { get; set; }
        public string FileBase64 { get; set; }
        public int teacherId { get; set; }
        public string fileExtension { get; set; }
    }
}
