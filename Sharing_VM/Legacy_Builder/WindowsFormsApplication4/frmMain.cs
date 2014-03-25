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
            Leitura_metadados();
            Formacao_Treeview();
        }

        string m_txt_metadados = "";

        private void Leitura_metadados()
        {
            string strendereco = Application.ExecutablePath;

            FileInfo fiexcel1 = new FileInfo(strendereco);
            
            ArrayList arquivos = new ArrayList();
            arquivos.Add("\\metadados.txt");
            
            string strEndCompleto = fiexcel1.DirectoryName + (string)arquivos[0];
            
            using (StreamReader sr = new StreamReader(strEndCompleto, Encoding.GetEncoding("ISO-8859-1")))
            {
                m_txt_metadados = sr.ReadToEnd();
            }
        }
        ArrayList treeview = new ArrayList();

        int aparicao;
        

        private void Formacao_Treeview()
        {
            string metadados = m_txt_metadados;
            aparicao = Regex.Matches(m_txt_metadados, "\r").Count;
            for (int i = 0; i < aparicao; i++)
            {
                treeview.Add(metadados.Remove(metadados.IndexOf("#")));
                metadados = metadados.Substring(metadados.IndexOf("$") + 1);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
