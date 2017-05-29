using System;

namespace nano
{
	class Program
	{
		static void Main(String[] args)
		{
			/* 	Função: Escrever um algoritmo que leia dois valores inteiro
						distintos e informe qual é o maior.
			*/

			int num1;
			int num2;

			Console.Write("Digite o primeiro número: ");
			num1 = Console.ReadLine();			
			Console.Write("Digite o segundo número: ");
			num2 = Console.ReadLine();

			if(num1 > num2){
				Console.Write("O primeiro número ",num1," é maior que o segundo",num2);
			}else{
				Console.Write("O segundo número ",num2," é maior que o primeiro",num1);
			}
		
		}
	}

}