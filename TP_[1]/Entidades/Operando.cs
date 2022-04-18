using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades {
	public class Operando {
		// Atributos
		private double numero;
		// Propiedades		
		private string Numero {
			set {
				this.numero=ValidarOperando(value);
			}
		}
		// Constructores
		/// <summary>
		/// Constructor por defecto
		/// </summary>
		public Operando() {
			numero=0;
		}
		/// <summary>
		/// Constructor parametrizado. Asigna un double al atrubuto numero o llama al constructor por defecto
		/// </summary>
		/// <param name="operando"></param>
		public Operando(double operando): this() {
			this.numero=operando;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="sOperando">Recibe un string y lo asigna al atributo</param>
		public Operando(string sOperando) {
			this.Numero=sOperando;
		}
		// Metodos
		/// <summary>
		/// Metodo que valida el operando que recibe como string con tryparse
		/// </summary>
		/// <param name="sOperando">Operando en formato string</param>
		/// <returns>Retorna 0 si no pudo no pudo parsear el string o retorna el numero parseado a double</returns>
		private static double ValidarOperando(string sOperando) {
			if(!double.TryParse(sOperando, out double operandoValidado)) {
				operandoValidado=0;
			}
			return operandoValidado;
		}

		public static double operator +(Operando numeroUno, Operando numeroDos) {
			return numeroUno.numero+numeroDos.numero;
		}public static double operator -(Operando numeroUno, Operando numeroDos) {
			return numeroUno.numero-numeroDos.numero;
		}public static double operator *(Operando numeroUno, Operando numeroDos) {
			return numeroUno.numero*numeroDos.numero;
		}public static double operator /(Operando numeroUno, Operando numeroDos) {
			if(numeroDos.numero==0) {
				return double.MinValue;
			}
			return numeroUno.numero/numeroDos.numero;
		}
		/// <summary>
		/// Metodo que valida si un string que recibe es un numero binario
		/// </summary>
		/// <param name="sOperando">String a validar</param>
		/// <returns>Retorna true si es un numero binario, sino retorna false</returns>
		private static bool EsBinario(string sOperando) {
			foreach(char auxiliar in sOperando) {
				if(auxiliar!='0'&&auxiliar!='1') {
					return false;
				}
			}
			return true;
		}
		/// <summary>
		/// Metodo que convierte un numero decimal a binario
		/// </summary>
		/// <param name="sOperando">Numero decimal en formato string</param>
		/// <returns>Retorna el numero en binario en formato string o un valor ilogico "Valor Invalido"</returns>
		public static string DecimalBinario(string sOperando) {
			int resto;
			string numeroBinario="Valor Invalido";
			if(int.TryParse(sOperando, out int entero)) {
				if(entero>0) {
					numeroBinario=string.Empty;
					for(int i = 0;entero>0;i++) {
						resto=entero%2;
						entero/=2;
						numeroBinario=resto.ToString()+numeroBinario;
					}
				}
			}			
			return numeroBinario;
		}
		/// <summary>
		/// Sobrecarga del metodo DecimalBinario. Este metodo recibe un numero double en lugar de string
		/// y llama al metodo DecimalBinario pasandole el double como string
		/// </summary>
		/// <param name="operando">Numero a convertir en binario</param>
		/// <returns>Retorna el numero en binario en formato string o un valor ilogico "Valor Invalido"</returns>
		public static string DecimalBinario(double operando) {
			return DecimalBinario(operando.ToString());
		}		

		public static string BinarioDecimal(string sOperando) {
			char[] auxiliarChar= new char[sOperando.Length];
			Array.Copy(sOperando.ToArray(), auxiliarChar, sOperando.Length);
			Array.Reverse(auxiliarChar);
			string retorno="Valor Invalido";
			double auxiliarEntero=0;
			if(EsBinario(sOperando)){
				for(int i = 0;i<auxiliarChar.Length;i++) {
					if(auxiliarChar[i]=='1') {
						auxiliarEntero+=Math.Pow(2,i);
					}
				}
				retorno=auxiliarEntero.ToString();
			}
			return retorno;
		}
	}
}