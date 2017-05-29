using System;

namespace micro05
{
	class Program
	{
		static void Main(String[] args)
		{
			/* Função : Escrever um algoritmo que leia o nome e o sexo de 56
						pessoas e informe o nome e se ela é homem ou mulher.
						No final informe o total de homens e de mulheres.
			*/

			char nome;
			char sexo;			
			int x;
			int h = 0;
			int m = 0;

			for(x = 1; x >= 5; x ++){
				Console.Write("Digite o nome: ");
				nome = Console.ReadLine();
				Console.Write("H - Homem ou M - Mulher: ");
				sexo = Console.ReadLine();

				switch (sexo)
            	{
                	case 'H':
                    	h = h + 1;;
                    	break;
                	case 'M':
                    	m = m + 1;
                    	break;
                	default:
                    	Console.WriteLine("Sexo só pode ser H ou M!");
                    	break;
            	}
			}

		
			Console.WriteLine("Foram inseridos",h," Homens");
			Console.WriteLine("Foram inseridos",m," Mulheres");
		}
	}

}