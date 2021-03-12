using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4_P.Salário
{
    public partial class Form1 : Form
    {
        double salarioBruto = 0;
        double descontoINSS = 0;
        double descontoIRPF = 0;
        double salarioFamilia = 0;
        double valorFamilia = 0;
        double salarioLiquido = 0;
        
        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        int quantidadeFilhos;
        public Form1()
        {
            InitializeComponent();
        }
           
        private void btnverificar_Click(object sender, EventArgs e)
        {
            lbltexto.Visible = true;

            if ((txtnome.Text == "") || (txtnome.Text.Length < 5))
            {
                MessageBox.Show("Nome inválido");
            }
            else if (!double.TryParse(mskbxsalariobruto.Text, out salarioBruto))
            {
                MessageBox.Show("Valor do Salário Bruto inválido");
            }
            else if (salarioBruto <= 800.47)
            {
                txtaliquotaINSS.Text = "7.65%";
                descontoINSS = 7.65 / 100 * salarioBruto;
            }
            else if (salarioBruto <= 1050)
            {
                txtaliquotaINSS.Text = "8.65%";
                descontoINSS = 0.0865 * salarioBruto;
            }
            else if (salarioBruto <= 1400.77)
            {
                txtaliquotaINSS.Text = "9%";
                descontoINSS = 0.09 * salarioBruto;
            }
            else if (salarioBruto <= 2801.56)
            {
                txtaliquotaINSS.Text = "11%";
                descontoINSS = 0.11 * salarioBruto;
            }
            else
            {
                descontoINSS = 308.17;
                txtaliquotaINSS.Text = "0%";
            }
            txtdescontoINSS.Text = descontoINSS.ToString("N2");

            //======================================================================

            if (salarioBruto <= 1257.12)
                {
                    txtaliquotaIRPF.Text = "0%";
                    descontoIRPF = 0;
                }
                else if (salarioBruto <= 2512.08)
                {
                    txtaliquotaIRPF.Text = "15%";
                    descontoIRPF = 0.15 * salarioBruto;
                }
                else
                {
                    txtaliquotaIRPF.Text = "27.5%";
                    descontoIRPF = 0.275 * salarioBruto;
                }
                txtdescontoIRPF.Text = descontoIRPF.ToString("N2");

               //======================================================================

               if (!int.TryParse(mskbxfilhos.Text, out quantidadeFilhos))
                {
                    MessageBox.Show("Valores inválidos");
                }
                else if (salarioBruto <= 435.52)
                {
                    salarioFamilia = 22.33;                  
                }
                else if (salarioBruto <= 654.61)
                {
                    salarioFamilia = 15.74;              
                }
                else
                {
                    salarioFamilia = 0;
                    valorFamilia = 0;                   
                }

            valorFamilia = quantidadeFilhos * salarioFamilia;
            txtsalarioFamilia.Text = valorFamilia.ToString();

            //======================================================================

            if (rbtnhomem.Checked && ckbxcasado.Checked)
            { 
                lbltexto.Text = ("Os descontos do salário do Sr. " + txtnome.Text + ", que é casado e possui " + quantidadeFilhos + " filho(s), são:");
            }
            else if (rbtnhomem.Checked)
            {
                lbltexto.Text = ("Os descontos do salário do Sr. " + txtnome.Text + ", que é solteiro e possui " + quantidadeFilhos + " filho(s), são:");
            }
            else if (rbtnmulher.Checked && ckbxcasado.Checked)
            { 
                lbltexto.Text = ("Os descontos do salário da Sra. " + txtnome.Text + ", que é casada e possui " + quantidadeFilhos + " filho(s), são:");
            }
            else
            {
                lbltexto.Text = ("Os descontos do salário da Srta. " + txtnome.Text + ", que é solteira e possui " + quantidadeFilhos + " filho(s), são:");
            }
                
            //======================================================================
                     
            salarioLiquido = salarioBruto + valorFamilia - descontoINSS - descontoIRPF;
            txtsalarioLiquido.Text = salarioLiquido.ToString("N2");
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            mskbxsalariobruto.Clear();
            mskbxfilhos.Clear();
            txtnome.Focus();
            txtaliquotaINSS.Clear();
            txtaliquotaIRPF.Clear();
            txtdescontoINSS.Clear();
            txtdescontoIRPF.Clear();
            txtsalarioFamilia.Clear();
            txtsalarioLiquido.Clear();
            lbltexto.Text = "";
        }
    }
}
