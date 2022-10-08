namespace DataLayer.Entities
{
    public class Student : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public uint Course { get; set; }
        public DateTime Birthday { get; set; }
    }
}
