using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private BindingList<Customer> _customers = new BindingList<Customer>();
        private Customer _currentCustomer;

        /// <summary>
        /// Список покупателей, отображаемых на вкладке.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new BindingList<Customer>();
                CustomersListBox.DataSource = _customers;
            }
        }

        public CustomersTab()
        {
            InitializeComponent();

            
            CustomersListBox.DataSource = _customers;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateName())
            {
                MessageBox.Show("Правильно заполните поля");
                return;
            }

            Address address;
            try
            {
                address = addressControl.Address;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = NameTextBox.Text;
            Customer customer = new Customer(name, address);

            // DataSource сам добавит строку в ListBox
            _customers.Add(customer);

            ClearTextBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0)
            {
                return;
            }

            // DataSource сам удалит строку из ListBox
            _customers.RemoveAt(CustomersListBox.SelectedIndex);

            ClearTextBox();
        }

        private void CurtomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomersListBox.SelectedItem as Customer;

            if (_currentCustomer == null)
            {
                ClearTextBox();
                return;
            }

            IdTextBox.Text = _currentCustomer.Id.ToString();
            NameTextBox.Text = _currentCustomer.FullName;
            addressControl.Address = _currentCustomer.Address;
        }

        private bool ValidateName()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NameTextBox.BackColor = Color.LightPink;
                return false;
            }

            NameTextBox.BackColor = Color.White;
            return true;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void ClearTextBox()
        {
            _currentCustomer = null;
            NameTextBox.Clear();
            addressControl.Address = new Address();
            NameTextBox.BackColor = Color.White;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
            var selected = CustomersListBox.SelectedItem as Customer;
            if (selected == null)
            {
                MessageBox.Show("Выберите покупателя для редактирования.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateName())
            {
                MessageBox.Show("Правильно заполните поля",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Address address;
            try
            {
                address = addressControl.Address;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                selected.FullName = NameTextBox.Text;
                selected.Address = address;

                int index = CustomersListBox.SelectedIndex;

                _customers[index] = selected;

                CustomersListBox.SelectedIndex = index;
                ClearTextBox();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
