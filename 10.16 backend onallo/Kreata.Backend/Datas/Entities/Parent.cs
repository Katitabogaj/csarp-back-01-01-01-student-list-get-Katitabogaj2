namespace Kreata.Backend.Datas.Entities
{
    public class Parent
    {
        public Parent()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            residency = string.Empty;
            
        }
        public Parent(string firstName, string lastName, DateTime birthsDay, string residency)
        {
            
            FirstName = firstName;
            LastName = lastName;
            
            
        }
        public Parent(Guid id, string firstName, string lastName, DateTime birthsDay, string residency)
        {
            
            FirstName = firstName;
            LastName = lastName;
            
            
            
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public string residency { get; set; }
        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
