using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string FullName
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает или задает корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/> с параметрами по умолчанию.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            _cart = new Cart();
        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/> с заданными параметрами.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя</param>
        /// <param name="address">Адрес покупателя</param>
        public Customer(string fullname, Address address)
        {
            FullName = fullname;
            Address = address;
            _cart = new Cart();
            _id = IdGenerator.GetNextId();
        }

        public override string ToString()
        {
            return $"{Id}: {FullName} - {Address}";
        }
    }
}
