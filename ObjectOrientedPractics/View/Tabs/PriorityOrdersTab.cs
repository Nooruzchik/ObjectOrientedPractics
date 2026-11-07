using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _priorityOrder;
        public PriorityOrdersTab()
        {
            InitializeComponent();

            // 1. СНАЧАЛА создаем объект заказа
            _priorityOrder = new PriorityOrder(new Address(), new List<Item>(), DateTime.Now.AddDays(1), DeliveryTime.NineToEleven);
            // 2. ТЕПЕРЬ инициализируем ComboBox. 
            // Событие выстрелит, но _priorityOrder уже не null, поэтому ошибки не будет.
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DeliveryTimeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTime));

            // 3. Обновляем интерфейс
            UpdateOrderInfo();
        }

        /// <summary>
        /// Метод для обновления отображения данных о заказе на форме.
        /// </summary>
        private void UpdateOrderInfo()
        {
            // Поля Id и Created только для чтения
            IdTextBox.Text = _priorityOrder.Id.ToString();
            CreatedTextBox.Text = _priorityOrder.CreationDate.ToString();

            // Устанавливаем выбранные значения в ComboBox
            StatusComboBox.SelectedItem = _priorityOrder.Status;
            DeliveryTimeComboBox.SelectedItem = _priorityOrder.DeliveryTime;

            // Отображаем адрес
            AddressControl1.Address = _priorityOrder.DeliveryAddress;

            // Заполняем ListBox товарами с помощью цикла for
            OrderItemsListBox.Items.Clear();
            for (int i = 0; i < _priorityOrder.Items.Count; i++)
            {
                // Обращаемся к элементу списка по индексу [i]
                OrderItemsListBox.Items.Add(_priorityOrder.Items[i].Name);
            }

            // Обновляем сумму
            PriceLabel.Text = _priorityOrder.TotalCost.ToString("C2");
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Добавляем проверку: если _priorityOrder еще не создан, просто выходим из метода
            if (_priorityOrder == null) return;

            // Проверяем, что выбранный элемент - это действительно OrderStatus
            if (StatusComboBox.SelectedItem is OrderStatus selectedStatus)
            {
                _priorityOrder.Status = selectedStatus; // Сохраняем в объект
            }
        }

        // Событие: Пользователь выбрал новое время доставки в ComboBox
        private void deliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_priorityOrder == null) return;

            if (DeliveryTimeComboBox.SelectedItem is DeliveryTime selectedTime)
            {
                _priorityOrder.DeliveryTime = selectedTime; // Сохраняем в объект
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            double cost = random.Next(100, 10000);

            Array categories = Enum.GetValues(typeof(Category));

            Category randomCategory = (Category)categories.GetValue(random.Next(categories.Length));

            Item newItem = new Item("Случайный товар", "Описание случайного товара", cost, randomCategory);

            _priorityOrder.Items.Add(newItem);

            UpdateOrderInfo();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли какой-то элемент в ListBox
            if (OrderItemsListBox.SelectedIndex != -1)
            {
                // Запоминаем индекс удаляемого элемента
                int selectedIndex = OrderItemsListBox.SelectedIndex;

                // Удаляем товар из списка заказа по этому индексу
                _priorityOrder.Items.RemoveAt(selectedIndex);

                // Обновляем интерфейс (перезаполняем ListBox и сумму)
                UpdateOrderInfo();

                // Теперь нужно правильно выставить выделение на следующий элемент
                // Если мы удалили последний элемент, индекс выйдет за границы, 
                // поэтому мы проверяем количество оставшихся элементов.
                if (OrderItemsListBox.Items.Count > 0)
                {
                    // Если удалили не последний, selectedIndex теперь указывает на следующий элемент.
                    // Если удалили последний, selectedIndex будет равен Count, поэтому берем Count - 1.
                    if (selectedIndex < OrderItemsListBox.Items.Count)
                    {
                        OrderItemsListBox.SelectedIndex = selectedIndex;
                    }
                    else
                    {
                        OrderItemsListBox.SelectedIndex = OrderItemsListBox.Items.Count - 1;
                    }
                }
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _priorityOrder = new PriorityOrder(
                new Address(),
                new List<Item>(),
                DateTime.Now.AddDays(1),
                DeliveryTime.NineToEleven
            );

            UpdateOrderInfo();
        }
    }
}
