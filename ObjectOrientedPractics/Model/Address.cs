using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе доставки.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс. Шестизначное число.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна или регион. Не более 50 символов.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населённый пункт). Не более 50 символов.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица. Не более 100 символов.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома. Не более 10 символов.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры или помещения. Не более 10 символов.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс. Шестизначное число.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentException(
                        "Index должен быть шестизначным числом (от 100000 до 999999).");
                }
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну или регион. Не более 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт город (населённый пункт). Не более 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома. Не более 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры или помещения. Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/> с пустыми значениями.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Шестизначное число.</param>
        /// <param name="country">Страна или регион. Не более 50 символов.</param>
        /// <param name="city">Город (населённый пункт). Не более 50 символов.</param>
        /// <param name="street">Улица. Не более 100 символов.</param>
        /// <param name="building">Номер дома. Не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры или помещения. Не более 10 символов.</param>
        public Address(int index, string country, string city,
                       string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
