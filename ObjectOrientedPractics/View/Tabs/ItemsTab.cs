using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _currentItem;


        public ItemsTab()
        {
            InitializeComponent();
        }

        private void AddButton_click(object sender, EventArgs e)
        {
            if (!ValidateCost() || !ValidateName())
            {
                MessageBox.Show("Правильно заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double cost = double.Parse(CostTextBox.Text);
            string name = NameTextBox.Text;
            string info = DescriptionTextBox.Text;

            Item item = new Item(name, info, cost);

            _items.Add(item);
            ItemsListBox.Items.Add(item);

            ClearTextBox();
        }

        private void RemoveButton_click(object sender, EventArgs e)
        {
            //TODO сделать чтобы при удалении id уменьшался

            if (ItemsListBox.SelectedIndex < 0)
            {
                return;
            }

            int index = ItemsListBox.SelectedIndex;
            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            ClearTextBox();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0)
            {
                ClearTextBox();
                return;
            }

            _currentItem = _items[ItemsListBox.SelectedIndex];

            IdTextBox.Text = _currentItem.Id.ToString();
            NameTextBox.Text = _currentItem.Name;
            CostTextBox.Text = _currentItem.Cost.ToString();
            DescriptionTextBox.Text = _currentItem.Info;
        }

        private bool ValidateCost()
        {
            if (!double.TryParse(CostTextBox.Text, out double cost))
            {
                CostTextBox.BackColor = Color.LightPink;
                return false;
            }

            if (cost < 0 || cost > 100000)
            {
                CostTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Цена должна быть от 1 - 100 000", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            CostTextBox.BackColor = Color.White;
            return true;
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

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateCost();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearTextBox()
        {
            _currentItem = null;
            NameTextBox.Clear();
            CostTextBox.Clear();
            DescriptionTextBox.Clear();

            NameTextBox.BackColor = Color.White;
            CostTextBox.BackColor = Color.White;
            DescriptionTextBox.BackColor = Color.White;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_currentItem == null)
            {
                MessageBox.Show("Выберите книгу для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateCost() || !ValidateName())
            {
                MessageBox.Show("Правильно заполните поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _currentItem.Name = NameTextBox.Text;
                _currentItem.Info = DescriptionTextBox.Text;
                _currentItem.Cost = double.Parse(CostTextBox.Text);


                int index = ItemsListBox.SelectedIndex;
                ItemsListBox.Items[index] = _currentItem;
                ItemsListBox.SelectedIndex = index;

                ClearTextBox();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
