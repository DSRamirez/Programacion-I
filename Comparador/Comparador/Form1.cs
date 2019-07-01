using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparador
{

    public partial class Comparador : Form

    {

        Double VMonto;
        Double VPlazo;

        public Comparador()
        {

            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            if (rbt30dias.Checked)
            {
                Double VTasaGalicia;
                Double VTasaHSBC;
                Double VTasaMacro;
                Double VTasaNacion;

                VTasaGalicia = (VMonto * (21.94 / 365 * 30 / 100) + VMonto);
                VTasaHSBC = (VMonto * (23 / 365 * 30 / 100) + VMonto);
                VTasaMacro = (VMonto * (22.50 / 365 * 30 / 100) + VMonto);
                VTasaNacion = (VMonto * (25 / 365 * 30 / 100) + VMonto);

                // if (chkGalicia.Checked)
                // {
                //     (VMonto * (21.94 / 365 * 30 / 100) + VMonto);
                //}
            }
            if (rbt60dias.Checked)
            {
                VPlazo = 60;
            }
            if (rbt90dias.Checked)
            {
                VPlazo = 90;
            }

            if (rbt180dias.Checked)
            {
                VPlazo = 180;
            }

            if (rbt365dias.Checked)
            {
                VPlazo = 365;
            }

            if (txtMonto.Text != "")
            {
                VMonto = Convert.ToInt32(txtMonto.Text);
                lblError.Visible = false;
                MessageBox.Show("El monto ingresado es: " + VMonto );

            }
            if (txtMonto.Text == "")
            {
                lblError.Visible = true;
            }

        }
    }
}
