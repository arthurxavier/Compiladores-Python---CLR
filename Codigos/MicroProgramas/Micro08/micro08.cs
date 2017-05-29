using System;

namespace micro08
{
	class Program
	{
		static void Main(String[] args)
		{
		/* Função : Faça um algoritmo que decide se um número 
					é maior ou menor que 10
		*/

			int numero;
		
			numero = 1;
			while(numero < 0 && numero > 0){
				Console.Write("Digite um número: ");
				numero = Console.ReadLine();

				if(numero > 10){
					Console.WriteLine("O número ",numero," é maior que 10");
				}else{
					Console.WriteLine("O número ",numero," é menor que 10");
				}
			}
			
		}
	}
}