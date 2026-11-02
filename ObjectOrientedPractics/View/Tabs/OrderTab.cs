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
    public partial class OrderTab : UserControl
    {
        /// <summary>
        /// Список всех покупателей
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Общий список всех заказов (для удобства поиска)
        /// </summary>
        private List<Order> _allOrders = new List<Order>();

        /// <summary>
        /// Текущий выбранный заказ
        /// </summary>
        private Order _currentOrder;

        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateOrders();
            }
        }

        public OrderTab()
        {
            InitializeComponent();

            // Инициализация ComboBox статусами
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            // Блокировка редактирования таблицы
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Запрет сортировки по клику (чтобы индексы не путались)
            foreach (DataGridViewColumn column in OrdersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void UpdateOrders()
        {
            OrdersDataGridView.Rows.Clear();
            _allOrders.Clear();

            if (_customers == null)
            {
                return;
            }

            for (int i = 0; i < _customers.Count; i++)
            {
                // заказы текущего покупателя
                List<Order> customerOrders = _customers[i].Orders;

                for (int j = 0; j < customerOrders.Count; j++)
                {
                    Order order = customerOrders[j];

                    // Собираем адрес в одну строку для таблицы
                    string addressStr = $"{order.DeliveryAddress.Country}, {order.DeliveryAddress.City}, " +
                                       $"{order.DeliveryAddress.Street}, {order.DeliveryAddress.Building}";

                    _allOrders.Add(order);

                    // Добавляем строку в DataGridView (индексы столбцов: 0-Id, 1-Дата, 2-ФИО, 3-Адрес, 4-Цена, 5-Статус)
                    OrdersDataGridView.Rows.Add(order.Id, order.CreationDate.ToString("g"),
                        _customers[i].FullName, addressStr, order.TotalCost.ToString("C2"), order.Status);
                }
            }
        }

        private void ClearOrderInfo()
        {
            _currentOrder = null;
            IdTextBox.Clear();
            CreatedTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;
            addressControl1.Address = new Address();
            OrderItemsListBox.DataSource = null;
            PriceLabel.Text = "0,00";
        }

        public void RefreshData()
        {
            UpdateOrders();
            if (OrdersDataGridView.Rows.Count == 0)
            {
                ClearOrderInfo();
            }
        }

        /// <summary>
        /// Срабатывает при клике на строку в таблице.
        /// </summary>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count == 0)
            {
                ClearOrderInfo();
                return;
            }

            int rowIndex = OrdersDataGridView.SelectedRows[0].Index;

            if (rowIndex < 0 || rowIndex >= _allOrders.Count)
            {
                ClearOrderInfo();
                return;
            }

            _currentOrder = _allOrders[rowIndex];

            // Заполняем правую панель
            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.CreationDate.ToString("g");
            StatusComboBox.SelectedItem = _currentOrder.Status;
            addressControl1.Address = _currentOrder.DeliveryAddress;

            OrderItemsListBox.DataSource = null;
            OrderItemsListBox.DataSource = _currentOrder.Items;
            OrderItemsListBox.DisplayMember = nameof(Item.Name);

            PriceLabel.Text = _currentOrder.TotalCost.ToString("C2");
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder == null || StatusComboBox.SelectedItem == null)
            {
                return;
            }

            _currentOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;

            if (OrdersDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = OrdersDataGridView.SelectedRows[0].Index;
                OrdersDataGridView.Rows[rowIndex].Cells[5].Value = _currentOrder.Status;
            }
        }
    }
}
