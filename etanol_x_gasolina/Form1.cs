using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etanol_x_gasolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double gasolina = Convert.ToDouble(txtGasolina.Text);
            double etanol = Convert.ToDouble(txtEtanol.Text);
            double resultado = etanol / gasolina;

            if(resultado < 0.7)
                lblResultado.Text = "ETANOL";
            else
                lblResultado.Text = "GASOLINA";
            
            lblResultado.Visible = true;
        }
    }
}
