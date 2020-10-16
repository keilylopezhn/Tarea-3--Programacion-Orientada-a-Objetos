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
    public partial class FrmMetroPie : Form
    {
        CLASES.METROOPIE metro = new CLASES.METROOPIE();
        public FrmMetroPie()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNum.Clear();
            TxtRes.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConv_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtNum.Text);

            TxtRes.Text = metro.metropie(n).ToString();
        }

        private void FrmMetroPie_Load(object sender, EventArgs e)
        {
          

        }
    }
}
