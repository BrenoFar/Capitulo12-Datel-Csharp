﻿namespace Capitulo12
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.BoldCheckBox = new System.Windows.Forms.CheckBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(309, 171);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.italicCheckBox.TabIndex = 0;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BoldCheckBox
            // 
            this.BoldCheckBox.AutoSize = true;
            this.BoldCheckBox.Location = new System.Drawing.Point(198, 171);
            this.BoldCheckBox.Name = "BoldCheckBox";
            this.BoldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.BoldCheckBox.TabIndex = 1;
            this.BoldCheckBox.Text = "Bold";
            this.BoldCheckBox.UseVisualStyleBackColor = true;
            this.BoldCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(206, 117);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(141, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Watch the font style change";
            this.outputLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.BoldCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox BoldCheckBox;
        private System.Windows.Forms.Label outputLabel;
    }
}
