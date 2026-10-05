namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DeliveryAddressLabel = new Label();
            PostIndexLabel = new Label();
            CountryLabel = new Label();
            CityLabel = new Label();
            StreetLabel = new Label();
            BuildingLabel = new Label();
            ApartmentLabel = new Label();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeliveryAddressLabel.Location = new Point(13, 12);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(101, 15);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(13, 43);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(61, 15);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post Index";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(13, 82);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(50, 15);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(287, 82);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 3;
            CityLabel.Text = "City";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(13, 127);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(37, 15);
            StreetLabel.TabIndex = 4;
            StreetLabel.Text = "Street";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(13, 173);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(51, 15);
            BuildingLabel.TabIndex = 5;
            BuildingLabel.Text = "Building";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(266, 173);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(64, 15);
            ApartmentLabel.TabIndex = 6;
            ApartmentLabel.Text = "Apartment";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(101, 40);
            PostIndexTextBox.Multiline = true;
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(121, 23);
            PostIndexTextBox.TabIndex = 7;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(101, 79);
            CountryTextBox.Multiline = true;
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(166, 23);
            CountryTextBox.TabIndex = 8;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(332, 79);
            CityTextBox.Multiline = true;
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(172, 23);
            CityTextBox.TabIndex = 9;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(101, 124);
            StreetTextBox.Multiline = true;
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(403, 23);
            StreetTextBox.TabIndex = 10;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(101, 170);
            BuildingTextBox.Multiline = true;
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(121, 23);
            BuildingTextBox.TabIndex = 11;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(347, 170);
            ApartmentTextBox.Multiline = true;
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(157, 23);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(PostIndexTextBox);
            Controls.Add(ApartmentLabel);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetLabel);
            Controls.Add(CityLabel);
            Controls.Add(CountryLabel);
            Controls.Add(PostIndexLabel);
            Controls.Add(DeliveryAddressLabel);
            Name = "AddressControl";
            Size = new Size(600, 300);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeliveryAddressLabel;
        private Label PostIndexLabel;
        private Label CountryLabel;
        private Label CityLabel;
        private Label StreetLabel;
        private Label BuildingLabel;
        private Label ApartmentLabel;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox ApartmentTextBox;
    }
}
