using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryRodriguezSP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("MiArchivito", false);
                MessageBox.Show("Archivo Creado");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swManejoAchivo = new StreamWriter("MiArchivito", true);

                swManejoAchivo.WriteLine(txtDatos.Text);
                swManejoAchivo.Close();


                MessageBox.Show("almacenado");
                txtDatos.Text = "";
                txtDatos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader srManejoArchivo = new StreamReader("miArchivito");


            while (srManejoArchivo.EndOfStream==false)
            {
                txtDatos.Text += srManejoArchivo.ReadLine() + Environment.NewLine;
            }

            srManejoArchivo.Close();
        }
    }
}
