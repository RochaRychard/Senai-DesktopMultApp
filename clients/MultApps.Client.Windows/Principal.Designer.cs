namespace MultApps.Client.Windows
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnAbrirFormPesoIdeal = new System.Windows.Forms.Button();
            this.btnAbrirFormMatriculaAluno = new System.Windows.Forms.Button();
            this.btnAbrirFormReajusteSalarial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirFormPesoIdeal
            // 
            this.btnAbrirFormPesoIdeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirFormPesoIdeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormPesoIdeal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormPesoIdeal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirFormPesoIdeal.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormPesoIdeal.Image")));
            this.btnAbrirFormPesoIdeal.Location = new System.Drawing.Point(24, 12);
            this.btnAbrirFormPesoIdeal.Name = "btnAbrirFormPesoIdeal";
            this.btnAbrirFormPesoIdeal.Size = new System.Drawing.Size(117, 98);
            this.btnAbrirFormPesoIdeal.TabIndex = 0;
            this.btnAbrirFormPesoIdeal.Text = "Peso Ideal";
            this.btnAbrirFormPesoIdeal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormPesoIdeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormPesoIdeal.UseVisualStyleBackColor = true;
            this.btnAbrirFormPesoIdeal.Click += new System.EventHandler(this.btnAbrirFormPesoIdeal_Click);
            // 
            // btnAbrirFormMatriculaAluno
            // 
            this.btnAbrirFormMatriculaAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirFormMatriculaAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormMatriculaAluno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormMatriculaAluno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirFormMatriculaAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormMatriculaAluno.Image")));
            this.btnAbrirFormMatriculaAluno.Location = new System.Drawing.Point(173, 12);
            this.btnAbrirFormMatriculaAluno.Name = "btnAbrirFormMatriculaAluno";
            this.btnAbrirFormMatriculaAluno.Size = new System.Drawing.Size(117, 98);
            this.btnAbrirFormMatriculaAluno.TabIndex = 1;
            this.btnAbrirFormMatriculaAluno.Text = "Matrícula de Aluno";
            this.btnAbrirFormMatriculaAluno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormMatriculaAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormMatriculaAluno.UseVisualStyleBackColor = true;
            this.btnAbrirFormMatriculaAluno.Click += new System.EventHandler(this.btnAbrirFormMatriculaAluno_Click);
            // 
            // btnAbrirFormReajusteSalarial
            // 
            this.btnAbrirFormReajusteSalarial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirFormReajusteSalarial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFormReajusteSalarial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirFormReajusteSalarial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbrirFormReajusteSalarial.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFormReajusteSalarial.Image")));
            this.btnAbrirFormReajusteSalarial.Location = new System.Drawing.Point(331, 12);
            this.btnAbrirFormReajusteSalarial.Name = "btnAbrirFormReajusteSalarial";
            this.btnAbrirFormReajusteSalarial.Size = new System.Drawing.Size(117, 98);
            this.btnAbrirFormReajusteSalarial.TabIndex = 2;
            this.btnAbrirFormReajusteSalarial.Text = "Reajuste Salarial";
            this.btnAbrirFormReajusteSalarial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFormReajusteSalarial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFormReajusteSalarial.UseVisualStyleBackColor = true;
            this.btnAbrirFormReajusteSalarial.Click += new System.EventHandler(this.btnAbrirFormReajusteSalarial_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(470, 126);
            this.Controls.Add(this.btnAbrirFormReajusteSalarial);
            this.Controls.Add(this.btnAbrirFormMatriculaAluno);
            this.Controls.Add(this.btnAbrirFormPesoIdeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultApps";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbrirFormPesoIdeal;
        private Button btnAbrirFormMatriculaAluno;
        private Button btnAbrirFormReajusteSalarial;
    }
}