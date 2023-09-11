using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SobreCargaForms_2024_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Metodos Sobrecargados
        private void btnSuma_Click(object sender, EventArgs e)
        {
            lbSuma.Text = Suma(float.Parse(txtbOperando1.Text), float.Parse(txtbOperando2.Text)).ToString();
        }

        private float Suma(float sumando1, float sumando2)
        {
            return sumando1 + sumando2;
        }


        private void btnSuma2_Click(object sender, EventArgs e)
        {

        }

        private float Suma(float sumando1, float sumando2, float sumando3)
        {
            return sumando1 + sumando2 + sumando3;
        }
        #endregion

    }
}
