using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    public enum DeliveryTime
    {
        /// <summary>
        /// 9:00 – 11:00
        /// </summary>
        NineToEleven,

        /// <summary>
        /// 11:00 – 13:00
        /// </summary>
        ElevenToThirteen,

        /// <summary>
        /// 13:00 – 15:00
        /// </summary>
        ThirteenToFifteen,

        /// <summary>
        /// 15:00 – 17:00
        /// </summary>
        FifteenToSeventeen,

        /// <summary>
        /// 17:00 – 19:00
        /// </summary>
        SeventeenToNineteen,

        /// <summary>
        /// 19:00 – 21:00
        /// </summary>
        NineteenToTwentyOne
    }

    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Желаемый интервал времени доставки.
        /// </summary>
        private DeliveryTime _deliveryTime;

        /// <summary>
        /// Возвращает и задаёт желаемую дату доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        /// <summary>
        /// Возвращает и задаёт желаемый интервал времени доставки.
        /// </summary>
        public DeliveryTime DeliveryTime
        {
            get { return _deliveryTime; }
            set { _deliveryTime = value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder(): base() {}


        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="items">Список товаров для заказа.</param>
        /// <param name="deliveryDate">Желаемая дата доставки.</param>
        /// <param name="deliveryTime">Желаемый интервал времени доставки.</param>
        public PriorityOrder(Address deliveryAddress, List<Item> items, DateTime deliveryDate, DeliveryTime deliveryTime) : base(deliveryAddress, items)
        {
            // _id, _creationDate, _status и _items уже инициализировал базовый класс Order

            _deliveryDate = deliveryDate;
            _deliveryTime = deliveryTime;
        }
    }
}
