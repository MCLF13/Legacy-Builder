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
            foreach (string elemento in frmMBMain.mt1)
            {
                listFinancialsY.Items.Add(elemento);
                
            }
            foreach (string elemento in frmMBMain.mt4)
            {
                treeView1.Nodes.Add(elemento);
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


            //para mes sera semelhante e ano tambem
        }

        private void annualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //download do codigo fonte da pagina da web
            string codigo_fonte;

            Uri uri = new Uri("http://finance.yahoo.com/q/bs?s=AAPL&annual");
            WebRequest request = WebRequest.Create(uri);
            WebResponse response = request.GetResponse();

            Stream strm = response.GetResponseStream();
            StreamReader reader = new StreamReader(strm);

            codigo_fonte = reader.ReadToEnd();
            reader.Close();

            //string pattern = @"><strong>";
            //foreach (Match match in Regex.Matches(codigo_fonte, pattern))
            //{
            //    Console.WriteLine("Match: {0}", match.Value);
            //    for (int groupCtr = 0; groupCtr < match.Groups.Count; groupCtr++)
            //    {
            //        Group group = match.Groups[groupCtr];
            //        Console.WriteLine("   Group {0}: {1}", groupCtr, group.Value);
            //        for (int captureCtr = 0; captureCtr < group.Captures.Count; captureCtr++)
            //            Console.WriteLine("      Capture {0}: {1}", captureCtr,
            //                              group.Captures[captureCtr].Value);
            //    }
            //}

            //abre tab
            tabControl1.TabPages.Add("Annual Balances");


        }

        private void quarterlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //download do codigo fonte da pagina da web
            string codigo_fonte;

            Uri uri = new Uri("http://finance.yahoo.com/q/bs?s=AAPL");
            WebRequest request = WebRequest.Create(uri);
            WebResponse response = request.GetResponse();

            Stream strm = response.GetResponseStream();
            StreamReader reader = new StreamReader(strm);

            codigo_fonte = reader.ReadToEnd();
            reader.Close();

            //abre tab
            tabControl1.TabPages.Add("Quarterly Balances");
        }
      
    }
}
