using System;

namespace nano
{
	class Program
	{
		static void Main(String[] args)
		{
			/* Função : Faça um algoritmo que receba um número e diga se este
						número está no intervalo entre 100 e 200.
			*/

			int numero;

			Console.Write("Digite um número: ");
			numero = Console.ReadLine();			
			
			if(numero >= 100){
				if(numero <= 200){
					Console.Write("O número está no intervalo entre 100 e 200");
				}
				else{
					Console.Write("O número não está no intervalo entre 100 e 200");
				}
			}
			else{
				Console.Write("O número não está no intervalo entre 100 e 200");
			}
		
		}
	}

}