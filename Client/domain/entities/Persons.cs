using System.Collections;

namespace domain.entities
{
    public class PersonsBase
    {
        public int id { get; set; }
        public string name { get; set; }

        public string login { get; set; }
        public string password { get; set; }

    }


    public class Student:PersonsBase
    {
        public string group { get; set; }

        public List<PassLabModel> passLabs { get; set; } = new List<PassLabModel>();
    }

    public class Teacher:PersonsBase
    {
        public string cafedra { get; set; }
        public bool isAdmin { get; set; }

        public List<Lab> labs { get; set; }
        public List<PassLabModel> passLabs { get; set; } = new List<PassLabModel>();

    }
}
