using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LegacyBuilder
{
    public partial class FormLBGoogle : Form
    {
        public FormLBGoogle()
        {
            InitializeComponent();
            FormMBMain frmMBMain = new FormMBMain();
            foreach (string elemento in frmMBMain.mt3)
            {
                listViewStocksY.Items.Add(elemento);
            }
        }

        private void historicalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
