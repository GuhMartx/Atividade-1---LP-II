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
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcSalBruto_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo Nome está vazio!");
            }
            if (txtCargo.Text == "")
            {
                MessageBox.Show("Campo Cargo está vazio!");
            }
            if (txtNInscricao.Text == "")
            {
                MessageBox.Show("Campo Nº de Inscrição está vazio!");
            }
            if (txtProducao.Text == "")
            {
                MessageBox.Show("Campo Produção está vazio!");
            }
            if (txtSalario.Text == "")
            {
                MessageBox.Show("Campo Salário está vazio!");
            }
            if (txtGratificacao.Text == "")
            {
                MessageBox.Show("Campo Gratificação está vazio!");
            }

            double producao;
            double salario;
            double gratificacao;
            double salBruto;

            double A;
            double B;
            double C;
            double D;

            if ((double.TryParse(txtProducao.Text, out producao) &&
                double.TryParse(txtSalario.Text, out salario) &&
                double.TryParse(txtGratificacao.Text, out gratificacao)))
            {
                A = salario;
                if (producao >= 100)
                {
                    B = 1;
                }
                else
                {
                    B = 0;
                }

                if (producao >= 120)
                {
                    C = 1;
                }
                else
                {
                    C = 0;
                }

                if (producao >= 150)
                {
                    D = 1;
                }
                else
                {
                    D = 0;
                }

                salBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

                if (salBruto > 7000.00 && producao >= 150 && gratificacao > 0 )
                {
                    txtSalBruto.Text = Math.Round(salBruto, 2).ToString();
                }
                else if(salBruto <= 7000.00)
                {
                    txtSalBruto.Text = Math.Round(salBruto, 2).ToString();
                }
                else
                {
                    salBruto = 7000.00;
                    txtSalBruto.Text = salBruto.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCargo.Clear();
            txtNInscricao.Clear();
            txtProducao.Clear();
            txtSalario.Clear();
            txtGratificacao.Clear();
            txtSalBruto.Clear();
        }
    }
}
