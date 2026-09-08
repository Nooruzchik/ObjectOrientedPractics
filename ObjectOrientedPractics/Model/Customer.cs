using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;


        public string FullName
        {
            get {  return _fullname; }
            set
            {
                if (_fullname.Length > 200)
                    throw new ArgumentException("ФИО не должно превыышать 200 сим");
                _fullname = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (_address.Length > 500)
                    throw new ArgumentException("Адреес не должен превышать 500 сим");
                _address = value;
            }
        }

        public Customer(string _fullname, string _address)
        {
            FullName = _fullname;
            Address = _address;
        }
    }
}
