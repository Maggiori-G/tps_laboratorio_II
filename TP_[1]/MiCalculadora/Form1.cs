using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora {
	public partial class frmCalculadora:Form {
		public frmCalculadora() {
			InitializeComponent();
		}
		private void Form1_Load(object sender,EventArgs e) {
			this.cmbOperador.Items.Add(' ');
			this.cmbOperador.Items.Add('-');
			this.cmbOperador.Items.Add('+');
			this.cmbOperador.Items.Add('*');
			this.cmbOperador.Items.Add('/');
			Limpiar();
		}
		private void btnOperar_Click(object sender,EventArgs e) {
			string primerDato=this.txtNumero1.Text.Replace('.',',');
			string segundoDato=this.txtNumero2.Text.Replace('.',',');
			string auxiliarOperacion=this.cmbOperador.Text;
			if(string.IsNullOrWhiteSpace(cmbOperador.Text)) {
				auxiliarOperacion="+";
			}
			if(!double.TryParse(primerDato, out double numeroDescartable)) {
				primerDato="0";
			}
			if(!double.TryParse(segundoDato, out numeroDescartable)) {
				segundoDato="0";
			}
			this.lblResultado.Text=Operar(this.txtNumero1.Text.Replace('.',','), this.txtNumero2.Text.Replace('.',','), this.cmbOperador.Text).ToString();
			this.lstOperaciones.Items.Add($"{primerDato} {auxiliarOperacion} {segundoDato} = {this.lblResultado.Text.Replace('.',',')}");
		}
		private void btnLimpiar_Click(object sender,EventArgs e) {
			Limpiar();
		}
		private void btnCerrar_Click(object sender,EventArgs e) {
			this.Close();
		}
		private void btnBinarioDecimal_Click(object sender,EventArgs e) {
			this.lblResultado.Text=Operando.BinarioDecimal(this.lblResultado.Text);
		}
		private void btnDecimalBinario_Click(object sender,EventArgs e) {
			this.lblResultado.Text=Operando.DecimalBinario(this.lblResultado.Text);
		}
		/// <summary>
		/// Metodo que limpia todos los campos
		/// </summary>
		private void Limpiar() {
			this.txtNumero1.Text=null;
			this.txtNumero2.Text=null;
			this.lblResultado.Text=null;
			this.cmbOperador.SelectedIndex=-1;
		}
		/// <summary>
		/// Metodo que llama a la calculadora para operar con los numeros
		/// </summary>
		/// <param name="numeroUno">Primer numero</param>
		/// <param name="numeroDos">Segundo numero</param>
		/// <param name="Operador">El operador con el que se van a realizar operaciones matematicas</param>
		/// <returns>Retorna el resultado</returns>
		private static double Operar(string numeroUno, string numeroDos, string Operador) {
			if(string.IsNullOrWhiteSpace(Operador)) {
				Operador=" ";
			}
			return Calculadora.Operar(new Operando(numeroUno), new Operando(numeroDos),char.Parse(Operador));
		}
		private void frmCalculadora_FormClosing(object sender,FormClosingEventArgs e) {
			DialogResult respuesta = MessageBox.Show("Seguro que desea cerrar?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(respuesta==DialogResult.No) {
				e.Cancel=true;
			}
		}
	}
}
