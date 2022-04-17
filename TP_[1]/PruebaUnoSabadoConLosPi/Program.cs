using System;

namespace PruebaUnoSabadoConLosPi {
	class Program {
		static void Main(string[] args) {
			//Console.WriteLine("Hello World!");
			ClasePruebas persona = new ClasePruebas();//por defecto
			ClasePruebas segundaPersona ="thiago";
			ClasePruebas tercerPersona = 180;
			ClasePruebas cuartaPersona= new ClasePruebas("gio"); 
			Console.WriteLine($"{persona.edad},{persona.nombre}");
			
			string l;
			int z;
			double a;
			l=persona;
			z=persona;
			a=(double)persona;
			Console.WriteLine($"{a},{l},{z}");
			Console.WriteLine($"{segundaPersona.nombre},{segundaPersona.edad},{segundaPersona.altura}");
			Console.WriteLine($"{tercerPersona.nombre},{tercerPersona.edad},{tercerPersona.altura}");
			Console.WriteLine($"{cuartaPersona.nombre},{cuartaPersona.edad},{cuartaPersona.altura}");
			
			Console.ReadKey();
		}
	}
}
