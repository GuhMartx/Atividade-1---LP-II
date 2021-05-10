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
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            if (rtxtTexto.Text == "")
            {
                MessageBox.Show("Campo está vazio");
            }
            else
            {
                int cont = 0;

                for (var x = 0; x < rtxtTexto.Text.Length; x++)
                {
                    if (Char.IsWhiteSpace(rtxtTexto.Text[x]))
                    {
                        cont += 1;
                    }
                }

                MessageBox.Show("Quantidade de Espaços em Branco:" + cont);
            }
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            if (rtxtTexto.Text == "")
            {
                MessageBox.Show("Campo está vazio");
            }
            else
            {
                int cont = 0;

                foreach (char c in rtxtTexto.Text)
                {
                    if (c == 'R' || c == 'r')
                    {
                        cont += 1;
                    }
                }
                MessageBox.Show("Número de vezes que ocorre a letra R: " + cont);
            }
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            if (rtxtTexto.Text == "")
            {
                MessageBox.Show("Campo está vazio");
            }
            else
            {
                int cont = 0;
                for (int x = 1; x < rtxtTexto.Text.Length; x++)
                {
                    if (Char.Equals(rtxtTexto.Text[x], rtxtTexto.Text[x - 1]))
                    {
                        cont += 1;
                    }
                }
                MessageBox.Show("Número de ocorrência de pares de letras: " + cont);
            }
            }

        private void FrmExercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            rtxtTexto.Clear();
        }
    }
    }

