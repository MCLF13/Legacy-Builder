namespace LegacyBuilder
{
    partial class FormLBGoogle
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
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelCountryY = new System.Windows.Forms.Label();
            this.listViewCountryY = new System.Windows.Forms.ListView();
            this.labelStocksY = new System.Windows.Forms.Label();
            this.listViewStocksY = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.financialToolStripMenuItem,
            this.balanceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // financialToolStripMenuItem
            // 
            this.financialToolStripMenuItem.Name = "financialToolStripMenuItem";
            this.financialToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.financialToolStripMenuItem.Text = "Financials";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.balanceToolStripMenuItem.Text = "Balance";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewStocksY);
            this.tabPage1.Controls.Add(this.labelStocksY);
            this.tabPage1.Controls.Add(this.listViewCountryY);
            this.tabPage1.Controls.Add(this.labelCountryY);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelCountryY
            // 
            this.labelCountryY.AutoSize = true;
            this.labelCountryY.Location = new System.Drawing.Point(8, 17);
            this.labelCountryY.Name = "labelCountryY";
            this.labelCountryY.Size = new System.Drawing.Size(78, 13);
            this.labelCountryY.TabIndex = 1;
            this.labelCountryY.Text = "Select country:";
            // 
            // listViewCountryY
            // 
            this.listViewCountryY.CheckBoxes = true;
            this.listViewCountryY.Location = new System.Drawing.Point(11, 33);
            this.listViewCountryY.Name = "listViewCountryY";
            this.listViewCountryY.Size = new System.Drawing.Size(188, 133);
            this.listViewCountryY.TabIndex = 5;
            this.listViewCountryY.UseCompatibleStateImageBehavior = false;
            // 
            // labelStocksY
            // 
            this.labelStocksY.AutoSize = true;
            this.labelStocksY.Location = new System.Drawing.Point(212, 17);
            this.labelStocksY.Name = "labelStocksY";
            this.labelStocksY.Size = new System.Drawing.Size(74, 13);
            this.labelStocksY.TabIndex = 3;
            this.labelStocksY.Text = "Select stocks:";
            // 
            // listViewStocksY
            // 
            this.listViewStocksY.CheckBoxes = true;
            this.listViewStocksY.GridLines = true;
            this.listViewStocksY.Location = new System.Drawing.Point(215, 33);
            this.listViewStocksY.Name = "listViewStocksY";
            this.listViewStocksY.Size = new System.Drawing.Size(347, 350);
            this.listViewStocksY.TabIndex = 6;
            this.listViewStocksY.UseCompatibleStateImageBehavior = false;
            this.listViewStocksY.View = System.Windows.Forms.View.List;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 417);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Visible = false;
            // 
            // FormLBGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLBGoogle";
            this.Text = "LB - Google Finance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.ListView listViewStocksY;
        private System.Windows.Forms.Label labelStocksY;
        public System.Windows.Forms.ListView listViewCountryY;
        private System.Windows.Forms.Label labelCountryY;
        private System.Windows.Forms.TabControl tabControl1;
    }
}