namespace LabsManager.Entities
{
    public class Teacher:PersonBase
    {
        public string Cafedra { get; set; }
        public bool IsAdmin { get; set; }

        public List<Laba> Labs { get; set; }
        public List<PassModel> passModels { get; set; }
    }
}
