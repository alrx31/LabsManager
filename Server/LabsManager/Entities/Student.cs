namespace LabsManager.Entities
{
    public class Student:PersonBase
    {
        public string Speciality { get; set;}
        public string Group { get; set; }

        public List<PassModel> passModels { get; set; }
    }
}
