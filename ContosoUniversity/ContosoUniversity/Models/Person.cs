namespace ContosoUniversity.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}