using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        double a, b, c, x;

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtvalorA.Clear();
            txtvalorB.Clear();
            txtvalorC.Clear();
            txtvalorA.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalorA.Text, out a) && double.TryParse(txtvalorB.Text, out b) && double.TryParse(txtvalorC.Text, out c))
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    if (b > a && b > c)
                    {
                        x = a;
                        a = b;
                        b = x;
                    }
                    if (c > a && c > b)
                    {
                        x = a;
                        a = c;
                        c = x;
                    }

                    if (a >= b + c)
                        MessageBox.Show("Não forma um triângulo");

                    else if (a == b && b == c)
                        MessageBox.Show("Triângulo equilátero");

                    else if (a != b && b != c)
                        MessageBox.Show("Triângulo escaleno");

                    else if (a == b || b == c || c == a)
                        MessageBox.Show("Triângulo isósceles");

                    else
                        MessageBox.Show("Valores inválidos");
                }
            }
            else
                MessageBox.Show("Valores inválidos");
        }
    }
}
