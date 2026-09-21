namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            itemTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            tabPage2 = new TabPage();
            customerTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 561);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemTab1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(776, 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemTab1
            // 
            itemTab1.Dock = DockStyle.Fill;
            itemTab1.Location = new Point(3, 3);
            itemTab1.Name = "itemTab1";
            itemTab1.Size = new Size(770, 527);
            itemTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customerTab1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(776, 533);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customerTab1
            // 
            customerTab1.Dock = DockStyle.Fill;
            customerTab1.Location = new Point(3, 3);
            customerTab1.Name = "customerTab1";
            customerTab1.Size = new Size(770, 527);
            customerTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private View.Tabs.ItemsTab itemTab1;
        private View.Tabs.CustomersTab customerTab1;
    }
}
