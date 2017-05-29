using System;

namespace micro04
{
	class Program
	{
		static void Main(String[] args)
		{
			/*
			Função: Ler 5 números e ao final informar quantos número(s)
					est(á)ão no intervalo entre 10 (inclusive) e 150 (inclusive).
			*/

			int x;
			int num;
			int intervalo = 0;

			for(x = 1; x >= 5; x ++){
				Console.Write("Digite um número: ");
				num = Console.ReadLine();
				if(num >= 10){
					if(num <= 150){
						intervalo = intervalo + 1;
					}
				}
			}
		
			Console.WriteLine("Ao total, foram digitados ",intervalo," números no intervalo entre 10 e 150");
		}
	}

}