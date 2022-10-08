namespace DataLayer.Entities
{
    public class Student : People
    {
        public string StudentId { get; set; }
        public uint Course { get; set; }
        public DateTime Birthday { get; set; }
    }
}
