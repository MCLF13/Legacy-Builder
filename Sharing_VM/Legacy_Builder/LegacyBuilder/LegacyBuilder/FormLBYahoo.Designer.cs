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
            this.historicalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewStocksY = new System.Windows.Forms.ListView();
            this.labelStocksY = new System.Windows.Forms.Label();
            this.labelCountryY = new System.Windows.Forms.Label();
            this.listViewCountryY = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.historicalDataToolStripMenuItem,
            this.financialsToolStripMenuItem,
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
            // historicalDataToolStripMenuItem
            // 
            this.historicalDataToolStripMenuItem.Name = "historicalDataToolStripMenuItem";
            this.historicalDataToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.historicalDataToolStripMenuItem.Text = "Historical Data";
            // 
            // financialsToolStripMenuItem
            // 
            this.financialsToolStripMenuItem.Name = "financialsToolStripMenuItem";
            this.financialsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.financialsToolStripMenuItem.Text = "Financials";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.balanceToolStripMenuItem.Text = "Balance";
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
            this.listViewStocksY.Location = new System.Drawing.Point(219, 65);
            this.listViewStocksY.Name = "listViewStocksY";
            this.listViewStocksY.Size = new System.Drawing.Size(347, 350);
            this.listViewStocksY.TabIndex = 1;
            this.listViewStocksY.UseCompatibleStateImageBehavior = false;
            // 
            // labelStocksY
            // 
            this.labelStocksY.AutoSize = true;
            this.labelStocksY.Location = new System.Drawing.Point(216, 49);
            this.labelStocksY.Name = "labelStocksY";
            this.labelStocksY.Size = new System.Drawing.Size(74, 13);
            this.labelStocksY.TabIndex = 2;
            this.labelStocksY.Text = "Select stocks:";
            // 
            // labelCountryY
            // 
            this.labelCountryY.AutoSize = true;
            this.labelCountryY.Location = new System.Drawing.Point(12, 49);
            this.labelCountryY.Name = "labelCountryY";
            this.labelCountryY.Size = new System.Drawing.Size(78, 13);
            this.labelCountryY.TabIndex = 3;
            this.labelCountryY.Text = "Select country:";
            // 
            // listViewCountryY
            // 
            this.listViewCountryY.CheckBoxes = true;
            this.listViewCountryY.Location = new System.Drawing.Point(12, 65);
            this.listViewCountryY.Name = "listViewCountryY";
            this.listViewCountryY.Size = new System.Drawing.Size(188, 133);
            this.listViewCountryY.TabIndex = 4;
            this.listViewCountryY.UseCompatibleStateImageBehavior = false;
            // 
            // FormLBYahoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.listViewCountryY);
            this.Controls.Add(this.labelCountryY);
            this.Controls.Add(this.labelStocksY);
            this.Controls.Add(this.listViewStocksY);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(594, 482);
            this.MinimumSize = new System.Drawing.Size(594, 482);
            this.Name = "FormLBYahoo";
            this.Text = "LB - Yahoo Finance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ListView listViewStocksY;
        private System.Windows.Forms.Label labelStocksY;
        private System.Windows.Forms.ToolStripMenuItem historicalDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label labelCountryY;
        public System.Windows.Forms.ListView listViewCountryY;
    }
}