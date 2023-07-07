namespace Exercicio12_7
{
    partial class JogoAdivinha
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
            this.jogarNovamenteButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.palpiteTextBox = new System.Windows.Forms.TextBox();
            this.verificarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jogarNovamenteButton
            // 
            this.jogarNovamenteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogarNovamenteButton.Location = new System.Drawing.Point(643, 303);
            this.jogarNovamenteButton.Name = "jogarNovamenteButton";
            this.jogarNovamenteButton.Size = new System.Drawing.Size(114, 31);
            this.jogarNovamenteButton.TabIndex = 0;
            this.jogarNovamenteButton.Text = "Jogar Novamente";
            this.jogarNovamenteButton.UseVisualStyleBackColor = true;
            this.jogarNovamenteButton.Visible = false;
            this.jogarNovamenteButton.Click += new System.EventHandler(this.jogarNovamenteButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(162, 113);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(433, 13);
            this.resultadoLabel.TabIndex = 1;
            this.resultadoLabel.Text = "Eu pensei em um número entre 1 e 1000. Você consegue adivinhar qual é?";
            // 
            // palpiteTextBox
            // 
            this.palpiteTextBox.Location = new System.Drawing.Point(266, 141);
            this.palpiteTextBox.Name = "palpiteTextBox";
            this.palpiteTextBox.Size = new System.Drawing.Size(217, 20);
            this.palpiteTextBox.TabIndex = 2;
            // 
            // verificarButton
            // 
            this.verificarButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.verificarButton.Location = new System.Drawing.Point(105, 199);
            this.verificarButton.Name = "verificarButton";
            this.verificarButton.Size = new System.Drawing.Size(128, 23);
            this.verificarButton.TabIndex = 3;
            this.verificarButton.Text = "Verificar Resposta";
            this.verificarButton.UseVisualStyleBackColor = true;
            this.verificarButton.Click += new System.EventHandler(this.verificarButton_Click);
            // 
            // JogoAdivinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verificarButton);
            this.Controls.Add(this.palpiteTextBox);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.jogarNovamenteButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JogoAdivinha";
            this.Text = "ADIVINHE O NÚMERO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jogarNovamenteButton;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.TextBox palpiteTextBox;
        private System.Windows.Forms.Button verificarButton;
    }
}

