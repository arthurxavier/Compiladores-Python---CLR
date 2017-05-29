using System;

namespace micro09
{
	class Program
	{
		static void Main(String[] args)
		{
		/* Função : Faça um algoritmo que faz 
					cálculo de preços
		*/

			float preço;
			float venda;
			float novo_preço;
		
			Console.Write("Digite um número: ");
			preço = Console.ReadLine();
			Console.Write("Digite a venda: ");
			venda = Console.ReadLine();

			if(venda < 500 || preço < 30){
			
				novo_preço = preço + 10/(100 * preço);
			
			}else if( 	(venda >= 500 && venda < 1200) || 
						(preço >= 30 && preço < 30)){

				novo_preço = preço + 15/(100 * preço);
			
			}else if(venda >= 1200 || preço >= 80){

				novo_preço = preço - 20/(100*preço);
			
			} 

			Console.WriteLine("O novo preço é ", novo_preço);
		}
	}
}