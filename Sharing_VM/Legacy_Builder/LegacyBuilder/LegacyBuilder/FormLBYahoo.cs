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
            formacaoTreeview1();
            acoes();
            
            foreach (string elemento in frmMBMain.mt3)
            {
                listViewStocksY.Items.Add(elemento);
            }
            foreach (string elemento in frmMBMain.mt1)
            {
                listFinancialsY.Items.Add(elemento);
                
            }
            //foreach (string elemento in frmMBMain.mt4)
            //{
            //    treeView1.Nodes.Add(elemento);
            //}
            
        }

        FormMBMain frmMBMain = new FormMBMain();
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
            //string codigo_fonte;

            //Uri uri = new Uri("http://finance.yahoo.com/q/cp?s=%5ENDX");
            //WebRequest request = WebRequest.Create(uri);
            //WebResponse response = request.GetResponse();

            //Stream strm = response.GetResponseStream();
            //StreamReader reader = new StreamReader(strm);

            //codigo_fonte = reader.ReadToEnd();
            //reader.Close();

            //abre tab
            tabControl1.TabPages.Add("Quarterly Balances");
        }

        private void formacaoTreeview1()
        {
            string mttreeview = frmMBMain.m_txt_metadados5;
            int aparicao = Regex.Matches(mttreeview, "\r").Count;
            int node = -1;
            for (int i = 0; i <= aparicao; i++)
            {
                
                if (mttreeview.IndexOf("&&Legacy") >= 0 && mttreeview.IndexOf("&&Legacy") - mttreeview.IndexOf("#") < 0)
                {
                    int a = mttreeview.IndexOf("&&Legacy") + "&&Legacy".Length;
                    int b = mttreeview.IndexOf("*&");
                    treeView1.Nodes.Add(mttreeview.Substring(a, b - a));
                    mttreeview = mttreeview.Remove(mttreeview.IndexOf("&&Legacy"), mttreeview.IndexOf("$") - mttreeview.IndexOf("&&Legacy"));
                    node = node + 1;
                }
                else 
                {
                    int a = mttreeview.IndexOf("$") + 1;
                    int b = mttreeview.IndexOf("#");
                    treeView1.Nodes[node].Nodes.Add(mttreeview.Substring(a, b - a));
                    mttreeview = mttreeview.Remove(mttreeview.IndexOf("$"), mttreeview.IndexOf("#") - mttreeview.IndexOf("$") + 1);
                }
            }

        }


        private void acoes()
        {
            //string acoes1 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDX");
            //string acoes2 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDXc=1");
            //string acoes3 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDX&c=2?s=%5ENDX&c=2");

            //ArrayList acoes_1 = new ArrayList();

            //int a = Regex.Matches(acoes1, "</a></b></td><td").Count;
            //for (int i = 0; i < a; i++)
            //{
            //    acoes1 = acoes1.Remove(0, acoes1.IndexOf("</a></b></td><td") - 10);
            //    int a1 = acoes1.IndexOf("</a></b></td><td");
            //    int b = acoes1.IndexOf(">");
            //    acoes_1.Add(acoes1.Substring(b + 1, a1 - b - 1));
            //    acoes1 = acoes1.Remove(0, a1 + "</a></b></td><td".Length);
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }


        ArrayList treeview = new ArrayList();
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (treeview.IndexOf(treeView1.SelectedNode) < 0)
            {
                treeview.Add(treeView1.SelectedNode);
            }
            else
            {
                treeview.Remove(treeView1.SelectedNode);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Checked == false)
            {
                treeView1.SelectedNode.Checked = true;
            }
            else
            {
                treeView1.SelectedNode.Checked = false;
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //if (treeView1.CheckBoxes.T == false)
            //{
            //    treeView1.SelectedNode.Checked = true;
            //}
            //else
            //{
            //    treeView1.SelectedNode.Checked = false;
            //}
        }
      
    }
}
