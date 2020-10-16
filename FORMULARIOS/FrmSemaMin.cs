using Programacion_Orientada_a_Objetos.CLASES;
using System;
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
  
    public partial class FrmSemaMin : Form
    {
        CLASES.SEMINU x = new  CLASES.SEMINU();
        public FrmSemaMin()
        {
            InitializeComponent();
        }

        private void BtnConv_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtDias.Text);

            TxtRes.Text = x . semana(n).ToString();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtDias.Clear();
            TxtRes.Clear();
        }
    }
}
