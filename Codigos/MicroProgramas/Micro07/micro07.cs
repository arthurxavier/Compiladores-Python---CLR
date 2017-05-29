using System;

namespace micro07
{
	class Program
	{
		static void Main(String[] args)
		{
		/* Função : Faça um algoritmo que receba N números e mostre
					positivo, negativo ou zero para cada número.
		*/

			int programa;
			int numero;
			char opc;

			programa = 1;
			while(programa ==1){

				Console.Write("Digite um número: ")
				numero = Console.ReadLine();
				if(numero > 0){
					Console.WriteLine("Positivo");
				}else{
					if(numero == 0){
						Console.WriteLine("O número é igual a 0");
					}
					if(numero < 0){
						Console.WriteLine("Negativo");
					}
				}

				Console.Write("Deseja finalizar? (S/N) ");
				opc = Console.ReadLine();
				if(opc == "S"){
					programa = 0;
				}
			}
		}
	}
}