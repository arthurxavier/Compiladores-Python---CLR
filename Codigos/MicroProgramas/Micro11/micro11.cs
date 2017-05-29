using System;

namespace micro11
{
	class Program
	{
		static void Main(String[] args)
		{
		/* Função : recebe um número e verifica se o número 
					é positivo, nulo ou negativo com auxilio
				  	de uma função.
		*/

			int numero;
			int x;

			Console.Write("Digite um número: ");
			numero = Console.ReadLine();

			x = verifica(numero);
			if(x == 1){
				Console.WriteLine("Número positivo");

			}else if(x == 0){
				Console.WriteLine("Zero");

			}else{
				Console.WriteLine("Número negativo");

			}
		}

		int verifica(int n){
			int res;

			if(n > 0){
				res = 1;

			}
			else if(n < 0){
				res = -1;

			}else{
				res = 0;

			}
			
			return res;
		}
	}
}
