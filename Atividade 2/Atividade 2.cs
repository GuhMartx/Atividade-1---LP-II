using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        double altura, peso;
        double pesoIdeal = 0;
        public Form1()
        {
            InitializeComponent();
            btnverificar.Enabled = false;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtpeso.Clear();
            txtpeso.Focus();
            btnverificar.Enabled = false;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtaltura_TextChanged(object sender, EventArgs e)
        {
            btnverificar.Enabled = txtaltura.Text != "" ? true : false;
            btnverificar.Enabled = txtpeso.Text != "" ? true : false;
        }   
        private void btnverificar_Click(object sender, EventArgs e)
        {
            double.TryParse(txtaltura.Text, out altura);
            if (radiohomem.Checked)
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else
            {
                pesoIdeal = (62.7 * altura) - 44.7;
            }
            StringBuilder stringona = new StringBuilder("Peso ideal: " + pesoIdeal.ToString("N2") + "Kg");

            if (txtpeso.Text != null)
            {
                double.TryParse(txtpeso.Text, out peso);
                if (peso != null)
                {
                    if (pesoIdeal < peso)
                    {
                        stringona.Append(Environment.NewLine + "Regime Obrigatório Já");
                    }
                    else if (pesoIdeal > peso)
                    {
                        stringona.Append(Environment.NewLine + "Coma bastante massas e doces");
                    }
                    else
                    {
                        stringona.Append(Environment.NewLine + "Você está com o peso ideal");
                    }
                }
            }
            
            MessageBox.Show(stringona.ToString());
            
        }
    }
}
