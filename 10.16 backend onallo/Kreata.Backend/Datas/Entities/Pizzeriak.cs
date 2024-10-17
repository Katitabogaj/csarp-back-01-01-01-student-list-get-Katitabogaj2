namespace Kreata.Backend.Datas.Entities
{
    public class Pizzeriak
    {
        public Pizzeriak()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
            address = string.Empty;

        }
        public Pizzeriak(string name, string address)
        {

            Name = name;


        }
        public Pizzeriak(Guid id, string name, string address)
        {

            Name = name;
            



        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
