namespace LegacyBuilder
{
    partial class FormLBYahoo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quaterlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewStocksY = new System.Windows.Forms.ListView();
            this.labelStocksY = new System.Windows.Forms.Label();
            this.labelCountryY = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpageFinancials = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listFinancialsY = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpageFinancials.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.balanceToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.helpToolStripMenuItem.Text = "Tools";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annualToolStripMenuItem,
            this.quaterlyToolStripMenuItem});
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.balanceToolStripMenuItem.Text = "Balance";
            // 
            // annualToolStripMenuItem
            // 
            this.annualToolStripMenuItem.Name = "annualToolStripMenuItem";
            this.annualToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.annualToolStripMenuItem.Text = "Annual..";
            this.annualToolStripMenuItem.Click += new System.EventHandler(this.annualToolStripMenuItem_Click);
            // 
            // quaterlyToolStripMenuItem
            // 
            this.quaterlyToolStripMenuItem.Name = "quaterlyToolStripMenuItem";
            this.quaterlyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.quaterlyToolStripMenuItem.Text = "Quarterly..";
            this.quaterlyToolStripMenuItem.Click += new System.EventHandler(this.quarterlyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // listViewStocksY
            // 
            this.listViewStocksY.CheckBoxes = true;
            this.listViewStocksY.GridLines = true;
            this.listViewStocksY.Location = new System.Drawing.Point(347, 33);
            this.listViewStocksY.Name = "listViewStocksY";
            this.listViewStocksY.Size = new System.Drawing.Size(215, 133);
            this.listViewStocksY.TabIndex = 1;
            this.listViewStocksY.UseCompatibleStateImageBehavior = false;
            this.listViewStocksY.View = System.Windows.Forms.View.List;
            // 
            // labelStocksY
            // 
            this.labelStocksY.AutoSize = true;
            this.labelStocksY.Location = new System.Drawing.Point(344, 17);
            this.labelStocksY.Name = "labelStocksY";
            this.labelStocksY.Size = new System.Drawing.Size(74, 13);
            this.labelStocksY.TabIndex = 2;
            this.labelStocksY.Text = "Select stocks:";
            // 
            // labelCountryY
            // 
            this.labelCountryY.AutoSize = true;
            this.labelCountryY.Location = new System.Drawing.Point(196, 17);
            this.labelCountryY.Name = "labelCountryY";
            this.labelCountryY.Size = new System.Drawing.Size(114, 13);
            this.labelCountryY.TabIndex = 3;
            this.labelCountryY.Text = "Select country / index:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpageFinancials);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 416);
            this.tabControl1.TabIndex = 5;
            // 
            // tbpageFinancials
            // 
            this.tbpageFinancials.Controls.Add(this.treeView1);
            this.tbpageFinancials.Controls.Add(this.radioButton1);
            this.tbpageFinancials.Controls.Add(this.button3);
            this.tbpageFinancials.Controls.Add(this.button2);
            this.tbpageFinancials.Controls.Add(this.label3);
            this.tbpageFinancials.Controls.Add(this.textBox2);
            this.tbpageFinancials.Controls.Add(this.label2);
            this.tbpageFinancials.Controls.Add(this.textBox1);
            this.tbpageFinancials.Controls.Add(this.button1);
            this.tbpageFinancials.Controls.Add(this.label1);
            this.tbpageFinancials.Controls.Add(this.listFinancialsY);
            this.tbpageFinancials.Controls.Add(this.listViewStocksY);
            this.tbpageFinancials.Controls.Add(this.labelStocksY);
            this.tbpageFinancials.Controls.Add(this.labelCountryY);
            this.tbpageFinancials.Location = new System.Drawing.Point(4, 22);
            this.tbpageFinancials.Name = "tbpageFinancials";
            this.tbpageFinancials.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageFinancials.Size = new System.Drawing.Size(570, 390);
            this.tbpageFinancials.TabIndex = 0;
            this.tbpageFinancials.Text = "Financials";
            this.tbpageFinancials.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(199, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(142, 97);
            this.treeView1.TabIndex = 15;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 215);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Get Historical Data";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search stocks:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 30);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search country:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 30);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select financials:";
            // 
            // listFinancialsY
            // 
            this.listFinancialsY.CheckBoxes = true;
            this.listFinancialsY.GridLines = true;
            this.listFinancialsY.Location = new System.Drawing.Point(199, 215);
            this.listFinancialsY.Name = "listFinancialsY";
            this.listFinancialsY.Size = new System.Drawing.Size(363, 168);
            this.listFinancialsY.TabIndex = 5;
            this.listFinancialsY.UseCompatibleStateImageBehavior = false;
            this.listFinancialsY.View = System.Windows.Forms.View.List;
            
            // 
            // FormLBYahoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(594, 482);
            this.MinimumSize = new System.Drawing.Size(594, 482);
            this.Name = "FormLBYahoo";
            this.Text = "LB - Yahoo Finance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpageFinancials.ResumeLayout(false);
            this.tbpageFinancials.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ListView listViewStocksY;
        private System.Windows.Forms.Label labelStocksY;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label labelCountryY;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpageFinancials;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listFinancialsY;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem annualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quaterlyToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
    }
}