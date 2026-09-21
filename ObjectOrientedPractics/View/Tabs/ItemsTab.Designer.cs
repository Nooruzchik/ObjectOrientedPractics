namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            tableLayoutPanel2 = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            DescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            SelectedLabel = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(ItemsLabel);
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
            AddButton.BackColor = SystemColors.Control;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(96, 44);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.Control;
            RemoveButton.Location = new Point(105, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(96, 44);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_click;
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
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 25);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(308, 513);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel.Location = new Point(9, 7);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(40, 15);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items";
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
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(DescriptionTextBox);
            panel2.Controls.Add(DescriptionLabel);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(CostTextBox);
            panel2.Controls.Add(IdTextBox);
            panel2.Controls.Add(NameLabel);
            panel2.Controls.Add(CostLabel);
            panel2.Controls.Add(IdLabel);
            panel2.Controls.Add(SelectedLabel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(323, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 594);
            panel2.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(15, 301);
            DescriptionTextBox.MaximumSize = new Size(600, 193);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(444, 193);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(15, 283);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(67, 15);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(15, 153);
            NameTextBox.MaximumSize = new Size(600, 106);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(444, 106);
            NameTextBox.TabIndex = 6;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(57, 90);
            CostTextBox.Multiline = true;
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(130, 23);
            CostTextBox.TabIndex = 5;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(57, 49);
            IdTextBox.Multiline = true;
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(130, 23);
            IdTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(15, 135);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(15, 93);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 2;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(15, 52);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // SelectedLabel
            // 
            SelectedLabel.AutoSize = true;
            SelectedLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedLabel.Location = new Point(15, 13);
            SelectedLabel.Name = "SelectedLabel";
            SelectedLabel.Size = new Size(88, 15);
            SelectedLabel.TabIndex = 0;
            SelectedLabel.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ItemsTab";
            Size = new Size(800, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AddButton;
        private Button RemoveButton;
        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TextBox DescriptionTextBox;
        private Label DescriptionLabel;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private Label SelectedLabel;
        private Button EditButton;
    }
}
