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
    public partial class FrmMillasaMetros : Form
    {
        CLASES.MIMETRO M = new CLASES.MIMETRO();
        public FrmMillasaMetros()
        {
            InitializeComponent();
        }

        private void BtnConv_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtMilla.Text);

            TxtRes.Text = M.mimetro(n).ToString();
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtMilla.Clear();
            TxtRes.Clear();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
