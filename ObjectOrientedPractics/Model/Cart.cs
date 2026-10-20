using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        private List<Item> _items = new List<Item>();

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }

        public double Amount
        {
            get
            {
                if (_items == null)
                {
                    return 0.0;
                }

                double total = 0.0;

                for (int i = 0; i < _items.Count; i++)
                {
                    total += _items[i].Cost;
                }

                return total;
            }
        }
    }
}
