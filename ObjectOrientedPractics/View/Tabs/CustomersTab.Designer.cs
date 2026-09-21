namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            RemoveButton = new Button();
            EditButton = new Button();
            CustomersListBox = new ListBox();
            CustomersLabel = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            AddressTextBox = new TextBox();
            NameTextBox = new TextBox();
            IdTextBox = new TextBox();
            AddressLabel = new Label();
            NameLabel = new Label();
            IdLabel = new Label();
            SelectedCustomersLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
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
            panel1.Controls.Add(CustomersListBox);
            panel1.Controls.Add(CustomersLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 594);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel2.Controls.Add(EditButton, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 541);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(308, 50);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(96, 44);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(105, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(96, 44);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Fill;
            EditButton.Location = new Point(207, 3);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 44);
            EditButton.TabIndex = 2;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.IntegralHeight = false;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 27);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(308, 509);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CurtomersListBox_SelectedIndexChanged;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLabel.Location = new Point(12, 9);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(71, 15);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(323, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 594);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Size = new Size(474, 594);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(AddressTextBox);
            panel3.Controls.Add(NameTextBox);
            panel3.Controls.Add(IdTextBox);
            panel3.Controls.Add(AddressLabel);
            panel3.Controls.Add(NameLabel);
            panel3.Controls.Add(IdLabel);
            panel3.Controls.Add(SelectedCustomersLabel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 231);
            panel3.TabIndex = 0;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(103, 97);
            AddressTextBox.MaximumSize = new Size(450, 131);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(362, 131);
            AddressTextBox.TabIndex = 6;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(103, 65);
            NameTextBox.MaximumSize = new Size(450, 23);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(362, 23);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(103, 36);
            IdTextBox.Multiline = true;
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(130, 23);
            IdTextBox.TabIndex = 4;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(18, 97);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(52, 15);
            AddressLabel.TabIndex = 3;
            AddressLabel.Text = "Address:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(18, 68);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(64, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(18, 39);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // SelectedCustomersLabel
            // 
            SelectedCustomersLabel.AutoSize = true;
            SelectedCustomersLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomersLabel.Location = new Point(18, 9);
            SelectedCustomersLabel.Name = "SelectedCustomersLabel";
            SelectedCustomersLabel.Size = new Size(119, 15);
            SelectedCustomersLabel.TabIndex = 0;
            SelectedCustomersLabel.Text = "Selected Customer";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomersTab";
            Size = new Size(800, 600);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox CustomersListBox;
        private Label CustomersLabel;
        private Panel panel2;
        private Button AddButton;
        private Button RemoveButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private TextBox AddressTextBox;
        private TextBox NameTextBox;
        private TextBox IdTextBox;
        private Label AddressLabel;
        private Label NameLabel;
        private Label IdLabel;
        private Label SelectedCustomersLabel;
        private Button EditButton;
    }
}
