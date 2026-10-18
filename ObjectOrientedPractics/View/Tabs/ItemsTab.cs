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
        /// <summary>
        /// Список товаров, отображаемых на вкладке
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// Товар, выбранный в списке в данный момент
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задаёт список товаров, отображаемых на вкладке.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new BindingList<Item>();
                ItemsListBox.DataSource = _items;
            }
        }

        public ItemsTab()
        {
            InitializeComponent();

            // Заполняем ComboBox значениями перечисления Category
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            // Один раз привязываем список — дальше всё обновляется само
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        private void AddButton_click(object sender, EventArgs e)
        {
            if (!ValidateCost() || !ValidateName() || CategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Правильно заполните поля!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _items.Add(new Item(
                NameTextBox.Text,
                DescriptionTextBox.Text,
                double.Parse(CostTextBox.Text),
                (Category)CategoryComboBox.SelectedItem));

            ClearTextBox();
        }

        private void RemoveButton_click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item item)
            {
                _items.Remove(item);
                ClearTextBox();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
            {
                ClearTextBox();
                return;
            }

            _currentItem = item;
            IdTextBox.Text = item.Id.ToString();
            NameTextBox.Text = item.Name;
            CostTextBox.Text = item.Cost.ToString();
            DescriptionTextBox.Text = item.Info;
            CategoryComboBox.SelectedItem = item.Category;
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
            CategoryComboBox.SelectedIndex = -1;
            ItemsListBox.ClearSelected();

            NameTextBox.BackColor = Color.White;
            CostTextBox.BackColor = Color.White;
            DescriptionTextBox.BackColor = Color.White;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_currentItem == null)
            {
                MessageBox.Show("Выберите товар для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateCost() || !ValidateName() || CategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Правильно заполните поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _currentItem.Name = NameTextBox.Text;
                _currentItem.Info = DescriptionTextBox.Text;
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                _currentItem.Category = (Category)CategoryComboBox.SelectedItem;


                _items.ResetItem(_items.IndexOf(_currentItem));

                ClearTextBox();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Обрабатывает изменение выбранной категории в <see cref="CategoryComboBox"/>.
        /// Записывает выбранную категорию в текущий товар.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Если товар не выбран или в ComboBox ничего не выбрано — ничего не делаем
            if (_currentItem == null || CategoryComboBox.SelectedItem == null)
            {
                return;
            }

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
            _items.ResetItem(_items.IndexOf(_currentItem));
        }
    }
}
