using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_clase_2 {
	class Sello {
		public static String mensaje;
		public static ConsoleColor color;

		public static String Imprimir() {
			return ArmarFormatoMensaje();
		}
		public static void Borrar() {
			Sello.mensaje="";
		}
		public static void ImprimirColor() {
			Console.ForegroundColor=Sello.color;
			Console.WriteLine(Sello.Imprimir());
			Console.ResetColor();
		}
		private static String ArmarFormatoMensaje() {
			string mensajeFormateado="";
			for(int i = 0;i<Sello.mensaje.Length+2;i++) {
				mensajeFormateado+="*";
			}
			mensajeFormateado=mensajeFormateado+"\n*"+Sello.mensaje+"*\n"+mensajeFormateado;
			return mensajeFormateado;
		}
		//hacer un tryparse
		
	}
}
