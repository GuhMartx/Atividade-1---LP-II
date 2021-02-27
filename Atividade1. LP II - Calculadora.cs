using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1_LP_II__Calculadora_
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnsub_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtnum1.Text, out num1) || !double.TryParse(txtnum2.Text, out num2))
                MessageBox.Show("Número Inválido");

            else
            {
                resultado = num1 - num2;
                txtresultado.Text = resultado.ToString("N2");
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnum1.Text, out num1) && double.TryParse(txtnum2.Text, out num2))
                if (num2 == 0)
                    MessageBox.Show("Não é possível dividir por zero!");

                else
                {
                    resultado = num1 / num2;
                    txtresultado.Text = resultado.ToString("N2");
                }
            else
            {
                MessageBox.Show("Número Inválido");
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtresultado.Clear();
            txtnum1.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmultp_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtnum1.Text, out num1) || !double.TryParse(txtnum2.Text, out num2))
                MessageBox.Show("Número Inválido");

            else
            {
                resultado = num1 * num2;
                txtresultado.Text = resultado.ToString("N2");
            }
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtnum1.Text, out num1) || !double.TryParse(txtnum2.Text, out num2))
                MessageBox.Show("Número Inválido");

            else
            {
                resultado = num1 + num2;
                txtresultado.Text = resultado.ToString("N2");
            }
        }
    }
}
