using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список всех доступных товаров.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Список всех покупателей.
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задаёт список товаров, отображаемых на вкладке.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                if (_items != null)
                {
                    ItemsListBox.DataSource = _items;
                    ItemsListBox.DisplayMember = nameof(Item.Name);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей, отображаемых на вкладке.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                if (_customers != null)
                {
                    // Сохраняем текущего выбранного пользователя, чтобы не сбросить выбор
                    var selectedCustomer = CustomersComboBox.SelectedItem;

                    CustomersComboBox.DataSource = null;
                    CustomersComboBox.DataSource = _customers;
                    CustomersComboBox.DisplayMember = nameof(Customer.FullName);

                    // Восстанавливаем выбор, если он был
                    if (selectedCustomer != null && _customers.Contains(selectedCustomer))
                    {
                        CustomersComboBox.SelectedItem = selectedCustomer;
                    }
                }
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            if (_items != null)
            {
                ItemsListBox.DataSource = null;
                ItemsListBox.DataSource = _items;
                ItemsListBox.DisplayMember = nameof(Item.Name);
            }

            if (_customers != null)
            {
                var selectedCustomer = CustomersComboBox.SelectedItem;
                CustomersComboBox.DataSource = null;
                CustomersComboBox.DataSource = _customers;
                CustomersComboBox.DisplayMember = nameof(Customer.FullName);

                if (selectedCustomer != null && _customers.Contains(selectedCustomer))
                {
                    CustomersComboBox.SelectedItem = selectedCustomer;
                }
                else
                {
                    // Если покупателя нет, очищаем корзину
                    _currentCustomer = null;
                    CartListBox.DataSource = null;
                    PriceLabel.Text = "0,00";
                }
            }
        }

        /// <summary>
        /// Добавляет выбранный товар в корзину текущего покупателя.
        /// </summary
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ItemsListBox.SelectedItem is Item selectedItem)
            {
                _currentCustomer.Cart.Items.Add(selectedItem);

                CartListBox.DataSource = null;
                CartListBox.DataSource = _currentCustomer.Cart.Items;
                CartListBox.DisplayMember = nameof(Item.Name);

                UpdateAmount();
            }
            else
            {
                MessageBox.Show("Выберите товар для добавления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Создает новый заказ на основе текущей корзины покупателя.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Выберите покупателя!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_currentCustomer.Cart.Items.Count ==0)
            {
                MessageBox.Show("Корзина пуста! Добавьте товары для создания заказа", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем заказ
            var newOrder = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items.ToList());

            // Добавляем заказ в список заказов покупателя
            _currentCustomer.Orders.Add(newOrder);

            _currentCustomer.Cart.Items.Clear();

            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
            CartListBox.DisplayMember = nameof(Item.Name);

            UpdateAmount();

            MessageBox.Show("Заказ успешно создан!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CartListBox.SelectedItem == null)
            {
                return;
            }

            if (CartListBox.SelectedItem is Item selectedItem) 
            {
                _currentCustomer.Cart.Items.Remove(selectedItem);

                CartListBox.DataSource = null;
                CartListBox.DataSource = _currentCustomer.Cart.Items;
                CartListBox.DisplayMember = nameof(Item.Name);

                UpdateAmount();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                return;
            }

            _currentCustomer.Cart.Items.Clear();

            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
            CartListBox.DisplayMember = nameof(Item.Name);

            UpdateAmount();
        }

        /// <summary>
        /// Обрабатывает выбор покупателя в выпадающем списке.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomersComboBox.SelectedValue as Customer;

            if (_currentCustomer == null)
            {
                CartListBox.DataSource = null;
                PriceLabel.Text = "0.0";
                return;
            }

            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
            CartListBox.DisplayMember = nameof(Item.Name);

            UpdateAmount();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAmount()
        {
            if (_currentCustomer != null)
            {
                PriceLabel.Text = _currentCustomer.Cart.Amount.ToString("C2");
            }
            else
            {
                PriceLabel.Text = "0.00";
            }
        }
    }
}
