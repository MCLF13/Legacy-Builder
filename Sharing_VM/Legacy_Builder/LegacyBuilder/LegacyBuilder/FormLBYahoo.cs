using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Net;
using System.Web;

namespace LegacyBuilder
{
    public partial class FormLBYahoo : Form
    {
        public FormLBYahoo()
        {
            InitializeComponent();
            FormMBMain frmMBMain = new FormMBMain();
            foreach (string elemento in frmMBMain.mt3)
            {
                listViewStocksY.Items.Add(elemento);
            }
            
        }

        string acao;
        string url1;
        WebClient client = new WebClient();

        private void DownloadDadosHistoricos()
        {
            // para dia
            url1="http://ichart.finance.yahoo.com/table.csv?s=";
            url1+= /*codigo da acao*/
            url1+= "&d=3&e=10&f=2014&g=d&a=11&b=30&c=1983&ignore=.csv";
            client.DownloadFile(url1, @"\\vmware-host\Shared Folders\Legacy-Builder\Sharing_VM\Legacy_Builder\WindowsFormsApplication4\bin\Debug\Dados.csv"); 


            //para mes sera semelhantee ano tambem
        }
      
    }
}
