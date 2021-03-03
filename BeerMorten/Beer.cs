using System;

namespace BeerMorten
{
    public class Beer
    {
        private double _abv;
        private string _name;
        private int _price;

        public Beer(int id, double abv, string name, int price)
        {
            Id = id;
            Abv = abv;
            Name = name;
            Price = price;
        }

        public Beer()
        {
            
        }

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentException();
                _name = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentException();
                _price = value;
            }
        }

        public double Abv
        {
            get => _abv;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentOutOfRangeException();
                _abv = value;
            }
        }

        public override string ToString()
        {
            return $"Nr. {Id} Name {Name} abv is {Abv} with a price of {Price}";
        }
    }
}