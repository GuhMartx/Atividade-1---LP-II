using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace PAtividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExer1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string valor = "";
            string auxiliar = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite um número:" + (x + 1), "Entrada de dados");
                if (valor == "")
                {
                    break;
                }
                if (int.TryParse(valor, out Vetor[x]))
                {
                    //auxiliar = auxiliar + "\n" + Vetor[x].ToString();
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar;
                }
                else
                {
                    MessageBox.Show("Número Inválido!");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExer2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string valor = "";
            string auxiliar = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite um número:" + (x + 1), "Entrada de dados");
                if (valor == "")
                {
                    break;
                }
                if (int.TryParse(valor, out Vetor[x]))
                {
                    MessageBox.Show("Número Inválido!");
                    x--;
                }

            }
            Array.Reverse(Vetor);
            for (var x = 0; x < 20; x++)
            {
                auxiliar = auxiliar + "\n" + Vetor[x];
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExer3_Click(object sender, EventArgs e)
        {
            int[] Quantidade = new int[10];
            double[] Preco = new double[10];
            string valor;
            double faturamento = 0;

            for (int i = 0; i < 10; i++)
            {
                valor = Interaction.InputBox("Digite a quantidade vendida do produto:" + (i + 1), 
                    "Entrada de Quantidade");
                if (int.TryParse(valor, out Quantidade[i]))
                {
                    while (true)
                    {
                        valor = Interaction.InputBox("Digite o valor da mercadoria:" + (i + 1),
                            "Entrada de Preço");
                        if (double.TryParse(valor, out Preco[i]))
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Preço Inválido para Mercadoria" + (i + 1));
                        }
                        
                    }
                    faturamento += Quantidade[i] * Preco[i];
                }
                else
                {
                    MessageBox.Show("Quantidade Inválida da Mercadoria" + (i + 1));
                    i--;
                }
            }
            MessageBox.Show("Faturamento total = R$" + faturamento.ToString("N2"));

        }

        private void btnExer4_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
                                "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }

            MessageBox.Show("O resultado é: " + Total);
        }

        private void btnExer5_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo",
                "Pedro", "Thais" };
            string auxiliar = "";
            ArrayList AlunosList = new ArrayList();
            AlunosList.AddRange(Alunos);
            AlunosList.Remove("Otávio");
            foreach (String nome in AlunosList)
            {
                auxiliar += nome + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExer6_Click(object sender, EventArgs e)
        {
            double[,] Notas = new double[20, 3];
            double media = 0;
            string nota;
            string mediaAluno = "";

            for (int x = 0; x < 20 ; x++)
            {
                for (int y = 0; y < 3 ; y++)
                {
                    nota = Interaction.InputBox("Digite a nota " + (y + 1) + " do Aluno " + (x +1),
                        "Entrada de dados");
                    if (double.TryParse(nota, out Notas[x,y]))
                    {
                        if (Notas[x,y] < 0)
                        {
                            MessageBox.Show("O valor da nota não pode ser menor que 0");
                            y--;
                        }
                        else if (Notas[x,y] > 10)
                        {
                            MessageBox.Show("O valor da nota não pode ser superior a 10");
                            y--;
                        }
                        else
                        {
                            double.TryParse(nota, out Notas[x, y]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite apenas números");
                        y--;
                    }
                }
            }

            for (int x = 0; x < 20; x++)
            {
                media = 0;
                for (int y = 0; y < 3; y++)
                {
                    media = media + Notas[x, y];
                }
                media = media / 3;
                mediaAluno = mediaAluno + "Aluno " + (x + 1) + ":" + " Média: " + media + "\n";
            }

            MessageBox.Show(mediaAluno);
        }

        private void btnExer7_Click(object sender, EventArgs e)
        {
            string[] Nome = new string[6];
            int[] NCaracter = new int[6];
            string nome;

            for (int x = 0; x < 6; x++)
            {
                nome = Interaction.InputBox("Digite o nome completo da pessoa " + (x + 1),
                    " Entrada de dados ");
                if (nome =="")
                {
                    MessageBox.Show("Campo está vazio");
                    x--;
                }
                else
                {
                    Nome[x] = nome;
                    NCaracter[x] = nome.Replace(" ", "").Length; 
                }
            }

            for (int x = 0; x < 6; x++)
            {
                lboxNomes.Items.Add("O nome: " + Nome[x] + " tem " + NCaracter[x] + " Caracteres");
            }
        }
    }
}
