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
    internal class Customer
    {
        /// <summary>
        /// id.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// имя. 
        /// </summary>
        private string _fullname;

        /// <summary>
        /// адрес.
        /// </summary>
        private string _address;

        /// <summary>
        /// возварщает id.
        /// </summary>
        public int Id { get { return _id; } }


        /// <summary>
        /// возвращает и задает имя.
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
        /// возвращает и задает адрес.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// создает экземпляр <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
        }


        /// <summary>
        /// создает экземпляр <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">имя товара</param>
        /// <param name="address">авдрес товара</param>
        public Customer(string fullname, string address)
        {
            FullName = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

        public override string ToString()
        {
            return $"{Id}: {FullName} - {Address}";
        }
    }
}
