﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Client.Windows.Funcionalidades
{

    public partial class frmPesoIdeal : Form
    {
        RadioButton rbnSelecionado = null;
        public frmPesoIdeal()
        {
            InitializeComponent();
        }
        
        private void SetPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double pesoIdeal;

                var rbnSelecionado = gbxSexo.Controls.OfType<RadioButton>().
                SingleOrDefault(r => r.Checked == true);

                if (rbnSelecionado.Text.Equals("Masculino"))
                    pesoIdeal = (72.7 * altura) - 58;
                else
                    pesoIdeal = (62.1 * altura) - 44.7;
                    lblPesoIdealResposta.Text = pesoIdeal.ToString("N");
            }
            catch (Exception e)
            {
                MessageBox.Show("Selecione o sexo e informe a altura corretamente", "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPesoIdeal_Load(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
           
            SetPesoIdeal();
        }
    }


}

