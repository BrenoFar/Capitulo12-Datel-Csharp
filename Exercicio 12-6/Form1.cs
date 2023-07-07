using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_12_6
{
    public partial class Form1 : Form
    {
        bool shouldPaint = false;
        int widht = 0;
        int height = 0;
        public Form1()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAzul_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVermelho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVerde_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPreto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint && btnPreto.Checked)
            {
                using (Graphics graphics = pictureBox1.CreateGraphics()) 
                {
                    graphics.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, widht, height);
                }
            }
            else if (shouldPaint && btnAzul.Checked)
            {
                using (Graphics graphics = pictureBox1.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, widht, height);
                }
            }
            else if (shouldPaint && btnVermelho.Checked)
            {
                using (Graphics graphics = pictureBox1.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, widht, height);
                }
            }
            else if (shouldPaint && btnVerde.Checked)
            {
                using (Graphics graphics = pictureBox1.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Green), e.X, e.Y, widht, height);
                }
            }

        }

        private void btnPequeno_CheckedChanged(object sender, EventArgs e) // 
        {
            if (btnPequeno.Checked)
            {
                widht = 2;
                height = 2;
            }
        }

        private void btnMedio_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMedio.Checked)
            {
                widht = 4;
                height = 4;
            }
        }

        private void btnGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (btnGrande.Checked)
            {
                widht = 6;
                height = 6;
            }
        }
    }
}
