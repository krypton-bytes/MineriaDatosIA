using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAupt.uptRNA;

namespace EjemploPerceptronMultiCapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEntrenar_Click(object sender, EventArgs e)
        {
            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"ejemplo.pml");
            rna.entrenar();
        }

        private void BtnReconocer_Click(object sender, EventArgs e)
        {
            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"ejemplo.ppm");
            int numeroDelito = int.Parse(txtDelitos.Text);
            int numeroSancion = int.Parse(txtSanciones.Text);
            int numeroIncidencias = int.Parse(txtInicidencias.Text);
            double[] x = { numeroIncidencias, numeroSancion, numeroDelito };
            rna.reconocer(x);
            double [,] y = rna.y;
            var Request = y[0, 0];
            if(Request == 1)
            {
                lblRequest.Text = "No seguro";
                seguro.Visible = false;
                noSeguro.Visible = true;
            }
            else
            {
                lblRequest.Text = "Seguro";
                seguro.Visible = true;
                noSeguro.Visible = false;
            }
        }
    }
}
