using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {

        private readonly int _id;
        private string _name; 
        private string _info;
        private double _cost;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name.Length < 1 || _name.Length > 200)
                {
                    throw new ArgumentException("Длина имени должна быть от 1 до 200 символов");
                }
                _name = value;
            }
        }

        public string Info
        {
            get { return _info; }
            set
            {
                if (_name.Length > 1000)
                {
                    throw new ArgumentException("Длинна описание товара может быть не больше 1000 символов"); 
                }
                _info = value;
            }
        }

        public double Cost
        {
            get { return _cost; }
            set
            {
                if (_cost < 0 || _cost > 100000)
                {
                    throw new ArgumentException("Цена товара может быть от 0 до 100000");
                }
                _cost = value;
            }
        }

        public Item(string _name,  string _info, double _cost)
        {
            Name = _name;
            Info = _info;
            Cost = _cost;
        }
    }
}
