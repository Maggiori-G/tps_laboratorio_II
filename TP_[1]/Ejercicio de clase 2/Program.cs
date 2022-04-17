using System;

namespace Ejercicio_de_clase_2 {
	class Program {
		static void Main(string[] args) {
			Sello.mensaje="Hola Mundo";
			Sello.color=ConsoleColor.Red;

			Console.WriteLine(Sello.mensaje);
			Console.WriteLine(Sello.mensaje);
			Sello.color=ConsoleColor.Red;
			Sello.ImprimirColor();

			Sello.Borrar();
			Console.WriteLine(Sello.mensaje);
			
		}
	}
}
