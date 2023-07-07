using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCap12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BoldCheckBox_CheckedChanged(object sender, EventArgs e) // bold
        {
            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e) // italic
        {
            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Italic);
        }
        private void underlineCheckBox_CheckedChanged_1(object sender, EventArgs e) // underline
        {
            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Underline);
        }
        private void strikeoutCheckBox_CheckedChanged(object sender, EventArgs e) // strikeout
        {
            outputLabel.Font = new Font(outputLabel.Font, outputLabel.Font.Style ^ FontStyle.Strikeout);
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
