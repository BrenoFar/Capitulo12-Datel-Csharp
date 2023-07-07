namespace Exercicio_12_6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreto = new System.Windows.Forms.RadioButton();
            this.btnVerde = new System.Windows.Forms.RadioButton();
            this.btnVermelho = new System.Windows.Forms.RadioButton();
            this.btnAzul = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrande = new System.Windows.Forms.RadioButton();
            this.btnMedio = new System.Windows.Forms.RadioButton();
            this.btnPequeno = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btnPreto);
            this.groupBox1.Controls.Add(this.btnVerde);
            this.groupBox1.Controls.Add(this.btnVermelho);
            this.groupBox1.Controls.Add(this.btnAzul);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnPreto
            // 
            this.btnPreto.AutoSize = true;
            this.btnPreto.Location = new System.Drawing.Point(7, 89);
            this.btnPreto.Name = "btnPreto";
            this.btnPreto.Size = new System.Drawing.Size(50, 17);
            this.btnPreto.TabIndex = 3;
            this.btnPreto.Text = "Preto";
            this.btnPreto.UseVisualStyleBackColor = true;
            this.btnPreto.CheckedChanged += new System.EventHandler(this.btnPreto_CheckedChanged);
            // 
            // btnVerde
            // 
            this.btnVerde.AutoSize = true;
            this.btnVerde.Location = new System.Drawing.Point(6, 66);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(53, 17);
            this.btnVerde.TabIndex = 2;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.CheckedChanged += new System.EventHandler(this.btnVerde_CheckedChanged);
            // 
            // btnVermelho
            // 
            this.btnVermelho.AutoSize = true;
            this.btnVermelho.Location = new System.Drawing.Point(6, 43);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(69, 17);
            this.btnVermelho.TabIndex = 1;
            this.btnVermelho.Text = "Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.CheckedChanged += new System.EventHandler(this.btnVermelho_CheckedChanged);
            // 
            // btnAzul
            // 
            this.btnAzul.AutoSize = true;
            this.btnAzul.Location = new System.Drawing.Point(7, 20);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(45, 17);
            this.btnAzul.TabIndex = 0;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.CheckedChanged += new System.EventHandler(this.btnAzul_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.btnGrande);
            this.groupBox2.Controls.Add(this.btnMedio);
            this.groupBox2.Controls.Add(this.btnPequeno);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamanho";
            // 
            // btnGrande
            // 
            this.btnGrande.AutoSize = true;
            this.btnGrande.Location = new System.Drawing.Point(6, 66);
            this.btnGrande.Name = "btnGrande";
            this.btnGrande.Size = new System.Drawing.Size(60, 17);
            this.btnGrande.TabIndex = 2;
            this.btnGrande.TabStop = true;
            this.btnGrande.Text = "Grande";
            this.btnGrande.UseVisualStyleBackColor = true;
            this.btnGrande.CheckedChanged += new System.EventHandler(this.btnGrande_CheckedChanged);
            // 
            // btnMedio
            // 
            this.btnMedio.AutoSize = true;
            this.btnMedio.Location = new System.Drawing.Point(6, 43);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(54, 17);
            this.btnMedio.TabIndex = 1;
            this.btnMedio.TabStop = true;
            this.btnMedio.Text = "Médio";
            this.btnMedio.UseVisualStyleBackColor = true;
            this.btnMedio.CheckedChanged += new System.EventHandler(this.btnMedio_CheckedChanged);
            // 
            // btnPequeno
            // 
            this.btnPequeno.AutoSize = true;
            this.btnPequeno.Location = new System.Drawing.Point(7, 20);
            this.btnPequeno.Name = "btnPequeno";
            this.btnPequeno.Size = new System.Drawing.Size(68, 17);
            this.btnPequeno.TabIndex = 0;
            this.btnPequeno.TabStop = true;
            this.btnPequeno.Text = "Pequeno";
            this.btnPequeno.UseVisualStyleBackColor = true;
            this.btnPequeno.CheckedChanged += new System.EventHandler(this.btnPequeno_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 426);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnPreto;
        private System.Windows.Forms.RadioButton btnVerde;
        private System.Windows.Forms.RadioButton btnVermelho;
        private System.Windows.Forms.RadioButton btnAzul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnGrande;
        private System.Windows.Forms.RadioButton btnMedio;
        private System.Windows.Forms.RadioButton btnPequeno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

