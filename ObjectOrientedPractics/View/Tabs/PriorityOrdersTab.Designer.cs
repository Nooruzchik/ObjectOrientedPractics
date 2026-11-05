namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            panel1 = new Panel();
            ClearOrdeButtonr = new Button();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            PriceLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            OrderItemsLabel = new Label();
            DeliveryTimeComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            IdTextBox = new TextBox();
            AddressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            deliveryTimeLabel = new Label();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            PriorityOptionsLabel = new Label();
            SelectedOrderLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ClearOrdeButtonr);
            panel1.Controls.Add(RemoveItemButton);
            panel1.Controls.Add(AddItemButton);
            panel1.Controls.Add(PriceLabel);
            panel1.Controls.Add(AmountLabel);
            panel1.Controls.Add(OrderItemsListBox);
            panel1.Controls.Add(OrderItemsLabel);
            panel1.Controls.Add(DeliveryTimeComboBox);
            panel1.Controls.Add(CreatedTextBox);
            panel1.Controls.Add(StatusComboBox);
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(AddressControl1);
            panel1.Controls.Add(deliveryTimeLabel);
            panel1.Controls.Add(StatusLabel);
            panel1.Controls.Add(CreatedLabel);
            panel1.Controls.Add(IdLabel);
            panel1.Controls.Add(PriorityOptionsLabel);
            panel1.Controls.Add(SelectedOrderLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 800);
            panel1.TabIndex = 0;
            // 
            // ClearOrdeButtonr
            // 
            ClearOrdeButtonr.Location = new Point(641, 712);
            ClearOrdeButtonr.Name = "ClearOrdeButtonr";
            ClearOrdeButtonr.Size = new Size(150, 50);
            ClearOrdeButtonr.TabIndex = 17;
            ClearOrdeButtonr.Text = "Clear Order";
            ClearOrdeButtonr.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(186, 712);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(150, 50);
            RemoveItemButton.TabIndex = 16;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(3, 712);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(150, 50);
            AddItemButton.TabIndex = 15;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Right;
            PriceLabel.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            PriceLabel.Location = new Point(604, 623);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(187, 49);
            PriceLabel.TabIndex = 14;
            PriceLabel.Text = "0,00";
            PriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            AmountLabel.Location = new Point(719, 608);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(60, 15);
            AmountLabel.TabIndex = 13;
            AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(3, 394);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(794, 199);
            OrderItemsListBox.TabIndex = 12;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Location = new Point(3, 376);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(69, 15);
            OrderItemsLabel.TabIndex = 11;
            OrderItemsLabel.Text = "Order Items";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(412, 42);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(195, 23);
            DeliveryTimeComboBox.TabIndex = 10;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(79, 74);
            CreatedTextBox.Multiline = true;
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.ReadOnly = true;
            CreatedTextBox.Size = new Size(195, 23);
            CreatedTextBox.TabIndex = 9;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(79, 107);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(195, 23);
            StatusComboBox.TabIndex = 8;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(79, 41);
            IdTextBox.Multiline = true;
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(195, 23);
            IdTextBox.TabIndex = 7;
            // 
            // AddressControl1
            // 
            AddressControl1.Location = new Point(3, 147);
            AddressControl1.Name = "AddressControl1";
            AddressControl1.Size = new Size(514, 213);
            AddressControl1.TabIndex = 6;
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new Point(313, 45);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new Size(79, 15);
            deliveryTimeLabel.TabIndex = 5;
            deliveryTimeLabel.Text = "Delivery Time";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(3, 111);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(3, 78);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(48, 15);
            CreatedLabel.TabIndex = 3;
            CreatedLabel.Text = "Created";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 45);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(18, 15);
            IdLabel.TabIndex = 2;
            IdLabel.Text = "ID";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            PriorityOptionsLabel.Location = new Point(313, 10);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(104, 15);
            PriorityOptionsLabel.TabIndex = 1;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            SelectedOrderLabel.Location = new Point(3, 10);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(95, 15);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PriorityOrdersTab";
            Size = new Size(800, 800);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label deliveryTimeLabel;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        private Label PriorityOptionsLabel;
        private Label SelectedOrderLabel;
        private Controls.AddressControl AddressControl1;
        private ComboBox StatusComboBox;
        private TextBox IdTextBox;
        private ComboBox DeliveryTimeComboBox;
        private TextBox CreatedTextBox;
        private ListBox OrderItemsListBox;
        private Label OrderItemsLabel;
        private Label AmountLabel;
        private Label PriceLabel;
        private Button ClearOrdeButtonr;
        private Button RemoveItemButton;
        private Button AddItemButton;
    }
}
