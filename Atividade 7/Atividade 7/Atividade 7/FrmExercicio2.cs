using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_6
{
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            double N;
            double H = 0;
            double cont;

            if ((double.TryParse(txtN.Text, out N)))
            {
                for (cont = 1; cont <= N; cont++)
                {
                    H = H + (1 / cont);
                }

                txtH.Text = Math.Round(H,2).ToString();
            }
            else if(txtN.Text == "")
            {
                MessageBox.Show("Campo N vazio!!");
            }
            else
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtH.Clear();
            txtN.Clear();
        }
    }
}
