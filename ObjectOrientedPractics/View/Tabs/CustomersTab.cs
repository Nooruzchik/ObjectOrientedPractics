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
            if (!ValidateName() || !ValidateAddress())
            {
                MessageBox.Show("Правильно заполните поля");
                return;
            }

            string name = NameTextBox.Text;
            string address = AddressTextBox.Text;
            Customer customer = new Customer(name, address);

            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);

            ClearTextBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void CurtomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0)
            {
                ClearTextBox();
                return;
            }

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];

            NameTextBox.Text = _currentCustomer.FullName;
            AddressTextBox.Text = _currentCustomer.Address;
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

        private bool ValidateAddress()
        {
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
            {
                AddressTextBox.BackColor = Color.LightPink;
                return false;
            }

            AddressTextBox.BackColor = Color.White;

            return true;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateAddress();
        }

        private void ClearTextBox()
        {
            _currentCustomer = null;
            NameTextBox.Clear();
            AddressTextBox.Clear();

            NameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer== null)
            {
                MessageBox.Show("Выберите книгу для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateAddress() || !ValidateName())
            {
                MessageBox.Show("Правильно заполните поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _currentCustomer.FullName = NameTextBox.Text;
                _currentCustomer.Address = AddressTextBox.Text;

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
