using System;

namespace BeerMorten
{
    public class Beer
    {
        private int _id;
        private string _name;
        private int _price;
        private int _abv;

        public int Id
        {
            get => _id;
            set { _id = value; }
        }

        public string Name
        {
            get => _name;
            set { _name = value; }
        }

        public int Price
        {
            get => _price;
            set { _price = value; }
        }

        public int Abv
        {
            get => _abv;
            set { _abv = value; }
        }
    }
}
