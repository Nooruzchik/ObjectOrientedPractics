using ObjectOrientedPractics.Services;

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
        /// <summary>
        /// id.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// информация.
        /// </summary>
        private string _info;

        /// <summary>
        /// стоимость.
        /// </summary>
        private double _cost;

        /// <summary>
        /// возвращает id.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// возвращает и задает имя.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// возвращает и задает информацию.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }


        /// <summary>
        /// возвращает и задает стоимость.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Цена товара может быть от 0 до 100000");
                }

                _cost = value;
            }
        }


        /// <summary>
        /// сохдает экземпляр <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// создает экемпляр <see cref="Item"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="info"></param>
        /// <param name="cost"></param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
        }

        public override string ToString()
        {
            return $"{Id}: {Name} - {Cost}руб";
        }
    }
}
