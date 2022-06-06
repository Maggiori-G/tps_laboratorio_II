using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntidadesTP3 {
	public class Producto {

		private string nombre;
		private double precio;
		private int cantidad;
		private string codigoProducto;

		public Producto(string nombre, double precio, string codigoProducto) {
			this.nombre=nombre;
			this.precio=precio;
			this.codigoProducto=codigoProducto;
		}
		public Producto(string nombre,double precio,int cantidad, string codigoProducto):this(nombre,precio,codigoProducto) {
			this.cantidad=cantidad;
		}
		public double Precio {
			get {
				return this.precio;
			}
		}
		public int Cantidad {
			get {
				return this.cantidad;
			}
		}
		public string DatosProducto {
			get {
				return this.mostrarDatos();
			}
		}
		private string mostrarDatos() {
			StringBuilder sb=null;
			if(this.nombre is not null && this.precio>0 && this.cantidad>0) {
				sb=new StringBuilder();
				sb.AppendLine($"Nombre del producto: {this.nombre}");
				sb.AppendLine($"Precio: {this.precio}");
				sb.AppendLine($"Cantidad: {this.cantidad}");
				sb.AppendLine($"Codigo de producto: {this.codigoProducto}");
			}
			return sb.ToString();
		}
		
	}
}
