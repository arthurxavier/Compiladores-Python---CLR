using System;

namespace micro05
{
	class Program
	{
		static void Main(String[] args)
		{
		/* Função : Faça um algoritmo que leia um número de 1 a 5 e o
					escreva por extenso. Caso o usuário digite um número que
					não esteja neste intervalo, exibir mensagem: número inválido.
		*/

			int numero;


			switch (numero)
			{
				case 1:
					Console.WriteLine("Um");
					break;
				case 2:
					Console.WriteLine("Dois");
					break;
				case 3:
					Console.WriteLine("Três");
					break;
				case 4:
					Console.WriteLine("Quatro");
					break;
				case 5:
					Console.WriteLine("Cinco");
					break;	
				default:
					Console.WriteLine("Número Inválido!!!");
					break;
			}

		}
	}
}