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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmSuma suma = new FORMULARIOS.FrmSuma();
            suma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmPromedio promedio = new FORMULARIOS.FrmPromedio();
            promedio.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmLempsaDolls lemdol = new FORMULARIOS.FrmLempsaDolls();
            lemdol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmMillasaMetros mimetro = new FORMULARIOS.FrmMillasaMetros();
            mimetro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmMillasaKilometros mikilo = new FORMULARIOS.FrmMillasaKilometros();
            mikilo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmLempirasaEuros lemeuro = new FORMULARIOS.FrmLempirasaEuros();
            lemeuro.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmVentaLlantas ventalla = new FORMULARIOS.FrmVentaLlantas();
            ventalla.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmSalbadia salbadia = new FORMULARIOS.FrmSalbadia();
            salbadia.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmSalHora salHora = new FORMULARIOS.FrmSalHora();
            salHora.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmGallitro gallitro = new FORMULARIOS.FrmGallitro();
            gallitro.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmPulCm pulga = new FORMULARIOS.FrmPulCm();
            pulga.Show();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmSalAum salau = new FORMULARIOS.FrmSalAum();
            salau.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmDiaMin diam = new FORMULARIOS.FrmDiaMin();
            diam.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmLibrOn libron = new FORMULARIOS.FrmLibrOn();
            libron.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmEdadPromedio edprom = new FORMULARIOS.FrmEdadPromedio();
            edprom.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmCuadrado cuad = new FORMULARIOS.FrmCuadrado();
            cuad.Show();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmCubo cubo = new FORMULARIOS.FrmCubo();
            cubo.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmDoble doble = new FORMULARIOS.FrmDoble();
            doble.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmMetroPie pie = new FORMULARIOS.FrmMetroPie();
            pie.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmConstructor consta = new FORMULARIOS.FrmConstructor();
            consta.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmAcumExa acum = new FORMULARIOS.FrmAcumExa();
            acum.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FrmSemaMin sem = new FORMULARIOS.FrmSemaMin();
            sem.Show();
        }
    }
}
