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

            // Передаём данные из Store вкладкам
            itemTab1.Items = _store.Items;
            customerTab1.Customers = _store.Customers;
        }
    }
}
