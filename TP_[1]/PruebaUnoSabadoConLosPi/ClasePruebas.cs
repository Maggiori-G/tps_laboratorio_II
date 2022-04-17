using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnoSabadoConLosPi{
	class ClasePruebas {
		//atributos
		//estaticos y no estaticos
		//privados y publicos
		public int edad;
		public double altura;
		public string nombre;

		//metodos -> 

		//constructor
		public ClasePruebas() {
			this.edad=20;
			this.nombre="gianni";
			this.altura=175.7;
		}
		public ClasePruebas(string a):this() {
			this.nombre=a;
		}
		public ClasePruebas(double f) : this() {
			this.altura=f;
		}

		public static implicit operator string(ClasePruebas pruebaUno) {
			 return pruebaUno.nombre;
		}
		public static implicit operator int (ClasePruebas pruebaUno) {
			 return pruebaUno.edad;
		}
		public static explicit operator double (ClasePruebas pruebaUno) {
			 return pruebaUno.altura;
		}
		public static implicit operator ClasePruebas(string nombre) {
			return new ClasePruebas(nombre);
		}
		public static implicit operator ClasePruebas(double altura) {
			return new ClasePruebas(altura);
		}
	}
	

}
