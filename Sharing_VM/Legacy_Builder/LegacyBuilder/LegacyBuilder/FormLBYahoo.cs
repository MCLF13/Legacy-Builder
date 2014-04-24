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
            acoes_NDX();
            acoes_DJI();
            acoes_IBOV();
            
            foreach (string elemento in frmMBMain.mt3)
            {
                listViewStocksY.Items.Add(elemento);
            }
            foreach (string elemento in frmMBMain.mt1)
            {
                listFinancialsY.Items.Add(elemento);
                
            }
            
        }

        FormMBMain frmMBMain = new FormMBMain();
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
            //abre tab
            tabControl1.TabPages.Add("Annual Balances");
        }

        private void quarterlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            //download do codigo fonte da pagina da web
            //string codigo_fonte;

            //Uri uri = new Uri("http://finance.yahoo.com/q/cp?s=%5ENDX");
            //WebRequest request = WebRequest.Create(uri);
            //WebResponse response = request.GetResponse();

            //Stream strm = response.GetResponseStream();
            //StreamReader reader = new StreamReader(strm);

            //codigo_fonte = reader.ReadToEnd();
            //reader.Close();

=======
>>>>>>> FETCH_HEAD
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

        #region Acoes de Indices EUA

        public void acoes_NDX()
        {
<<<<<<< HEAD
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
=======
            string acoes1 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDX");
            string acoes2 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDX&c=1");
            string acoes3 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDX&c=2?s=%5ENDX&c=2");
            string nomes1 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDX");
            string nomes2 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDX&c=1");
            string nomes3 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5ENDX&c=2?s=%5ENDX&c=2");


            ArrayList acoes_1 = new ArrayList();
            ArrayList acoes_2 = new ArrayList();
            ArrayList acoes_3 = new ArrayList();
            ArrayList nomes_1 = new ArrayList();
            ArrayList nomes_2 = new ArrayList();
            ArrayList nomes_3 = new ArrayList();

            int a = Regex.Matches(acoes1, "</a></b></td><td").Count;
            for (int i = 0; i < a; i++)
            {
                acoes1 = acoes1.Remove(0, acoes1.IndexOf("</a></b></td><td") - 10);
                int a1 = acoes1.IndexOf("</a></b></td><td");
                int b = acoes1.IndexOf(">");
                acoes_1.Add(acoes1.Substring(b + 1, a1 - b - 1));
                acoes1 = acoes1.Remove(0, a1 + "</a></b></td><td".Length);
            }
            int c = Regex.Matches(acoes2, "</a></b></td><td").Count;
            for (int i = 0; i < c; i++)
            {
                acoes2 = acoes2.Remove(0, acoes2.IndexOf("</a></b></td><td") - 10);
                int a2 = acoes2.IndexOf("</a></b></td><td");
                int b1 = acoes2.IndexOf(">");
                acoes_2.Add(acoes2.Substring(b1 + 1, a2 - b1 - 1));
                acoes2 = acoes2.Remove(0, a2 + "</a></b></td><td".Length);
            }
            int d = Regex.Matches(acoes3, "</a></b></td><td").Count;
            for (int i = 0; i < d; i++)
            {
                acoes3 = acoes3.Remove(0, acoes3.IndexOf("</a></b></td><td") - 10);
                int a3 = acoes3.IndexOf("</a></b></td><td");
                int b2 = acoes3.IndexOf(">");
                acoes_3.Add(acoes3.Substring(b2 + 1, a3 - b2 - 1));
                acoes3 = acoes3.Remove(0, a3 + "</a></b></td><td".Length);
            }
>>>>>>> FETCH_HEAD

            ArrayList acoes_NDX = new ArrayList();
            foreach (string item in acoes_1)
            {
                acoes_NDX.Add(item);
            }
            foreach (string item in acoes_2)
            {
                acoes_NDX.Add(item);
            }
            foreach (string item in acoes_3)
            {
                acoes_NDX.Add(item);
            }
            int e = Regex.Matches(nomes1, "</a></b></td><td").Count;
            for (int i = 0; i < e; i++)
            {
                nomes1 = nomes1.Remove(0, nomes1.IndexOf("</a></b></td><td") + 25);
                int a3 = nomes1.IndexOf("</td><td");
                int b3 = nomes1.IndexOf(">");
                nomes_1.Add(nomes1.Substring(b3 + 1, a3 - b3 - 1));
                nomes1 = nomes1.Remove(0, a3 + "</a></b></td><td".Length);
            }
            int f = Regex.Matches(nomes2, "</a></b></td><td").Count;
            for (int i = 0; i < f; i++)
            {
                nomes2 = nomes2.Remove(0, nomes2.IndexOf("</a></b></td><td") + 25);
                int a3 = nomes2.IndexOf("</td><td");
                int b3 = nomes2.IndexOf(">");
                nomes_2.Add(nomes2.Substring(b3 + 1, a3 - b3 - 1));
                nomes2 = nomes2.Remove(0, a3 + "</a></b></td><td".Length);
            }
            int g = Regex.Matches(nomes3, "</a></b></td><td").Count;
            for (int i = 0; i < g; i++)
            {
                nomes3 = nomes3.Remove(0, nomes3.IndexOf("</a></b></td><td") + 25);
                int a3 = nomes3.IndexOf("</td><td");
                int b3 = nomes3.IndexOf(">");
                nomes_3.Add(nomes3.Substring(b3 + 1, a3 - b3 - 1));
                nomes3 = nomes3.Remove(0, a3 + "</a></b></td><td".Length);
            }

            ArrayList nomes_NDX = new ArrayList();
            foreach (string item in nomes_1)
            {
                nomes_NDX.Add(item);
            }
            foreach (string item in nomes_2)
            {
                nomes_NDX.Add(item);
            }
            foreach (string item in nomes_3)
            {
                nomes_NDX.Add(item);
            }
            
        }

        public void acoes_DJI()
        {
            
            string acoes1 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5EDJI+Components");
            string nomes1 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5EDJI+Components");

            ArrayList acoes_1 = new ArrayList();
            //ArrayList nomes_1 = new ArrayList();
            ArrayList acoes_DJI = new ArrayList();

            int a = Regex.Matches(acoes1, "</a></b></td><td").Count;
            for (int i = 0; i < a; i++)
            {
                acoes1 = acoes1.Remove(0, acoes1.IndexOf("</a></b></td><td") - 10);
                int a1 = acoes1.IndexOf("</a></b></td><td");
                int b = acoes1.IndexOf(">");
                acoes_1.Add(acoes1.Substring(b + 1, a1 - b - 1));
                acoes1 = acoes1.Remove(0, a1 + "</a></b></td><td".Length);
            }

            acoes_DJI = acoes_1;

            //int d = Regex.Matches(nomes1, "</a></b></td><td").Count;
            //for (int i = 0; i < d; i++)
            //{
            //    nomes1 = nomes1.Remove(0, nomes1.IndexOf("</a></b></td><td") + 25);
            //    int a2 = nomes1.IndexOf("</td><td ");
            //    int b1 = nomes1.IndexOf(">");
            //    nomes_1.Add(acoes1.Substring(b1 + 1, a2 - b1 - 1));
            //    nomes1 = nomes1.Remove(0, a2 + "</a></b></td><td".Length);
            //}
        }

        #endregion

        #region Acoes de Indices Brasil

        public void acoes_IBOV()
        {
            string acoes1 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5EBVSP&c=0");
            string acoes2 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5EBVSP&c=1");
            string nomes1 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5EBVSP&c=0");
            string nomes2 = client.DownloadString("http://finance.yahoo.com/q/cp?s=%5EBVSP&c=1");
            

            ArrayList acoes_1 = new ArrayList();
            ArrayList acoes_2 = new ArrayList();
            ArrayList nomes_1 = new ArrayList();
            ArrayList nomes_2 = new ArrayList();
            ArrayList acoes_IBOV = new ArrayList();
            ArrayList nomes_IBOV = new ArrayList();
            

            int a = Regex.Matches(acoes1, "</a></b></td><td").Count;
            for (int i = 0; i < a; i++)
            {
                acoes1 = acoes1.Remove(0, acoes1.IndexOf("</a></b></td><td") - 10);
                int a1 = acoes1.IndexOf("</a></b></td><td");
                int b = acoes1.IndexOf(">");
                acoes_1.Add(acoes1.Substring(b + 1, a1 - b - 1));
                acoes1 = acoes1.Remove(0, a1 + "</a></b></td><td".Length);
            }
            int c = Regex.Matches(acoes2, "</a></b></td><td").Count;
            for (int i = 0; i < c; i++)
            {
                acoes2 = acoes2.Remove(0, acoes2.IndexOf("</a></b></td><td") - 10);
                int a2 = acoes2.IndexOf("</a></b></td><td");
                int b1 = acoes2.IndexOf(">");
                acoes_2.Add(acoes2.Substring(b1 + 1, a2 - b1 - 1));
                acoes2 = acoes2.Remove(0, a2 + "</a></b></td><td".Length);
            }

            foreach (string item in acoes_1)
            {
                acoes_IBOV.Add(item);
            }
            foreach (string item in acoes_2)
            {
                acoes_IBOV.Add(item);
            }

            int d = Regex.Matches(nomes1, "</a></b></td><td").Count;
            for (int i = 0; i < d; i++)
            {
                nomes1 = nomes1.Remove(0, nomes1.IndexOf("</a></b></td><td") + 25);
                int a3 = nomes1.IndexOf("</td><td");
                int b3 = nomes1.IndexOf(">");
                nomes_1.Add(nomes1.Substring(b3 + 1, a3 - b3 - 1));
                nomes1 = nomes1.Remove(0, a3 + "</a></b></td><td".Length);
            }
            int e = Regex.Matches(nomes2, "</a></b></td><td").Count;
            for (int i = 0; i < e; i++)
            {
                nomes2 = nomes2.Remove(0, nomes2.IndexOf("</a></b></td><td") + 25);
                int a3 = nomes2.IndexOf("</td><td");
                int b3 = nomes2.IndexOf(">");
                nomes_2.Add(nomes2.Substring(b3 + 1, a3 - b3 - 1));
                nomes2 = nomes2.Remove(0, a3 + "</a></b></td><td".Length);
            }

            foreach (string item in nomes_1)
            {
                nomes_IBOV.Add(item);
            }
            foreach (string item in nomes_2)
            {
                nomes_IBOV.Add(item);
            }
        }
        #endregion

<<<<<<< HEAD
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
=======
       
>>>>>>> FETCH_HEAD
      
    }
}
