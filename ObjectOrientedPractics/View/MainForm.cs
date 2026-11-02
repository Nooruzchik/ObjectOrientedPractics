using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// Хранит данные о товарах и покупателях.
        /// </summary>
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();

            // Передаём данные из Store вкладкам
            itemTab1.Items = _store.Items;
            customerTab1.Customers = _store.Customers;

            // Передаем данные в вкладку CartTab
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            orderTab1.Customers = _store.Customers;
        }

        /// <summary>
        /// Обрабатывает переключение вкладок и обновляет данные.
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Индексы вкладок: 0 - Items, 1 - Customers, 2 - Carts, 3 - Orders

            if (tabControl1.SelectedIndex == 2) 
            {
                cartsTab1.RefreshData();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                orderTab1.RefreshData();
            }
        }
    }
}
