using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Calculadora {
		private static char ValidarOperador(char operador) {
			if(operador=='*'||operador=='-'||operador=='/') {
				return operador;
			}
			else {
				return '+';
			}
		}
		public static double Operar(Operando numeroUno, Operando numeroDos, char operador) {
			double resultado;
			switch(ValidarOperador(operador)) {
				case '-':
					resultado= numeroUno-numeroDos;
				break;
				case '*':
					resultado= numeroUno*numeroDos;
				break;
				case '/':
					resultado= numeroUno/numeroDos;
				break;
				default:
					resultado= numeroUno+numeroDos;
				break;
			}
			return resultado;
		}
	}
}
