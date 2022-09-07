namespace MultApps.Client.Windows.Funcionalidades
{
    partial class frmMatriculaAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblanoNascimento = new System.Windows.Forms.Label();
            this.txtanoNascimento = new System.Windows.Forms.TextBox();
            this.lblanoUltimoAniversario = new System.Windows.Forms.Label();
            this.txtanoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.btnidentificarCategoria = new System.Windows.Forms.Button();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblrespostaCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(61, 21);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(338, 23);
            this.txtnome.TabIndex = 1;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(12, 24);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(43, 15);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome:";
            // 
            // lblanoNascimento
            // 
            this.lblanoNascimento.AutoSize = true;
            this.lblanoNascimento.Location = new System.Drawing.Point(12, 78);
            this.lblanoNascimento.Name = "lblanoNascimento";
            this.lblanoNascimento.Size = new System.Drawing.Size(99, 15);
            this.lblanoNascimento.TabIndex = 3;
            this.lblanoNascimento.Text = "Ano Nascimento:";
            // 
            // txtanoNascimento
            // 
            this.txtanoNascimento.Location = new System.Drawing.Point(117, 75);
            this.txtanoNascimento.Name = "txtanoNascimento";
            this.txtanoNascimento.Size = new System.Drawing.Size(65, 23);
            this.txtanoNascimento.TabIndex = 4;
            // 
            // lblanoUltimoAniversario
            // 
            this.lblanoUltimoAniversario.AutoSize = true;
            this.lblanoUltimoAniversario.Location = new System.Drawing.Point(199, 78);
            this.lblanoUltimoAniversario.Name = "lblanoUltimoAniversario";
            this.lblanoUltimoAniversario.Size = new System.Drawing.Size(130, 15);
            this.lblanoUltimoAniversario.TabIndex = 5;
            this.lblanoUltimoAniversario.Text = "Ano último aniversário:";
            // 
            // txtanoUltimoAniversario
            // 
            this.txtanoUltimoAniversario.Location = new System.Drawing.Point(335, 75);
            this.txtanoUltimoAniversario.Name = "txtanoUltimoAniversario";
            this.txtanoUltimoAniversario.Size = new System.Drawing.Size(64, 23);
            this.txtanoUltimoAniversario.TabIndex = 6;
            // 
            // btnidentificarCategoria
            // 
            this.btnidentificarCategoria.Location = new System.Drawing.Point(14, 136);
            this.btnidentificarCategoria.Name = "btnidentificarCategoria";
            this.btnidentificarCategoria.Size = new System.Drawing.Size(131, 36);
            this.btnidentificarCategoria.TabIndex = 7;
            this.btnidentificarCategoria.Text = "Identificar Categotia";
            this.btnidentificarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(176, 147);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(61, 15);
            this.lblcategoria.TabIndex = 8;
            this.lblcategoria.Text = "Categoria:";
            // 
            // lblrespostaCategoria
            // 
            this.lblrespostaCategoria.AutoSize = true;
            this.lblrespostaCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblrespostaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblrespostaCategoria.Location = new System.Drawing.Point(243, 147);
            this.lblrespostaCategoria.Name = "lblrespostaCategoria";
            this.lblrespostaCategoria.Size = new System.Drawing.Size(2, 17);
            this.lblrespostaCategoria.TabIndex = 9;
            this.lblrespostaCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 187);
            this.Controls.Add(this.lblrespostaCategoria);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.btnidentificarCategoria);
            this.Controls.Add(this.txtanoUltimoAniversario);
            this.Controls.Add(this.lblanoUltimoAniversario);
            this.Controls.Add(this.txtanoNascimento);
            this.Controls.Add(this.lblanoNascimento);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Name = "frmMatriculaAluno";
            this.Text = "frmMatriculaAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtnome;
        private Label lblnome;
        private Label lblanoNascimento;
        private TextBox txtanoNascimento;
        private Label lblanoUltimoAniversario;
        private TextBox txtanoUltimoAniversario;
        private Button btnidentificarCategoria;
        private Label lblcategoria;
        private Label lblrespostaCategoria;
    }
}