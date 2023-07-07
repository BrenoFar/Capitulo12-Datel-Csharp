using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio12_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Baixa");
            comboBox1.Items.Add("Média");
            comboBox1.Items.Add("Alta");

            comboBox1.SelectedIndex = 2;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedQuality = comboBox1.SelectedItem.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
