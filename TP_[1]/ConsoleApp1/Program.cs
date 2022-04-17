using System;
using Entidades;
namespace ConsoleApp1 {
	class Program {
		static void Main(string[] args) {
			Jugador nuevoJugador = new Jugador(20, 100);

			Console.WriteLine($"Los goles son {nuevoJugador.goles} Y la cantidad de partidos es: {nuevoJugador.partidos} lo que le da un promedio de goles de {nuevoJugador.PromedioGoles}");
		}
	}
}
