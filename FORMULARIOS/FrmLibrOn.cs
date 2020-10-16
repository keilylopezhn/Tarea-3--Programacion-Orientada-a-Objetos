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
    public partial class FrmLibrOn : Form
    {
        CLASES.LIBRON lb = new CLASES.LIBRON();
        public FrmLibrOn()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtLbs.Clear();
            TxtRes.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConv_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtLbs.Text);

            TxtRes.Text = lb.libra(n).ToString();
        }
    }
    }

