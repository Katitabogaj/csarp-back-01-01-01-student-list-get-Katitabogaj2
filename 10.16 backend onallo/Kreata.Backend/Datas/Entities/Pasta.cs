using System.Numerics;

namespace Kreata.Backend.Datas.Entities
{
    public class Pasta
    {
        public Pasta()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
            Kalories = 0 ;
            Price = 0;
        }
        public Pasta(string name, int kalories, int price)
        {
            Name = name;
        }
        public Pasta(Guid id, string name, int kalories, int price)
        {
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Kalories { get; set; }
        public int Price { get; set; }
        public override string ToString() 
        {
            return $"{Name}";
        }
    }
}
