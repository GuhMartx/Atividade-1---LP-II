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
    public partial class frmExercício4 : Form
    {
        public frmExercício4()
        {
            InitializeComponent();
        }
        int quantidade = 0;
        private void btnVerificar1_Click(object sender, EventArgs e)
        {
            for (char.IsNumber(rtxtTexto.Text, rtxtTexto.Text.Length))
            {
                quantidade += 1;
            }

            MessageBox.Show("Há " + quantidade + " de número(s) no texto");
        }

        private void btnVerificar2_Click(object sender, EventArgs e)
        {
            while (char.IsWhiteSpace(rtxtTexto.Text.Length))
            {
                
            }
       
        }

        private void btnVerificar3_Click(object sender, EventArgs e)
        {
            foreach (char.IsLetter(rtxtTexto.Text.Length))
            {
                quantidade += 1;
            }
           MessageBox.Show("Há " + quantidade + " de letra(s) no texto");
        }
    }
}
