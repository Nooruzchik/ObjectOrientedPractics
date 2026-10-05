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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        private bool _isUpdating = false;

        /// <summary>
        /// Возвращает и задаёт отображаемый адрес.
        /// </summary>
        public Address Address
        {
            get
            {
                if (!ValidateAll())
                {
                    throw new InvalidOperationException(
                        "Адрес содержит некорректные данные. Исправьте подсвеченные поля.");
                }

                return _address;
            }
            set
            {
                _address = value;
                UpdateControl();
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверяет, что все поля адреса заполнены корректно.
        /// </summary>
        /// <returns>true, если все поля валидны; иначе false.</returns>
        private bool ValidateAll()
        {
            bool indexOk = int.TryParse(PostIndexTextBox.Text, out int index)
                           && index >= 100000 && index <= 999999;

            bool countryOk = CountryTextBox.Text.Length <= 50;
            bool cityOk = CityTextBox.Text.Length <= 50;
            bool streetOk = StreetTextBox.Text.Length <= 100;
            bool buildingOk = BuildingTextBox.Text.Length <= 10;
            bool apartmentOk = ApartmentTextBox.Text.Length <= 10;

            return indexOk && countryOk && cityOk && streetOk && buildingOk && apartmentOk;
        }

        /// <summary>
        /// Обновляет содержимое полей ввода значениями из <see cref="_address"/>.
        /// </summary>
        private void UpdateControl()
        {
            _isUpdating = true;

            if (_address == null)
            {
                PostIndexTextBox.Text = "";
                CountryTextBox.Text = "";
                CityTextBox.Text = "";
                StreetTextBox.Text = "";
                BuildingTextBox.Text = "";
                ApartmentTextBox.Text = "";
                return;
            }

            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;

            _isUpdating = false;

            ResetValidation();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (int.TryParse(PostIndexTextBox.Text, out int index)
                && index >= 100000 && index <= 999999)
            {
                _address.Index = index;
                PostIndexTextBox.BackColor = Color.White;
            }
            else
            {
                PostIndexTextBox.BackColor = Color.LightPink;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (CountryTextBox.Text.Length <= 50)
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            else
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (CityTextBox.Text.Length <= 50)
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            else
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (StreetTextBox.Text.Length <= 100)
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
            }
            else
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (BuildingTextBox.Text.Length <= 10)
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            else
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return;

            if (ApartmentTextBox.Text.Length <= 10)
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            else
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        private void ResetValidation()
        {
            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
        }
    }
}
