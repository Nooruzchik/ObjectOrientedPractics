using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _creationDate;

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        private Address _deliveryAddress;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreationDate
        {
            get { return _creationDate; }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки заказа.
        /// </summary>
        public Address DeliveryAddress
        {
            get { return _deliveryAddress; }
            set { _deliveryAddress = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задаёт статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возвращает общую стоимость всех товаров в заказе.
        /// </summary>
        public double TotalCost
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="items">Список товаров для заказа.</param>
        public Order(Address deliveryAddress, List<Item> items)
        {
            _id = IdGenerator.GetNextId();
            _creationDate = DateTime.Now;
            _deliveryAddress = deliveryAddress;
            _status = OrderStatus.New;

            // Инициализируем список, чтобы избежать NullReferenceException
            _items = new List<Item>();

            if (items != null)
            {
                // Используем AddRange для более лаконичного добавления
                _items.AddRange(items);
            }
        }
    }
}
