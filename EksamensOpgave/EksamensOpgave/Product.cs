using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class Product
    {
        public Product()
        {

        }

        private int _id = IdCounter++;
        private string _name;
        private decimal _price;
        private bool _active;
        private bool _canBeBoughtOnCredit;

        private static int IdCounter = 1;

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Navnet må ikke være tomt eller null");
                _name = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }

        public bool Active
        {
            get { return _active; }
            set
            {
                _active = value;
            }
        }

        public bool CanBeBoughtOnCredit
        {
            get { return _canBeBoughtOnCredit; }
            set
            {
                _canBeBoughtOnCredit = value;
            }
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    }
}
