
namespace wdExchangeHouse
{
    partial class frmCasadeCambio
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpConversion = new System.Windows.Forms.GroupBox();
            this.lblValorCambiar = new System.Windows.Forms.Label();
            this.lblValorCanje = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtCambiar = new System.Windows.Forms.TextBox();
            this.txtCanje = new System.Windows.Forms.TextBox();
            this.grpTipodeMoneda = new System.Windows.Forms.GroupBox();
            this.lblMonedaOrigen = new System.Windows.Forms.Label();
            this.lblMonedaDestino = new System.Windows.Forms.Label();
            this.rdoCheque = new System.Windows.Forms.RadioButton();
            this.rdoBTC = new System.Windows.Forms.RadioButton();
            this.rdoTransferencia = new System.Windows.Forms.RadioButton();
            this.rdoEfectivo = new System.Windows.Forms.RadioButton();
            this.cmbMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.cmbMonedaDestino = new System.Windows.Forms.ComboBox();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpConversion.SuspendLayout();
            this.grpTipodeMoneda.SuspendLayout();
            this.grpDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(597, 433);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(137, 34);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir Recibo";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(376, 433);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 34);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(163, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 34);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpConversion
            // 
            this.grpConversion.Controls.Add(this.lblValorCambiar);
            this.grpConversion.Controls.Add(this.lblValorCanje);
            this.grpConversion.Controls.Add(this.btnCambiar);
            this.grpConversion.Controls.Add(this.txtCambiar);
            this.grpConversion.Controls.Add(this.txtCanje);
            this.grpConversion.Location = new System.Drawing.Point(437, 194);
            this.grpConversion.Name = "grpConversion";
            this.grpConversion.Size = new System.Drawing.Size(329, 199);
            this.grpConversion.TabIndex = 11;
            this.grpConversion.TabStop = false;
            this.grpConversion.Text = "Conversión";
            // 
            // lblValorCambiar
            // 
            this.lblValorCambiar.AutoSize = true;
            this.lblValorCambiar.Location = new System.Drawing.Point(82, 53);
            this.lblValorCambiar.Name = "lblValorCambiar";
            this.lblValorCambiar.Size = new System.Drawing.Size(81, 13);
            this.lblValorCambiar.TabIndex = 7;
            this.lblValorCambiar.Text = "Valor a Cambiar";
            // 
            // lblValorCanje
            // 
            this.lblValorCanje.AutoSize = true;
            this.lblValorCanje.Location = new System.Drawing.Point(82, 90);
            this.lblValorCanje.Name = "lblValorCanje";
            this.lblValorCanje.Size = new System.Drawing.Size(78, 13);
            this.lblValorCanje.TabIndex = 6;
            this.lblValorCanje.Text = "Valor del Canje";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(105, 133);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(97, 30);
            this.btnCambiar.TabIndex = 5;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtCambiar
            // 
            this.txtCambiar.Location = new System.Drawing.Point(169, 50);
            this.txtCambiar.Name = "txtCambiar";
            this.txtCambiar.Size = new System.Drawing.Size(128, 20);
            this.txtCambiar.TabIndex = 2;
            // 
            // txtCanje
            // 
            this.txtCanje.Location = new System.Drawing.Point(169, 88);
            this.txtCanje.Name = "txtCanje";
            this.txtCanje.Size = new System.Drawing.Size(128, 20);
            this.txtCanje.TabIndex = 1;
            // 
            // grpTipodeMoneda
            // 
            this.grpTipodeMoneda.Controls.Add(this.lblMonedaOrigen);
            this.grpTipodeMoneda.Controls.Add(this.lblMonedaDestino);
            this.grpTipodeMoneda.Controls.Add(this.rdoCheque);
            this.grpTipodeMoneda.Controls.Add(this.rdoBTC);
            this.grpTipodeMoneda.Controls.Add(this.rdoTransferencia);
            this.grpTipodeMoneda.Controls.Add(this.rdoEfectivo);
            this.grpTipodeMoneda.Controls.Add(this.cmbMonedaOrigen);
            this.grpTipodeMoneda.Controls.Add(this.cmbMonedaDestino);
            this.grpTipodeMoneda.Location = new System.Drawing.Point(35, 194);
            this.grpTipodeMoneda.Name = "grpTipodeMoneda";
            this.grpTipodeMoneda.Size = new System.Drawing.Size(345, 199);
            this.grpTipodeMoneda.TabIndex = 10;
            this.grpTipodeMoneda.TabStop = false;
            this.grpTipodeMoneda.Text = "Tipo de Moneda";
            // 
            // lblMonedaOrigen
            // 
            this.lblMonedaOrigen.AutoSize = true;
            this.lblMonedaOrigen.Location = new System.Drawing.Point(57, 53);
            this.lblMonedaOrigen.Name = "lblMonedaOrigen";
            this.lblMonedaOrigen.Size = new System.Drawing.Size(95, 13);
            this.lblMonedaOrigen.TabIndex = 12;
            this.lblMonedaOrigen.Text = "Moneda de Origen";
            // 
            // lblMonedaDestino
            // 
            this.lblMonedaDestino.AutoSize = true;
            this.lblMonedaDestino.Location = new System.Drawing.Point(57, 90);
            this.lblMonedaDestino.Name = "lblMonedaDestino";
            this.lblMonedaDestino.Size = new System.Drawing.Size(85, 13);
            this.lblMonedaDestino.TabIndex = 11;
            this.lblMonedaDestino.Text = "Moneda Destino";
            // 
            // rdoCheque
            // 
            this.rdoCheque.AutoSize = true;
            this.rdoCheque.Location = new System.Drawing.Point(60, 156);
            this.rdoCheque.Name = "rdoCheque";
            this.rdoCheque.Size = new System.Drawing.Size(62, 17);
            this.rdoCheque.TabIndex = 10;
            this.rdoCheque.TabStop = true;
            this.rdoCheque.Text = "Cheque";
            this.rdoCheque.UseVisualStyleBackColor = true;
            // 
            // rdoBTC
            // 
            this.rdoBTC.AutoSize = true;
            this.rdoBTC.Location = new System.Drawing.Point(166, 156);
            this.rdoBTC.Name = "rdoBTC";
            this.rdoBTC.Size = new System.Drawing.Size(46, 17);
            this.rdoBTC.TabIndex = 9;
            this.rdoBTC.TabStop = true;
            this.rdoBTC.Text = "BTC";
            this.rdoBTC.UseVisualStyleBackColor = true;
            // 
            // rdoTransferencia
            // 
            this.rdoTransferencia.AutoSize = true;
            this.rdoTransferencia.Location = new System.Drawing.Point(166, 133);
            this.rdoTransferencia.Name = "rdoTransferencia";
            this.rdoTransferencia.Size = new System.Drawing.Size(90, 17);
            this.rdoTransferencia.TabIndex = 8;
            this.rdoTransferencia.TabStop = true;
            this.rdoTransferencia.Text = "Transferencia";
            this.rdoTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdoEfectivo
            // 
            this.rdoEfectivo.AutoSize = true;
            this.rdoEfectivo.Location = new System.Drawing.Point(60, 133);
            this.rdoEfectivo.Name = "rdoEfectivo";
            this.rdoEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdoEfectivo.TabIndex = 7;
            this.rdoEfectivo.TabStop = true;
            this.rdoEfectivo.Text = "Efectivo";
            this.rdoEfectivo.UseVisualStyleBackColor = true;
            // 
            // cmbMonedaOrigen
            // 
            this.cmbMonedaOrigen.FormattingEnabled = true;
            this.cmbMonedaOrigen.Location = new System.Drawing.Point(166, 49);
            this.cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            this.cmbMonedaOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaOrigen.TabIndex = 6;
            // 
            // cmbMonedaDestino
            // 
            this.cmbMonedaDestino.FormattingEnabled = true;
            this.cmbMonedaDestino.Location = new System.Drawing.Point(166, 87);
            this.cmbMonedaDestino.Name = "cmbMonedaDestino";
            this.cmbMonedaDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaDestino.TabIndex = 5;
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.lblName);
            this.grpDatosPersonales.Controls.Add(this.lblDireccion);
            this.grpDatosPersonales.Controls.Add(this.lblCity);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.lblApellido);
            this.grpDatosPersonales.Controls.Add(this.cmbCiudad);
            this.grpDatosPersonales.Controls.Add(this.txtDireccion);
            this.grpDatosPersonales.Controls.Add(this.txtApellido);
            this.grpDatosPersonales.Controls.Add(this.txtTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(35, -17);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(731, 179);
            this.grpDatosPersonales.TabIndex = 9;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(27, 90);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(27, 129);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "Ciudad";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(375, 90);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(375, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(114, 121);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 87);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(431, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(431, 87);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // frmCasadeCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 513);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpConversion);
            this.Controls.Add(this.grpTipodeMoneda);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "frmCasadeCambio";
            this.Text = "Casa de cambio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCasadeCambio_FormClosed);
            this.grpConversion.ResumeLayout(false);
            this.grpConversion.PerformLayout();
            this.grpTipodeMoneda.ResumeLayout(false);
            this.grpTipodeMoneda.PerformLayout();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpConversion;
        private System.Windows.Forms.Label lblValorCambiar;
        private System.Windows.Forms.Label lblValorCanje;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtCambiar;
        private System.Windows.Forms.TextBox txtCanje;
        private System.Windows.Forms.GroupBox grpTipodeMoneda;
        private System.Windows.Forms.Label lblMonedaOrigen;
        private System.Windows.Forms.Label lblMonedaDestino;
        private System.Windows.Forms.RadioButton rdoCheque;
        private System.Windows.Forms.RadioButton rdoBTC;
        private System.Windows.Forms.RadioButton rdoTransferencia;
        private System.Windows.Forms.RadioButton rdoEfectivo;
        private System.Windows.Forms.ComboBox cmbMonedaOrigen;
        private System.Windows.Forms.ComboBox cmbMonedaDestino;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

