using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Fecha: 18/04/2022 at 12:00 pm
/// Autores: Maicol Arroyave Alvarez, Oscar David Ramos, Sara Daniela Parra Betancur, Natalia Usuga Manco
/// Descripción: casa de cambio
/// </summary>

namespace wdExchangeHouse
{
    public partial class frmCasadeCambio : Form
    {
        public frmCasadeCambio()
        {
            InitializeComponent();

            cmbCiudad.Items.Add("New York");
            cmbCiudad.Items.Add("Medellin");
            cmbCiudad.Items.Add("Los Angeles");
            cmbCiudad.Items.Add("Monteria");
            cmbCiudad.Items.Add("Bogota");
            cmbCiudad.Items.Add("Barranquilla");
            cmbCiudad.Items.Add("Madrid");
            cmbCiudad.Items.Add("Barcelona");
            cmbCiudad.Items.Add("Orlando");
            cmbCiudad.Items.Add("Cali");

            cmbMonedaDestino.Items.Add("Euro");
            cmbMonedaDestino.Items.Add("Peso Mexicano");
            cmbMonedaDestino.Items.Add("Peso Colombiano");
            cmbMonedaDestino.Items.Add("Dolar");


            cmbMonedaOrigen.Items.Add("Euro");
            cmbMonedaOrigen.Items.Add("Peso Mexicano");
            cmbMonedaOrigen.Items.Add("Peso Colombiano");
            cmbMonedaOrigen.Items.Add("Dolar");



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Realmente deseas salir?", "Confirmacion",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void frmCasadeCambio_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Realmente deseas salir?", "Confirmacion",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            double cantidadCambio;
            string Cantidadcambio = txtCambiar.Text;
            cantidadCambio = Convert.ToDouble(Cantidadcambio);
            String monedaOrigen = cmbMonedaOrigen.Text;
            string monedaDestino = cmbMonedaDestino.Text;


            if (monedaOrigen == "Dolar" & monedaDestino == "Peso Colombiano")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double dolar = 3732;

                valorFinal = valorInicial * dolar;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Dolar" & monedaDestino == "Peso Mexicano")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double dolar = 19.82;

                valorFinal = valorInicial * dolar;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Dolar" & monedaDestino == "Euro")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double dolar = 0.93;

                valorFinal = valorInicial * dolar;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Peso Colombiano" & monedaDestino == "Dolar")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double dolar = 3732;

                valorFinal = valorInicial / dolar;
                txtCanje.Text = Convert.ToString(valorFinal);

            }
            if (monedaOrigen == "Peso Colombiano" & monedaDestino == "Euro")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double euro = 4022;

                valorFinal = valorInicial / euro;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Peso Colombiano" & monedaDestino == "Peso Mexicano")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double pMexicano = 188.30;

                valorFinal = valorInicial / pMexicano;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Euro" & monedaDestino == "Peso Colombiano")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double euro = 3732;

                valorFinal = valorInicial * euro;
                txtCanje.Text = Convert.ToString(valorFinal);

            }
            if (monedaOrigen == "Euro" & monedaDestino == "Dolar")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double euro = 0.93;

                valorFinal = valorInicial / euro;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Euro" & monedaDestino == "Peso Mexicano")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double euro = 21.36;

                valorFinal = valorInicial * euro;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Peso Mexicano" & monedaDestino == "Euro")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double euro = 21.36;

                valorFinal = valorInicial / euro;
                txtCanje.Text = Convert.ToString(valorFinal);

            }
            if (monedaOrigen == "Peso Mexicano" & monedaDestino == "Peso Colombiano")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double pMexicano = 188.30;

                valorFinal = valorInicial * pMexicano;
                txtCanje.Text = Convert.ToString(valorFinal);

            }


            if (monedaOrigen == "Peso Mexicano" & monedaDestino == "Dolar")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal;
                double dolar = 19.82;

                valorFinal = valorInicial / dolar;
                txtCanje.Text = Convert.ToString(valorFinal);

            }


            if (monedaOrigen == "Dolar" & monedaDestino == "Dolar")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal = valorInicial;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Euro" & monedaDestino == "Euro")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal = valorInicial;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Peso Colombiano" & monedaDestino == "Peso Colombiano")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal = valorInicial;
                txtCanje.Text = Convert.ToString(valorFinal);

            }

            if (monedaOrigen == "Peso Mexicano" & monedaDestino == "Peso Mexicano")
            {

                string vr = txtCambiar.Text;
                double valorInicial = Convert.ToDouble(vr);
                double valorFinal = valorInicial;
                txtCanje.Text = Convert.ToString(valorFinal);

            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdoBTC.Checked = false;
            rdoCheque.Checked = false;
            rdoEfectivo.Checked = false;
            rdoTransferencia.Checked = false;

            txtCambiar.Text = "";
            txtCanje.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtApellido.Text = "";


            cmbCiudad.Text = "";
            cmbMonedaDestino.Text = "";
            cmbMonedaOrigen.Text = "";





        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string ciudad = cmbCiudad.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string MO = cmbMonedaOrigen.Text;
            string MD = cmbMonedaDestino.Text;
            string valorInicial = txtCambiar.Text;
            string valorFinal = txtCanje.Text;

            string rdo;

            if (rdoBTC.Checked == true)
            {
                rdo = "BTC";

                MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                    $"\r\r Datos Transacción \r\r Moneda de Origen: {MO} \r Moneda Destino: {MD} \r Medio de Pago: {rdo} \r Valor a Cambiar: {valorInicial} \r Valor del Canje: {valorFinal} \r\r\r Gracias por utilizar nuestro servicio. ");
            }

            if(rdoCheque.Checked == true)
            {
                rdo = "Cheque";

                MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                   $"\r\r Datos Transacción \r\r Moneda de Origen: {MO} \r Moneda Destino: {MD} \r Medio de Pago: {rdo} \r Valor a Cambiar: {valorInicial} \r Valor del Canje: {valorFinal} \r\r\r Gracias por utilizar nuestro servicio. ");
            
            }

            if(rdoEfectivo.Checked == true)
            {
                rdo = "Efectivo";

                MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                   $"\r\r Datos Transacción \r\r Moneda de Origen: {MO} \r Moneda Destino: {MD} \r Medio de Pago: {rdo} \r Valor a Cambiar: {valorInicial} \r Valor del Canje: {valorFinal} \r\r\r Gracias por utilizar nuestro servicio. ");
            }
        
            if (rdoTransferencia.Checked == true)
            {
                rdo = "Transferencia";

                MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                   $"\r\r Datos Transacción \r\r Moneda de Origen: {MO} \r Moneda Destino: {MD} \r Medio de Pago: {rdo} \r Valor a Cambiar: {valorInicial} \r Valor del Canje: {valorFinal} \r\r\r Gracias por utilizar nuestro servicio. ");
            }
        
            else
            {
                MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                   $"\r\r Datos Transacción \r\r Moneda de Origen: {MO} \r Moneda Destino: {MD} \r Medio de Pago: No definido \r Valor a Cambiar: {valorInicial} \r Valor del Canje: {valorFinal} \r\r\r Gracias por utilizar nuestro servicio. ");
            }
        

            
           

        }
    }
}
