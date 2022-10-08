namespace DataLayer.Entities
{
    public class Entrepreneur : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Money { get; set; }
        public decimal Investments { get; set; }
    }
}
