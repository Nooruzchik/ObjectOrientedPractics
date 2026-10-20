using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах и покупателях.
    /// Является единой точкой доступа ко всем пользовательским данным приложения.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private BindingList<Customer> _customers = new BindingList<Customer>();

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Store"/>.
        /// Оба списка инициализируются пустыми коллекциями.
        /// </summary>
        public Store()
        {
            _items = new BindingList<Item>();
            _customers = new BindingList<Customer>();
        }
    }
}
