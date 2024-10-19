namespace LabsManager.Entities
{
    public class Teacher:PersonBase
    {
        public string cafedra { get; set; }
        public bool isAdmin { get; set; }

        public List<Laba> labs { get; set; }
        public List<PassModel> passModels { get; set; }
    }
}
