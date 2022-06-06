
namespace MaggioriGianni_PuntoDeVenta {
	partial class PantallaPrincipal {
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
			this.lbl_Productos = new System.Windows.Forms.Label();
			this.btn_AgregarProducto = new System.Windows.Forms.Button();
			this.btn_Salir = new System.Windows.Forms.Button();
			this.lbl_Titulo = new System.Windows.Forms.Label();
			this.btn_BorrarProducto = new System.Windows.Forms.Button();
			this.btn_ModificarProducto = new System.Windows.Forms.Button();
			this.btn_CargarDesdeJSON = new System.Windows.Forms.Button();
			this.btn_CargarDesdeTxT = new System.Windows.Forms.Button();
			this.lbl_Pedido = new System.Windows.Forms.Label();
			this.btn_GenerarPedido = new System.Windows.Forms.Button();
			this.btn_EliminarPedido = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_CalcularPrecio = new System.Windows.Forms.Button();
			this.btn_Descuento = new System.Windows.Forms.Button();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbl_ListaPedidos = new System.Windows.Forms.Label();
			this.btn_MostrarListaCompleta = new System.Windows.Forms.Button();
			this.btn_BorrarLista = new System.Windows.Forms.Button();
			this.btn_ExportarJSON = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.lbl_DetallePedido = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Productos
			// 
			this.lbl_Productos.AutoSize = true;
			this.lbl_Productos.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_Productos.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_Productos.Location = new System.Drawing.Point(12, 65);
			this.lbl_Productos.Name = "lbl_Productos";
			this.lbl_Productos.Size = new System.Drawing.Size(220, 28);
			this.lbl_Productos.TabIndex = 1;
			this.lbl_Productos.Text = "Lista de Productos";
			// 
			// btn_AgregarProducto
			// 
			this.btn_AgregarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_AgregarProducto.Location = new System.Drawing.Point(12, 450);
			this.btn_AgregarProducto.Name = "btn_AgregarProducto";
			this.btn_AgregarProducto.Size = new System.Drawing.Size(156, 40);
			this.btn_AgregarProducto.TabIndex = 4;
			this.btn_AgregarProducto.Text = "Agregar Producto";
			this.btn_AgregarProducto.UseVisualStyleBackColor = true;
			// 
			// btn_Salir
			// 
			this.btn_Salir.Location = new System.Drawing.Point(1146, 708);
			this.btn_Salir.Name = "btn_Salir";
			this.btn_Salir.Size = new System.Drawing.Size(88, 58);
			this.btn_Salir.TabIndex = 6;
			this.btn_Salir.Text = "Salir";
			this.btn_Salir.UseVisualStyleBackColor = true;
			// 
			// lbl_Titulo
			// 
			this.lbl_Titulo.AutoSize = true;
			this.lbl_Titulo.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.lbl_Titulo.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbl_Titulo.Location = new System.Drawing.Point(469, 9);
			this.lbl_Titulo.Name = "lbl_Titulo";
			this.lbl_Titulo.Size = new System.Drawing.Size(274, 35);
			this.lbl_Titulo.TabIndex = 10;
			this.lbl_Titulo.Text = "Polirubro \"El Tanito\"";
			// 
			// btn_BorrarProducto
			// 
			this.btn_BorrarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_BorrarProducto.Location = new System.Drawing.Point(174, 450);
			this.btn_BorrarProducto.Name = "btn_BorrarProducto";
			this.btn_BorrarProducto.Size = new System.Drawing.Size(156, 40);
			this.btn_BorrarProducto.TabIndex = 11;
			this.btn_BorrarProducto.Text = "Eliminar Producto";
			this.btn_BorrarProducto.UseVisualStyleBackColor = true;
			// 
			// btn_ModificarProducto
			// 
			this.btn_ModificarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_ModificarProducto.Location = new System.Drawing.Point(336, 450);
			this.btn_ModificarProducto.Name = "btn_ModificarProducto";
			this.btn_ModificarProducto.Size = new System.Drawing.Size(156, 40);
			this.btn_ModificarProducto.TabIndex = 12;
			this.btn_ModificarProducto.Text = "Modificar Producto";
			this.btn_ModificarProducto.UseVisualStyleBackColor = true;
			// 
			// btn_CargarDesdeJSON
			// 
			this.btn_CargarDesdeJSON.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_CargarDesdeJSON.Location = new System.Drawing.Point(12, 496);
			this.btn_CargarDesdeJSON.Name = "btn_CargarDesdeJSON";
			this.btn_CargarDesdeJSON.Size = new System.Drawing.Size(237, 40);
			this.btn_CargarDesdeJSON.TabIndex = 13;
			this.btn_CargarDesdeJSON.Text = "Importar Lista Depósito JSON";
			this.btn_CargarDesdeJSON.UseVisualStyleBackColor = true;
			// 
			// btn_CargarDesdeTxT
			// 
			this.btn_CargarDesdeTxT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_CargarDesdeTxT.Location = new System.Drawing.Point(255, 496);
			this.btn_CargarDesdeTxT.Name = "btn_CargarDesdeTxT";
			this.btn_CargarDesdeTxT.Size = new System.Drawing.Size(237, 40);
			this.btn_CargarDesdeTxT.TabIndex = 14;
			this.btn_CargarDesdeTxT.Text = "Importar Lista Depósito CSV";
			this.btn_CargarDesdeTxT.UseVisualStyleBackColor = true;
			// 
			// lbl_Pedido
			// 
			this.lbl_Pedido.AutoSize = true;
			this.lbl_Pedido.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_Pedido.Location = new System.Drawing.Point(498, 65);
			this.lbl_Pedido.Name = "lbl_Pedido";
			this.lbl_Pedido.Size = new System.Drawing.Size(88, 28);
			this.lbl_Pedido.TabIndex = 15;
			this.lbl_Pedido.Text = "Pedido";
			// 
			// btn_GenerarPedido
			// 
			this.btn_GenerarPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_GenerarPedido.Location = new System.Drawing.Point(498, 496);
			this.btn_GenerarPedido.Name = "btn_GenerarPedido";
			this.btn_GenerarPedido.Size = new System.Drawing.Size(167, 40);
			this.btn_GenerarPedido.TabIndex = 17;
			this.btn_GenerarPedido.Text = "Generar Pedido";
			this.btn_GenerarPedido.UseVisualStyleBackColor = true;
			// 
			// btn_EliminarPedido
			// 
			this.btn_EliminarPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_EliminarPedido.Location = new System.Drawing.Point(671, 496);
			this.btn_EliminarPedido.Name = "btn_EliminarPedido";
			this.btn_EliminarPedido.Size = new System.Drawing.Size(167, 40);
			this.btn_EliminarPedido.TabIndex = 18;
			this.btn_EliminarPedido.Text = "Eliminar Pedido";
			this.btn_EliminarPedido.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(12, 96);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(480, 348);
			this.dataGridView1.TabIndex = 19;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Código";
			this.Column1.Name = "Column1";
			this.Column1.Width = 110;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre";
			this.Column2.Name = "Column2";
			this.Column2.Width = 160;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Precio";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Cantidad ";
			this.Column4.Name = "Column4";
			this.Column4.Width = 67;
			// 
			// dataGridView2
			// 
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
			this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView2.Location = new System.Drawing.Point(498, 96);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 25;
			this.dataGridView2.Size = new System.Drawing.Size(340, 348);
			this.dataGridView2.TabIndex = 20;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Nombre Producto";
			this.Column5.Name = "Column5";
			this.Column5.Width = 150;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Precio";
			this.Column6.Name = "Column6";
			this.Column6.Width = 80;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Cantidad";
			this.Column7.Name = "Column7";
			this.Column7.Width = 67;
			// 
			// btn_CalcularPrecio
			// 
			this.btn_CalcularPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_CalcularPrecio.Location = new System.Drawing.Point(498, 450);
			this.btn_CalcularPrecio.Name = "btn_CalcularPrecio";
			this.btn_CalcularPrecio.Size = new System.Drawing.Size(167, 40);
			this.btn_CalcularPrecio.TabIndex = 21;
			this.btn_CalcularPrecio.Text = "Calcular Precio";
			this.btn_CalcularPrecio.UseVisualStyleBackColor = true;
			// 
			// btn_Descuento
			// 
			this.btn_Descuento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_Descuento.Location = new System.Drawing.Point(671, 450);
			this.btn_Descuento.Name = "btn_Descuento";
			this.btn_Descuento.Size = new System.Drawing.Size(167, 40);
			this.btn_Descuento.TabIndex = 22;
			this.btn_Descuento.Text = "Aplicar Descuento";
			this.btn_Descuento.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
			this.dataGridView3.Location = new System.Drawing.Point(12, 570);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.RowTemplate.Height = 25;
			this.dataGridView3.Size = new System.Drawing.Size(613, 178);
			this.dataGridView3.TabIndex = 23;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Comprador";
			this.Column8.Name = "Column8";
			this.Column8.Width = 150;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Direccion";
			this.Column9.Name = "Column9";
			this.Column9.Width = 150;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Fecha";
			this.Column10.Name = "Column10";
			// 
			// Column11
			// 
			this.Column11.HeaderText = "Estado";
			this.Column11.Name = "Column11";
			// 
			// Column12
			// 
			this.Column12.HeaderText = "Precio Final";
			this.Column12.Name = "Column12";
			this.Column12.Width = 70;
			// 
			// lbl_ListaPedidos
			// 
			this.lbl_ListaPedidos.AutoSize = true;
			this.lbl_ListaPedidos.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_ListaPedidos.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_ListaPedidos.Location = new System.Drawing.Point(12, 539);
			this.lbl_ListaPedidos.Name = "lbl_ListaPedidos";
			this.lbl_ListaPedidos.Size = new System.Drawing.Size(196, 28);
			this.lbl_ListaPedidos.TabIndex = 24;
			this.lbl_ListaPedidos.Text = "Lista de Pedidos";
			// 
			// btn_MostrarListaCompleta
			// 
			this.btn_MostrarListaCompleta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_MostrarListaCompleta.Location = new System.Drawing.Point(631, 570);
			this.btn_MostrarListaCompleta.Name = "btn_MostrarListaCompleta";
			this.btn_MostrarListaCompleta.Size = new System.Drawing.Size(207, 40);
			this.btn_MostrarListaCompleta.TabIndex = 25;
			this.btn_MostrarListaCompleta.Text = "Mostrar Lista Completa";
			this.btn_MostrarListaCompleta.UseVisualStyleBackColor = true;
			// 
			// btn_BorrarLista
			// 
			this.btn_BorrarLista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_BorrarLista.Location = new System.Drawing.Point(631, 616);
			this.btn_BorrarLista.Name = "btn_BorrarLista";
			this.btn_BorrarLista.Size = new System.Drawing.Size(207, 40);
			this.btn_BorrarLista.TabIndex = 26;
			this.btn_BorrarLista.Text = "Borrar Lista";
			this.btn_BorrarLista.UseVisualStyleBackColor = true;
			// 
			// btn_ExportarJSON
			// 
			this.btn_ExportarJSON.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btn_ExportarJSON.Location = new System.Drawing.Point(631, 662);
			this.btn_ExportarJSON.Name = "btn_ExportarJSON";
			this.btn_ExportarJSON.Size = new System.Drawing.Size(207, 40);
			this.btn_ExportarJSON.TabIndex = 27;
			this.btn_ExportarJSON.Text = "Exportar Lista en JSON";
			this.btn_ExportarJSON.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button4.Location = new System.Drawing.Point(631, 708);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(207, 40);
			this.button4.TabIndex = 28;
			this.button4.Text = "Exportar Lista en CSV";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// lbl_DetallePedido
			// 
			this.lbl_DetallePedido.AutoSize = true;
			this.lbl_DetallePedido.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_DetallePedido.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbl_DetallePedido.Location = new System.Drawing.Point(887, 65);
			this.lbl_DetallePedido.Name = "lbl_DetallePedido";
			this.lbl_DetallePedido.Size = new System.Drawing.Size(217, 28);
			this.lbl_DetallePedido.TabIndex = 29;
			this.lbl_DetallePedido.Text = "Detalle del Pedido";
			// 
			// PantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1246, 778);
			this.Controls.Add(this.lbl_DetallePedido);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btn_ExportarJSON);
			this.Controls.Add(this.btn_BorrarLista);
			this.Controls.Add(this.btn_MostrarListaCompleta);
			this.Controls.Add(this.lbl_ListaPedidos);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.btn_Descuento);
			this.Controls.Add(this.btn_CalcularPrecio);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_EliminarPedido);
			this.Controls.Add(this.btn_GenerarPedido);
			this.Controls.Add(this.lbl_Pedido);
			this.Controls.Add(this.btn_CargarDesdeTxT);
			this.Controls.Add(this.btn_CargarDesdeJSON);
			this.Controls.Add(this.btn_ModificarProducto);
			this.Controls.Add(this.btn_BorrarProducto);
			this.Controls.Add(this.lbl_Titulo);
			this.Controls.Add(this.btn_Salir);
			this.Controls.Add(this.btn_AgregarProducto);
			this.Controls.Add(this.lbl_Productos);
			this.Name = "PantallaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TP n°3 Maggiori Gianni";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbl_Productos;
		private System.Windows.Forms.Button btn_AgregarProducto;
		private System.Windows.Forms.Button btn_Salir;
		private System.Windows.Forms.Label lbl_Titulo;
		private System.Windows.Forms.Button btn_BorrarProducto;
		private System.Windows.Forms.Button btn_ModificarProducto;
		private System.Windows.Forms.Button btn_CargarDesdeJSON;
		private System.Windows.Forms.Button btn_CargarDesdeTxT;
		private System.Windows.Forms.Label lbl_Pedido;
		private System.Windows.Forms.Button btn_GenerarPedido;
		private System.Windows.Forms.Button btn_EliminarPedido;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.Button btn_CalcularPrecio;
		private System.Windows.Forms.Button btn_Descuento;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.Label lbl_ListaPedidos;
		private System.Windows.Forms.Button btn_MostrarListaCompleta;
		private System.Windows.Forms.Button btn_BorrarLista;
		private System.Windows.Forms.Button btn_ExportarJSON;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label lbl_DetallePedido;
	}
}

