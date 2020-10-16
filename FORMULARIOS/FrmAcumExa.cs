﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Orientada_a_Objetos.FORMULARIOS
{
    public partial class FrmAcumExa : Form
    {
        CLASES.ACUEXA acue = new CLASES.ACUEXA();
        public FrmAcumExa()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtAcum.Clear();
            TxtExa.Clear();
            TxtSal.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtAcum.Text);
            double r = Convert.ToDouble(TxtExa.Text);

            TxtSal.Text = acue.tot(n, r).ToString();
        }
    }
}
