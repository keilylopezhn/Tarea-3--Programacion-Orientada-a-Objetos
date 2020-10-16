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
    
    public partial class FrmEdadPromedio : Form
    {
        CLASES.EDADPROMEDIO Y =new CLASES.EDADPROMEDIO();
        public FrmEdadPromedio()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("INGRESE EL NOMBRE D");
                TxtNombre.Focus();
                return;
            }
            if (TxtEdad.Text.Trim().Length == 0)
            {
                MessageBox.Show("INGRESE LA EDAD");
                TxtEdad.Focus();
                return;
            }


            double p;


            p = Convert.ToDouble(TxtEdad.Text.Trim());

            LsbNombre.Items.Add(TxtNombre.Text.Trim());
            LsbEdad.Items.Add(TxtEdad.Text.Trim());

            


        }

      
    }

    
}
