using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Atividade_6
{
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text == "")
            {
                MessageBox.Show("Campo está vazio!!");
            }
            else
            {
                string palavra = txtPalavra.Text;
                string palavraInv = new string (palavra.Reverse().ToArray());

               // char[] inverso = palavra.ToCharArray();
                //Array.Reverse(inverso);
                //palavraInv= new string(inverso);

               palavra = palavra.Replace(" ", "");
               palavraInv = palavraInv.Replace(" ", "");

                palavra = palavra.ToUpper();
                palavraInv = palavraInv.ToUpper();

                if (String.Compare(palavra,palavraInv,true)==0)
                {
                    MessageBox.Show("É Palíndromo\n" + palavraInv);
                }
                else
                {
                    MessageBox.Show("Não é Palíndromo\n" + palavraInv);
                }
                

            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            txtPalavra.Clear();
        }
    }
}
