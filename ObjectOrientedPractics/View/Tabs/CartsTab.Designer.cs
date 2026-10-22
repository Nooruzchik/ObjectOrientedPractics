namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            tableLayoutPanel2 = new TableLayoutPanel();
            AddButton = new Button();
            ItemsLabel = new Label();
            ItemsListBox = new ListBox();
            panel2 = new Panel();
            CartListBox = new ListBox();
            ClearButton = new Button();
            RemoveButton = new Button();
            CreateOrderButton = new Button();
            PriceLabel = new Label();
            AmountLabel = new Label();
            CartLabel = new Label();
            CustomersComboBox = new ComboBox();
            CustomersLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0952377F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.9047623F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(ItemsLabel);
            panel1.Controls.Add(ItemsListBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 594);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 531);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(292, 60);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(91, 54);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add To Cart";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            ItemsLabel.Location = new Point(3, 10);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(40, 15);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 28);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(292, 499);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(CartListBox);
            panel2.Controls.Add(ClearButton);
            panel2.Controls.Add(RemoveButton);
            panel2.Controls.Add(CreateOrderButton);
            panel2.Controls.Add(PriceLabel);
            panel2.Controls.Add(AmountLabel);
            panel2.Controls.Add(CartLabel);
            panel2.Controls.Add(CustomersComboBox);
            panel2.Controls.Add(CustomersLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(307, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 594);
            panel2.TabIndex = 1;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(18, 88);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(463, 184);
            CartListBox.TabIndex = 10;
            CartListBox.SelectedIndexChanged += CartListBox_SelectedIndexChanged;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearButton.Location = new Point(368, 345);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(113, 44);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "Clear Cart";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveButton.Location = new Point(240, 345);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(113, 44);
            RemoveButton.TabIndex = 8;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(18, 345);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(113, 44);
            CreateOrderButton.TabIndex = 7;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            PriceLabel.Location = new Point(413, 297);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(68, 45);
            PriceLabel.TabIndex = 5;
            PriceLabel.Text = "0,0";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            AmountLabel.Location = new Point(425, 282);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(60, 15);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount:";
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(18, 70);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(29, 15);
            CartLabel.TabIndex = 2;
            CartLabel.Text = "Cart";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(105, 28);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(376, 23);
            CustomersComboBox.TabIndex = 1;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            CustomersLabel.Location = new Point(18, 31);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(71, 15);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CartsTab";
            Size = new Size(800, 600);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Panel panel2;
        private Button CreateOrderButton;
        private Label PriceLabel;
        private Label AmountLabel;
        private Label CartLabel;
        private ComboBox CustomersComboBox;
        private Label CustomersLabel;
        private Button ClearButton;
        private Button RemoveButton;
        private ListBox CartListBox;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AddButton;
    }
}
