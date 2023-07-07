using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio12_7
{
    public partial class JogoAdivinha : Form
    {
        private Random random = new Random();
        private int numeroAleatorio;
        private int tentativas;
        private Color corPadrao;

        public JogoAdivinha()
        {
            InitializeComponent();
            ReiniciarJogo();
            corPadrao = this.BackColor;
        }

        private void ReiniciarJogo()
        {
            numeroAleatorio = random.Next(1, 1001);
            tentativas = 0;
            resultadoLabel.Text = "Eu pensei em um número entre 1 e 1000. Você consegue adivinhar qual é?";
            palpiteTextBox.Text = "";
            this.BackColor = corPadrao;
            palpiteTextBox.Enabled = true;
            verificarButton.Enabled = true;
            jogarNovamenteButton.Enabled = false;
            jogarNovamenteButton.Visible = false;
        }

        private void VerificarPalpite()
        {
            string entrada = palpiteTextBox.Text;
            int palpite;

            if (!int.TryParse(entrada, out palpite))
            {
                MessageBox.Show("Por favor, digite um número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tentativas++;

            if (palpite < numeroAleatorio)
            {
                resultadoLabel.Text = "Pequeno demais!";
                this.BackColor = Color.Blue;
            }
            else if (palpite > numeroAleatorio)
            {
                resultadoLabel.Text = "Grande demais!";
                this.BackColor = Color.Red;
            }
            else
            {
                resultadoLabel.Text = "Correto!";
                this.BackColor = Color.Green;
                palpiteTextBox.Enabled = false;
                verificarButton.Enabled = false;
                jogarNovamenteButton.Enabled = true;
                jogarNovamenteButton.Visible = true;
            }

            palpiteTextBox.Text = "";
        }

        private void verificarButton_Click(object sender, EventArgs e)
        {
            VerificarPalpite();
        }

        private void jogarNovamenteButton_Click(object sender, EventArgs e)
        {
            ReiniciarJogo();
        }
    }
}
