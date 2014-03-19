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
        }

        private string m_txt_metadados = "";

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
