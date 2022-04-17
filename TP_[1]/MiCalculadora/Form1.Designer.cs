
namespace MiCalculadora {
	partial class frmCalculadora {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.cmbOperador = new System.Windows.Forms.ComboBox();
			this.lstOperaciones = new System.Windows.Forms.ListBox();
			this.btnDecimalBinario = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnBinarioDecimal = new System.Windows.Forms.Button();
			this.btnOperar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblResultado
			// 
			this.lblResultado.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblResultado.Location = new System.Drawing.Point(12, 9);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(452, 117);
			this.lblResultado.TabIndex = 0;
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNumero1
			// 
			this.txtNumero1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtNumero1.Location = new System.Drawing.Point(12, 141);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(129, 38);
			this.txtNumero1.TabIndex = 0;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtNumero2.Location = new System.Drawing.Point(335, 141);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(129, 38);
			this.txtNumero2.TabIndex = 2;
			// 
			// cmbOperador
			// 
			this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOperador.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cmbOperador.FormattingEnabled = true;
			this.cmbOperador.Location = new System.Drawing.Point(169, 141);
			this.cmbOperador.Name = "cmbOperador";
			this.cmbOperador.Size = new System.Drawing.Size(129, 39);
			this.cmbOperador.TabIndex = 1;
			// 
			// lstOperaciones
			// 
			this.lstOperaciones.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lstOperaciones.FormattingEnabled = true;
			this.lstOperaciones.ItemHeight = 25;
			this.lstOperaciones.Location = new System.Drawing.Point(470, 9);
			this.lstOperaciones.Name = "lstOperaciones";
			this.lstOperaciones.Size = new System.Drawing.Size(351, 304);
			this.lstOperaciones.TabIndex = 4;
			this.lstOperaciones.TabStop = false;
			// 
			// btnDecimalBinario
			// 
			this.btnDecimalBinario.Location = new System.Drawing.Point(247, 250);
			this.btnDecimalBinario.Name = "btnDecimalBinario";
			this.btnDecimalBinario.Size = new System.Drawing.Size(217, 42);
			this.btnDecimalBinario.TabIndex = 7;
			this.btnDecimalBinario.Text = "Convertir a Binario";
			this.btnDecimalBinario.UseVisualStyleBackColor = true;
			this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(169, 202);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(129, 42);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(335, 202);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(129, 42);
			this.btnCerrar.TabIndex = 5;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnBinarioDecimal
			// 
			this.btnBinarioDecimal.Location = new System.Drawing.Point(12, 250);
			this.btnBinarioDecimal.Name = "btnBinarioDecimal";
			this.btnBinarioDecimal.Size = new System.Drawing.Size(229, 42);
			this.btnBinarioDecimal.TabIndex = 6;
			this.btnBinarioDecimal.Text = "Convertir a Decimal";
			this.btnBinarioDecimal.UseVisualStyleBackColor = true;
			this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
			// 
			// btnOperar
			// 
			this.btnOperar.Location = new System.Drawing.Point(12, 202);
			this.btnOperar.Name = "btnOperar";
			this.btnOperar.Size = new System.Drawing.Size(129, 42);
			this.btnOperar.TabIndex = 3;
			this.btnOperar.Text = "Operar";
			this.btnOperar.UseVisualStyleBackColor = true;
			this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
			// 
			// frmCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 322);
			this.Controls.Add(this.btnOperar);
			this.Controls.Add(this.btnBinarioDecimal);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnDecimalBinario);
			this.Controls.Add(this.lstOperaciones);
			this.Controls.Add(this.cmbOperador);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.lblResultado);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCalculadora";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Maggiori Gianni 2A";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalculadora_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.ComboBox cmbOperador;
		private System.Windows.Forms.ListBox lstOperaciones;
		private System.Windows.Forms.Button btnDecimalBinario;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnBinarioDecimal;
		private System.Windows.Forms.Button btnOperar;
	}
}

