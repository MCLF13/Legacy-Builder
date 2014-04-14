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
    public partial class FormMBMain : Form
    {
        public FormMBMain()
        {
            InitializeComponent();
            Leitura_metadados1();
            Leitura_metadados2();
            Leitura_metadados3();
            Formacao_Mt1();
            Formacao_Mt2();
            Formacao_Mt3();
            //FormacaolistViewStocksY();
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



        public ArrayList mt1 = new ArrayList();
        public ArrayList mt2 = new ArrayList();
        public ArrayList mt3 = new ArrayList();
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

        // private void FormacaolistViewStocksY()
        //{
        //    FormLBYahoo listViewS = new FormLBYahoo();
        //    foreach (string elemento in mt3)
        //    {
        //      listViewS.listViewStocksY.Items.Add(elemento);
        //    }
        //}

        #endregion

         private void yahooFinanceToolStripMenuItem_Click(object sender, EventArgs e)
         {

             FormLBYahoo FormLBYahoo1 = new FormLBYahoo();
             FormLBYahoo1.ShowDialog();

         }
         private void googleFinanceToolStripMenuItem_Click(object sender, EventArgs e)
         {
             FormLBGoogle FormLBGoogle1 = new FormLBGoogle();
             FormLBGoogle1.ShowDialog();
         }


        string cod_url = "";
        string url;
        string url2;
        ArrayList ckdlist1 = new ArrayList();
        ArrayList ckdlist2 = new ArrayList();
        ArrayList acoes = new ArrayList();
        ArrayList dadoshistoricos = new ArrayList();


             #region Formação URL

        public void FormacaoURL()
        {
             FormLBYahoo listViewS = new FormLBYahoo();

             url = "http://quote.yahoo.com/d/quotes.csv?s=";

             //foreach (Object selecteditem in listView1.CheckedItems)
             //{
             //ckdlist1.Add(selecteditem.ToString().Substring(selecteditem.ToString().IndexOf("{") + 1, selecteditem.ToString().IndexOf("}") - selecteditem.ToString().IndexOf("{") - 1));
             //}
             foreach (Object selecteditem in listViewS.listViewStocksY.CheckedItems)
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

        private void FormacaoURL2()
        {
 
        }

             #endregion

        
             #region Download

        WebClient client = new WebClient();

        public void Download()
        {
            
            client.DownloadFile(url, @"\\vmware-host\Shared Folders\Legacy-Builder\Sharing_VM\Legacy_Builder\WindowsFormsApplication4\bin\Debug\Dados.csv");
            
        }
        public void DownloadDadosHistoricos()
        {
            client.DownloadFile(url, @"\\vmware-host\Shared Folders\Legacy-Builder\Sharing_VM\Legacy_Builder\WindowsFormsApplication4\bin\Debug\Dados.csv");
        }
        
            #endregion

        private void FormMBMain_Load(object sender, EventArgs e)
        {

        }



    }
}
