using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTP3 {
	public class Pedido {
		private List<Producto> listaProductos;
		private string nombre;
		private string direccion;
		private DateTime fecha;
		private bool finalizado;
		public Pedido() {
			this.listaProductos=new List<Producto>();
		}
		public Pedido(string nombre, string direccion, DateTime fecha):this() {
			this.nombre=nombre;
			this.direccion=direccion;
			this.fecha=fecha;
			this.finalizado=false;
		}
		public string Comprador {
			get {
				return datosComprador();
			}			
		}
		private string datosComprador() {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Comprador: {this.nombre}");
			sb.AppendLine($"Direccion: {this.direccion}");
			sb.AppendLine($"Dia de registro: {this.fecha}");
			if(this.finalizado) {
				sb.AppendLine($"Estado del pedido: Finalizado");
			}
			else {
				sb.AppendLine($"Estado del pedido: En proceso");
			}
			return sb.ToString();
		}
		public static double calcularPrecioFinal(Producto producto) {
			double precioFinal=0;
			if(producto is not null && producto.Cantidad>0 && producto.Precio>0) {
				precioFinal=producto.Cantidad*producto.Precio;
			}
			return precioFinal;
		}
		public static double calcularPrecioFinal(Producto producto,int descuento) {
			double precioFinal=0;
			if(producto is not null && producto.Cantidad>0 && producto.Precio>0) {
				precioFinal=producto.Cantidad*producto.Precio;
				if(descuento>0) {
					precioFinal=precioFinal*descuento/100;
				}
			}
			return precioFinal;
		}
		public double subTotal(List<Producto> listaProductos) {
			double retorno=0;
			if(listaProductos is not null) {
				foreach(Producto item in listaProductos) {
					retorno+=item.Precio;
				}
			}
			return retorno;
		}
	}
}
