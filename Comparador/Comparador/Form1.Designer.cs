namespace Comparador
{
    partial class Comparador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comparador));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblBancos = new System.Windows.Forms.Label();
            this.chkGalicia = new System.Windows.Forms.CheckBox();
            this.chkHSBC = new System.Windows.Forms.CheckBox();
            this.chkNacion = new System.Windows.Forms.CheckBox();
            this.chkMacro = new System.Windows.Forms.CheckBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbt365dias = new System.Windows.Forms.RadioButton();
            this.rbt180dias = new System.Windows.Forms.RadioButton();
            this.rbt90dias = new System.Windows.Forms.RadioButton();
            this.rbt60dias = new System.Windows.Forms.RadioButton();
            this.rbt30dias = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto a invertir";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(47, 73);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(129, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // lblBancos
            // 
            this.lblBancos.AutoSize = true;
            this.lblBancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancos.Location = new System.Drawing.Point(344, 158);
            this.lblBancos.Name = "lblBancos";
            this.lblBancos.Size = new System.Drawing.Size(67, 20);
            this.lblBancos.TabIndex = 8;
            this.lblBancos.Text = "Bancos ";
            // 
            // chkGalicia
            // 
            this.chkGalicia.AutoSize = true;
            this.chkGalicia.Location = new System.Drawing.Point(348, 196);
            this.chkGalicia.Name = "chkGalicia";
            this.chkGalicia.Size = new System.Drawing.Size(58, 17);
            this.chkGalicia.TabIndex = 9;
            this.chkGalicia.Text = "Galicia";
            this.chkGalicia.UseVisualStyleBackColor = true;
            // 
            // chkHSBC
            // 
            this.chkHSBC.AutoSize = true;
            this.chkHSBC.Location = new System.Drawing.Point(348, 226);
            this.chkHSBC.Name = "chkHSBC";
            this.chkHSBC.Size = new System.Drawing.Size(55, 17);
            this.chkHSBC.TabIndex = 10;
            this.chkHSBC.Text = "HSBC";
            this.chkHSBC.UseVisualStyleBackColor = true;
            // 
            // chkNacion
            // 
            this.chkNacion.AutoSize = true;
            this.chkNacion.Location = new System.Drawing.Point(348, 259);
            this.chkNacion.Name = "chkNacion";
            this.chkNacion.Size = new System.Drawing.Size(60, 17);
            this.chkNacion.TabIndex = 11;
            this.chkNacion.Text = "Nación";
            this.chkNacion.UseVisualStyleBackColor = true;
            // 
            // chkMacro
            // 
            this.chkMacro.AutoSize = true;
            this.chkMacro.Location = new System.Drawing.Point(348, 291);
            this.chkMacro.Name = "chkMacro";
            this.chkMacro.Size = new System.Drawing.Size(56, 17);
            this.chkMacro.TabIndex = 12;
            this.chkMacro.Text = "Macro";
            this.chkMacro.UseVisualStyleBackColor = true;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(348, 324);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 13;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(699, 181);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 61);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(699, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 61);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 109);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(182, 80);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(186, 12);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "* Debe ingresar un monto válido.";
            this.lblError.Visible = false;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(417, 165);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(222, 12);
            this.lblError2.TabIndex = 19;
            this.lblError2.Text = "* Debe seleccionar al menos un banco.";
            this.lblError2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plazo de tu inversión";
            // 
            // rbt365dias
            // 
            this.rbt365dias.AutoSize = true;
            this.rbt365dias.Location = new System.Drawing.Point(54, 291);
            this.rbt365dias.Name = "rbt365dias";
            this.rbt365dias.Size = new System.Drawing.Size(121, 17);
            this.rbt365dias.TabIndex = 7;
            this.rbt365dias.TabStop = true;
            this.rbt365dias.Text = "Plazo fijo a 365 días";
            this.rbt365dias.UseVisualStyleBackColor = true;
            // 
            // rbt180dias
            // 
            this.rbt180dias.AutoSize = true;
            this.rbt180dias.Location = new System.Drawing.Point(54, 269);
            this.rbt180dias.Name = "rbt180dias";
            this.rbt180dias.Size = new System.Drawing.Size(121, 17);
            this.rbt180dias.TabIndex = 4;
            this.rbt180dias.TabStop = true;
            this.rbt180dias.Text = "Plazo fijo a 180 días";
            this.rbt180dias.UseVisualStyleBackColor = true;
            // 
            // rbt90dias
            // 
            this.rbt90dias.AutoSize = true;
            this.rbt90dias.Location = new System.Drawing.Point(54, 246);
            this.rbt90dias.Name = "rbt90dias";
            this.rbt90dias.Size = new System.Drawing.Size(115, 17);
            this.rbt90dias.TabIndex = 5;
            this.rbt90dias.TabStop = true;
            this.rbt90dias.Text = "Plazo fijo a 90 días";
            this.rbt90dias.UseVisualStyleBackColor = true;
            // 
            // rbt60dias
            // 
            this.rbt60dias.AutoSize = true;
            this.rbt60dias.Location = new System.Drawing.Point(54, 223);
            this.rbt60dias.Name = "rbt60dias";
            this.rbt60dias.Size = new System.Drawing.Size(115, 17);
            this.rbt60dias.TabIndex = 6;
            this.rbt60dias.TabStop = true;
            this.rbt60dias.Text = "Plazo fijo a 60 días";
            this.rbt60dias.UseVisualStyleBackColor = true;
            // 
            // rbt30dias
            // 
            this.rbt30dias.AutoSize = true;
            this.rbt30dias.Checked = true;
            this.rbt30dias.Location = new System.Drawing.Point(54, 200);
            this.rbt30dias.Name = "rbt30dias";
            this.rbt30dias.Size = new System.Drawing.Size(115, 17);
            this.rbt30dias.TabIndex = 2;
            this.rbt30dias.TabStop = true;
            this.rbt30dias.Text = "Plazo fijo a 30 días";
            this.rbt30dias.UseVisualStyleBackColor = true;
            // 
            // Comparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.rbt365dias);
            this.Controls.Add(this.rbt180dias);
            this.Controls.Add(this.rbt90dias);
            this.Controls.Add(this.rbt60dias);
            this.Controls.Add(this.rbt30dias);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.chkMacro);
            this.Controls.Add(this.chkNacion);
            this.Controls.Add(this.chkHSBC);
            this.Controls.Add(this.chkGalicia);
            this.Controls.Add(this.lblBancos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Comparador";
            this.Text = "Comparador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblBancos;
        private System.Windows.Forms.CheckBox chkGalicia;
        private System.Windows.Forms.CheckBox chkHSBC;
        private System.Windows.Forms.CheckBox chkNacion;
        private System.Windows.Forms.CheckBox chkMacro;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbt365dias;
        private System.Windows.Forms.RadioButton rbt180dias;
        private System.Windows.Forms.RadioButton rbt90dias;
        private System.Windows.Forms.RadioButton rbt60dias;
        private System.Windows.Forms.RadioButton rbt30dias;
    }
}

