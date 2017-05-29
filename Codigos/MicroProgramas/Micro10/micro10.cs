using System;

namespace micro10
{
	class Program
	{
		static void Main(String[] args)
		{
		/* Função : recebe um número e calcula recursivamente 
					o fatorial desse número.
		*/

			int numero;
			int fat;

			Console.Write("Digite um número: ");
			preço = Console.ReadLine();
			fat = fatorial(numero);

			Console.Write("O fatorial de ");
			numero = Console.ReadLine();
			Console.Write(" é ");
			fat = Console.ReadLine();
		}

		int fatorial(int n){
			if(n <= 0){
				return 1;
			}
			else{
				return n * fatorial(n-1);
			}
		}

	}
}