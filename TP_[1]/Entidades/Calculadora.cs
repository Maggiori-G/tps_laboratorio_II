using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Calculadora {
		/// <summary>
		/// Valida que el operador matematico sea resta, mutiplicacion o division, o pone por default suma
		/// </summary>
		/// <param name="operador">La operacion matematica a realizar</param>
		/// <returns>El operador validado</returns>
		private static char ValidarOperador(char operador) {
			if(operador=='*'||operador=='-'||operador=='/') {
				return operador;
			}
			else {
				return '+';
			}
		}
		/// <summary>
		/// Realiza las operaciones matematicas suma, resta, multiplicacion o division
		/// </summary>
		/// <param name="numeroUno">Primer numero</param>
		/// <param name="numeroDos">Segundo numero</param>
		/// <param name="operador">Operador indicativo de la operacion a realizar</param>
		/// <returns></returns>
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
