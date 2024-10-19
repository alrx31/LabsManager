namespace LabsManager.Entities
{
    public class Student:PersonBase
    {
        public string group { get; set; }

        public List<PassModel> passModels { get; set; }
    }
}
