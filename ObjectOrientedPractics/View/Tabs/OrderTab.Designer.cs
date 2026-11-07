namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrderTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            OrdersLabel = new Label();
            OrdersDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            PriorityOptionsLabel = new Label();
            PriceLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            label6 = new Label();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IdTextBox = new TextBox();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IDLabel = new Label();
            SelectedOrderLavel = new Label();
            addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            priorityOptionsPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            panel2.SuspendLayout();
            priorityOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1000, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(OrdersLabel);
            panel1.Controls.Add(OrdersDataGridView);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 794);
            panel1.TabIndex = 0;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            OrdersLabel.Location = new Point(3, 14);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(47, 15);
            OrdersLabel.TabIndex = 1;
            OrdersLabel.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Customer, Address, Cost, Status });
            OrdersDataGridView.Location = new Point(3, 32);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.Size = new Size(438, 759);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.Name = "Date";
            // 
            // Customer
            // 
            Customer.HeaderText = "Покупатель";
            Customer.Name = "Customer";
            // 
            // Address
            // 
            Address.HeaderText = "Адрес";
            Address.Name = "Address";
            // 
            // Cost
            // 
            Cost.HeaderText = "Стоимость";
            Cost.Name = "Cost";
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            // 
            // panel2
            // 
            panel2.Controls.Add(priorityOptionsPanel);
            panel2.Controls.Add(PriceLabel);
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(OrderItemsListBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(StatusComboBox);
            panel2.Controls.Add(CreatedTextBox);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(StatusLabel);
            panel2.Controls.Add(CreatedLabel);
            panel2.Controls.Add(IDLabel);
            panel2.Controls.Add(SelectedOrderLavel);
            panel2.Controls.Add(addressControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(453, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 794);
            panel2.TabIndex = 1;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(88, 42);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(141, 23);
            DeliveryTimeComboBox.TabIndex = 15;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(3, 45);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(79, 15);
            DeliveryTimeLabel.TabIndex = 14;
            DeliveryTimeLabel.Text = "Delivery Time";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            PriorityOptionsLabel.Location = new Point(3, 9);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(104, 15);
            PriorityOptionsLabel.TabIndex = 13;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceLabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            PriceLabel.Location = new Point(344, 612);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(163, 30);
            PriceLabel.TabIndex = 12;
            PriceLabel.Text = "0,0";
            PriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(453, 585);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(54, 15);
            AmountLabel.TabIndex = 11;
            AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.Enabled = false;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(15, 426);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(492, 139);
            OrderItemsListBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label6.Location = new Point(15, 408);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 9;
            label6.Text = "Order Items";
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(107, 129);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(167, 23);
            StatusComboBox.TabIndex = 8;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(107, 87);
            CreatedTextBox.Multiline = true;
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.ReadOnly = true;
            CreatedTextBox.Size = new Size(167, 23);
            CreatedTextBox.TabIndex = 7;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(107, 47);
            IdTextBox.Multiline = true;
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(167, 23);
            IdTextBox.TabIndex = 6;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(15, 132);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 15);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "Status";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(15, 90);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(48, 15);
            CreatedLabel.TabIndex = 4;
            CreatedLabel.Text = "Created";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(15, 50);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(18, 15);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "ID";
            // 
            // SelectedOrderLavel
            // 
            SelectedOrderLavel.AutoSize = true;
            SelectedOrderLavel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            SelectedOrderLavel.Location = new Point(15, 14);
            SelectedOrderLavel.Name = "SelectedOrderLavel";
            SelectedOrderLavel.Size = new Size(95, 15);
            SelectedOrderLavel.TabIndex = 2;
            SelectedOrderLavel.Text = "Selected Order";
            // 
            // addressControl1
            // 
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.Enabled = false;
            addressControl1.Location = new Point(3, 182);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(537, 214);
            addressControl1.TabIndex = 0;
            // 
            // priorityOptionsPanel
            // 
            priorityOptionsPanel.Controls.Add(DeliveryTimeLabel);
            priorityOptionsPanel.Controls.Add(PriorityOptionsLabel);
            priorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            priorityOptionsPanel.Location = new Point(297, 5);
            priorityOptionsPanel.Name = "priorityOptionsPanel";
            priorityOptionsPanel.Size = new Size(243, 100);
            priorityOptionsPanel.TabIndex = 16;
            // 
            // OrderTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrderTab";
            Size = new Size(1000, 800);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            priorityOptionsPanel.ResumeLayout(false);
            priorityOptionsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView OrdersDataGridView;
        private Label OrdersLabel;
        private Panel panel2;
        private Controls.AddressControl addressControl1;
        private Label PriceLabel;
        private Label AmountLabel;
        private ListBox OrderItemsListBox;
        private Label label6;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IdTextBox;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IDLabel;
        private Label SelectedOrderLavel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn Status;
        private Label PriorityOptionsLabel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Panel priorityOptionsPanel;
    }
}
