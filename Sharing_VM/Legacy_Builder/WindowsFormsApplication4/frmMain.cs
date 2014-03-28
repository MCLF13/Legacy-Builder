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

namespace WindowsFormsApplication4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Leitura_metadados1();
            Leitura_metadados2();
            Leitura_metadados3();
            Formacao_Mt1();
            Formacao_Mt2();
            Formacao_Mt3();
            List_View1();
            List_View2();
            int aparicao = Regex.Matches(m_txt_metadados1, "\r").Count;
        }

        #region Formacao dos Metadados

        string m_txt_metadados1 = "";
        string m_txt_metadados2 = "";
        string m_txt_metadados3 = "";



        private void Leitura_metadados1()
        {
            string strendereco = Application.ExecutablePath;

            FileInfo fiexcel1 = new FileInfo(strendereco);
            
            ArrayList arquivos = new ArrayList();
            arquivos.Add("\\metadados1.txt");
            
            string strEndCompleto = fiexcel1.DirectoryName + (string)arquivos[0];
            
            using (StreamReader sr = new StreamReader(strEndCompleto, Encoding.GetEncoding("ISO-8859-1")))
            {
                m_txt_metadados1 = sr.ReadToEnd();
            }
        }

        

        private void Leitura_metadados2()
        {
            string strendereco = Application.ExecutablePath;

            FileInfo fiexcel1 = new FileInfo(strendereco);

            ArrayList arquivos1 = new ArrayList();
            arquivos1.Add("\\metadados2.txt");

            string strEndCompleto = fiexcel1.DirectoryName + (string)arquivos1[0];

            using (StreamReader sr = new StreamReader(strEndCompleto, Encoding.GetEncoding("ISO-8859-1")))
            {
                m_txt_metadados2 = sr.ReadToEnd();
            }
        }

        

        private void Leitura_metadados3()
        {
            string strendereco = Application.ExecutablePath;

            FileInfo fiexcel1 = new FileInfo(strendereco);

            ArrayList arquivos1 = new ArrayList();
            arquivos1.Add("\\metadados3.txt");

            string strEndCompleto = fiexcel1.DirectoryName + (string)arquivos1[0];

            using (StreamReader sr = new StreamReader(strEndCompleto, Encoding.GetEncoding("ISO-8859-1")))
            {
                m_txt_metadados3 = sr.ReadToEnd();
            }
        }

        

        ArrayList mt1 = new ArrayList();
        ArrayList mt2 = new ArrayList();
        ArrayList mt3 = new ArrayList();
        ArrayList mt3code = new ArrayList();

        int aparicao;



        private void Formacao_Mt1()
        {
            string metadados = m_txt_metadados1;
            aparicao = Regex.Matches(m_txt_metadados1, "\r").Count;
            for (int i = 0; i < aparicao; i++)
            {
                mt1.Add(metadados.Remove(metadados.IndexOf("#")));
                metadados = metadados.Substring(metadados.IndexOf("$") + 1);
            }
        }

        private void Formacao_Mt2()
        {
            string metadados = m_txt_metadados2;
            aparicao = Regex.Matches(m_txt_metadados1, "\r").Count;
            for (int i = 0; i < aparicao; i++)
            {
                mt2.Add(metadados.Remove(metadados.IndexOf("#")));
                metadados = metadados.Substring(metadados.IndexOf("$") + 1);
            }
        }

        private void Formacao_Mt3()
        {
            string metadados = m_txt_metadados3;
            int aparicao1 = Regex.Matches(m_txt_metadados3, "#").Count;
            for (int i = 0; i < aparicao1; i++)
            {
                mt3.Add(metadados.Remove(metadados.IndexOf("#")));
                mt3code.Add(metadados.Substring(metadados.IndexOf("(") + 1, metadados.IndexOf(")") - metadados.IndexOf("(") - 1));
                metadados = metadados.Substring(metadados.IndexOf("$") + 1);
            }
        }

        #endregion


        private void List_View1()
        {
            foreach (string elemento in mt1)
            {
                listView1.Items.Add(elemento);
            }
        }

        private void List_View2()
        {
            foreach (string elemento in mt3)
            {
                listView2.Items.Add(elemento);
            }
        }


        string cod_url = "";
        string url;
        ArrayList ckdlist1 = new ArrayList();
        ArrayList ckdlist2 = new ArrayList();
        ArrayList acoes = new ArrayList();


        private void button1_Click(object sender, EventArgs e)
        {
            Formacao_URL();
            Download();
        }



        private void Formacao_URL()
        {
            url = "http://quote.yahoo.com/d/quotes.csv?s=";

            foreach (Object selecteditem in listView1.CheckedItems)
            {
                ckdlist1.Add(selecteditem.ToString().Substring(selecteditem.ToString().IndexOf("{") + 1, selecteditem.ToString().IndexOf("}") - selecteditem.ToString().IndexOf("{") - 1));
            }
            foreach (Object selecteditem in listView2.CheckedItems)
            {
                ckdlist2.Add(selecteditem.ToString().Substring(selecteditem.ToString().IndexOf("{") + 1, selecteditem.ToString().IndexOf("}") - selecteditem.ToString().IndexOf("{") - 1));
            }
            foreach (string elemento in mt3)
            {
                if (ckdlist2.IndexOf(elemento) >= 0)
                {
                    if (cod_url == "")
                    {
                        cod_url += mt3code[mt3.IndexOf(elemento)];
                    }
                    else
                    {
                        cod_url += "+" + mt3code[mt3.IndexOf(elemento)];
                    }
                }
            }
            foreach (string elemento in mt1)
            {
                if (ckdlist1.IndexOf(elemento) >= 0)
                {
                    if (cod_url.IndexOf("&f=") == -1)
                    {
                        cod_url += "&f=" + mt2[mt1.IndexOf(elemento)];
                    }
                    else
                    {
                        cod_url += mt2[mt1.IndexOf(elemento)];
                    }
                }
            }
            url += cod_url;

        }

        private void Download()
        {
            WebClient client = new WebClient();
            client.DownloadFile(url, @"\\vmware-host\Shared Folders\Legacy-Builder\Sharing_VM\Legacy_Builder\WindowsFormsApplication4\bin\Debug\Dados.csv");
        }
    }
}
