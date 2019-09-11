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
        Double VTasaGalicia;
        Double VTasaHSBC;
        Double VTasaMacro;
        Double VTasaNacion;

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
            if (txtMonto.Text == "")
            {
                lblError.Visible = true;
            }
            else
            {
                VMonto = Convert.ToInt32(txtMonto.Text);
                lblError.Visible = false;
                txtMonto.Enabled = false;

            }

            if (rbt30dias.Checked)
            {

                VTasaGalicia = VMonto * (36.3 / 365 * 30 / 100) + VMonto;
                VTasaHSBC = VMonto * 38 / 365 * 30 / 100 + VMonto;
                VTasaMacro = VMonto * (37.5 / 365 * 30 / 100) + VMonto;
                VTasaNacion = VMonto * 40 / 365 * 30 / 100 + VMonto;

                if (chkGalicia.Checked)
                {
                    lblG.Visible = true;
                    lblG.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaGalicia * 100) / 100);
                }
                else
                {
                    lblG.Visible = false;
                }

                    if (chkHSBC.Checked)
                    {
                        lblH.Visible = true;
                        lblH.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaHSBC * 100) / 100);
                    }
                    else
                    {
                        lblH.Visible = false;
                    }

                    if (chkMacro.Checked)
                    {
                        lblM.Visible = true;
                        lblM.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaMacro * 100) / 100);
                    }
                    else
                    {
                        lblM.Visible = false;
                    }

                    if (chkNacion.Checked)
                    {
                        lblN.Visible = true;
                        lblN.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaNacion * 100) / 100);
                    }
                    else
                    {
                        lblN.Visible = false;
                    }

            }
            if (rbt60dias.Checked)
            {
                VTasaGalicia = VMonto * 23 / 365 * 60 / 100 + VMonto;
                VTasaHSBC = VMonto * 24 / 365 * 60 / 100 + VMonto;
                VTasaMacro = VMonto * 24.3 / 365 * 60 / 100 + VMonto;
                VTasaNacion = VMonto * 22 / 365 * 60 / 100 + VMonto;

                if (chkGalicia.Checked)
                {
                    lblG.Visible = true;
                    lblG.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaGalicia * 100) / 100);

                    if (chkHSBC.Checked)
                    {
                        lblH.Visible = true;
                        lblH.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaHSBC * 100) / 100);
                    }

                    if (chkMacro.Checked)
                    {
                        lblM.Visible = true;
                        lblM.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaMacro * 100) / 100);
                    }

                    if (chkNacion.Checked)
                    {
                        lblN.Visible = true;
                        lblN.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaNacion * 100) / 100);
                    }
                }
            }
            if (rbt90dias.Checked)
            {
                VTasaGalicia = VMonto * 22.5 / 365 * 90 / 100 + VMonto;
                VTasaHSBC = VMonto * 23.2 / 365 * 90 / 100 + VMonto;
                VTasaMacro = VMonto * 23 / 365 * 90 / 100 + VMonto;
                VTasaNacion = VMonto * 24 / 365 * 90 / 100 + VMonto;

                if (chkGalicia.Checked)
                {
                    lblG.Visible = true;
                    lblG.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaGalicia * 100) / 100);

                    if (chkHSBC.Checked)
                    {
                        lblH.Visible = true;
                        lblH.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaHSBC * 100) / 100);
                    }

                    if (chkMacro.Checked)
                    {
                        lblM.Visible = true;
                        lblM.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaMacro * 100) / 100);
                    }

                    if (chkNacion.Checked)
                    {
                        lblN.Visible = true;
                        lblN.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaNacion * 100) / 100);
                    }
                }
            }

            if (rbt180dias.Checked)
            {
                VTasaGalicia = VMonto * 35 / 365 * 180 / 100 + VMonto;
                VTasaHSBC = VMonto * 34 / 365 * 180 / 100 + VMonto;
                VTasaMacro = VMonto * 33.8 / 365 * 180 / 100 + VMonto;
                VTasaNacion = VMonto * 35.1 / 365 * 180 / 100 + VMonto;

                if (chkGalicia.Checked)
                {
                    lblG.Visible = true;
                    lblG.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaGalicia * 100) / 100 );

                    if (chkHSBC.Checked)
                    {
                        lblH.Visible = true;
                        lblH.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaHSBC * 100) / 100);
                    }

                    if (chkMacro.Checked)
                    {
                        lblM.Visible = true;
                        lblM.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaMacro * 100) / 100);
                    }

                    if (chkNacion.Checked)
                    {
                        lblN.Visible = true;
                        lblN.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaNacion * 100) / 100);
                    }
                }
            }

            if (rbt365dias.Checked)
            {
                VTasaGalicia = VMonto * 45 / 365 * 365 / 100 + VMonto;
                VTasaHSBC = VMonto * 44.8 / 365 * 365 / 100 + VMonto;
                VTasaMacro = VMonto * 43.9/ 365 * 365 / 100 + VMonto;
                VTasaNacion = VMonto * 45.2 / 365 * 365 / 100 + VMonto;

                if (chkGalicia.Checked)
                {
                    lblG.Visible = true;
                    lblG.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaGalicia * 100) / 100);

                    if (chkHSBC.Checked)
                    {
                        lblH.Visible = true;
                        lblH.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaHSBC * 100) / 100);
                    }

                    if (chkMacro.Checked)
                    {
                        lblM.Visible = true;
                        lblM.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaMacro * 100) / 100);
                    }

                    if (chkNacion.Checked)
                    {
                        lblN.Visible = true;
                        lblN.Text = " El interes ganado es: " + Convert.ToString(Math.Truncate(VTasaNacion * 100) / 100);
                    }
                }
            }

            if (chkGalicia.Checked | chkHSBC.Checked | chkMacro.Checked | chkNacion.Checked)
            {
                lblError2.Visible = false;

                Convert.ToDouble(VTasaGalicia);
                Convert.ToDouble(VTasaHSBC);
                Convert.ToDouble(VTasaMacro);
                Convert.ToDouble(VTasaNacion);

                if (VTasaGalicia > VTasaHSBC && VTasaGalicia > VTasaMacro && VTasaGalicia > VTasaNacion)
                {
                    //chkGalicia.Checked && 
                    MessageBox.Show("El banco que te conviene es: GALICIA ");

                }

                if (VTasaHSBC > VTasaGalicia && VTasaHSBC > VTasaMacro && VTasaHSBC > VTasaNacion)
                {
                    //chkHSBC.Checked &&
                    MessageBox.Show("El banco que te conviene es: HSBC ");
                }

                if (VTasaMacro > VTasaGalicia && VTasaMacro > VTasaHSBC && VTasaMacro > VTasaNacion)
                {
                    //chkMacro.Checked && 
                    MessageBox.Show("El banco que te conviene es: MACRO ");
                }

                if (VTasaNacion > VTasaGalicia && VTasaNacion > VTasaHSBC && VTasaNacion > VTasaMacro)
                {
                    //chkNacion.Checked && 
                    MessageBox.Show("El banco que te conviene es: NACIÓN ");
                }



                //if (chkGalicia.Checked && VTasaGalicia > VTasaHSBC && VTasaGalicia > VTasaMacro && VTasaGalicia > VTasaNacion)
                //{
                //    MessageBox.Show("El banco que te conviene es: GALICIA ");
                //}
                //else
                //{
                //    if (chkHSBC.Checked && VTasaHSBC > VTasaGalicia && VTasaHSBC > VTasaMacro && VTasaHSBC > VTasaNacion)
                //    {
                //        MessageBox.Show("El banco que te conviene es: HSBC ");
                //    }
                //    else
                //    {
                //        if (chkMacro.Checked && VTasaMacro > VTasaGalicia && VTasaMacro > VTasaHSBC && VTasaMacro > VTasaNacion)
                //        {
                //            MessageBox.Show("El banco que te conviene es: MACRO ");
                //        }
                //        else
                //        {
                //            if (chkNacion.Checked && VTasaNacion > VTasaGalicia && VTasaNacion > VTasaHSBC && VTasaNacion > VTasaMacro)
                //            {
                //                MessageBox.Show("El banco que te conviene es: NACIÓN ");
                //            }
                //        }
                //    }
                //}

            }
            else
            {
                lblError2.Visible = true;
            }
        }

        //private void TextBox1_Click_1(object sender, EventArgs e)
        //{
        //    if (txtMonto.Enabled == false)
        //    {
        //        MessageBox.Show("¿Desea ingresar otro monto?", "Atencion", MessageBoxButtons.YesNo);
        //        DialogResult = DialogResult;
        //    }
        //    if (DialogResult == DialogResult.Yes)
        //    {
        //        txtMonto.Text = "";
        //        chkGalicia.Checked = false;
        //        chkHSBC.Checked = false;
        //        chkMacro.Checked = false;
        //        chkNacion.Checked = false;
        //        lblG.Visible = false;
        //        lblH.Visible = false;
        //        lblM.Visible = false;
        //        lblN.Visible = false;
        //        txtMonto.Enabled = true;
        //    }
        }
    }


