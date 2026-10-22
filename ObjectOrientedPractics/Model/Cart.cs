using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит список товаров, выбранных покупателем для оформления заказа.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает и задаёт список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает общую стоимость всех товаров в корзине.
        /// Если список пуст или равен null, возвращает 0.0.
        /// </summary>
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
