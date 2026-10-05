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
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
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
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = NameTextBox.Text;
            Customer customer = new Customer(name, address);

            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);

            ClearTextBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0)
            {
                return;
            }

            int index = CustomersListBox.SelectedIndex;
            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            ClearTextBox();
        }

        private void CurtomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0)
            {
                ClearTextBox();
                return;
            }

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];

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
            if (_currentCustomer == null)
            {
                MessageBox.Show("Выберите покупателя для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateName())
            {
                MessageBox.Show("Правильно заполните поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Address address;
            try
            {
                address = addressControl.Address;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _currentCustomer.FullName = NameTextBox.Text;
                _currentCustomer.Address = address;

                int index = CustomersListBox.SelectedIndex;
                CustomersListBox.Items[index] = _currentCustomer;
                CustomersListBox.SelectedIndex = index;

                ClearTextBox();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
