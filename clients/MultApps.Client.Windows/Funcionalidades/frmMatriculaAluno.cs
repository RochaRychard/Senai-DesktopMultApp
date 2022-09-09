using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Client.Windows.Funcionalidades
{
    public partial class frmMatriculaAluno : Form
    { 
        public frmMatriculaAluno()
        {
            InitializeComponent();
            lblHoje.Text = "Hoje é " +
            DateTime.Now.ToShortDateString();

        }

        private void frmMatriculaAluno_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void frmMatriculaAluno_Click(object sender, EventArgs e)
        {

        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            /* if (txtNome.Text == String.Empty ||
                 txtAnoNascimento.Text == String.Empty ||
                 txtAnoUltimoAniversario.Text == String.Empty)
             {
                 MessageBox.Show("Todos os dados " +
                 "solicitados devem ser informados.",
                 "Atenção!", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
             }
             else
             {*/
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpDataDeNascimento.Value;
                int idade = (tsQuantidadeDias.Days / 365);

            ///int idade =
               /// Convert.ToInt32(txtAnoUltimoAniversario.Text);
               /// Convert.ToInt32(txtAnoNascimento.Text);
                if (idade > 17)
                {
                    lblCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblCategoria.Text = "Infantil B";
                }
                else if (idade >= 5)
                {
                    lblCategoria.Text = "Infantil A";
                }
                else
                {
                    lblCategoria.Text = "Não existe categoria";
                }
        }

            // Trecho para validação do nome continua o mesmo e
            // foi omitido aqui
           
            // Considerar o ano com 365 dias pode não resultar
            // em um valor preciso
            // Trecho para identificação das categorias continua o
            // mesmo e foi omitido aqui
        
    }
}



