using System;

namespace micro01
{
	class Program
	{
		static void Main(String[] args)
		{
			/*
			Função: Ler uma temperatura em graus Celsius e apresentá-la
			convertida em graus Fahrenheit. A fórmula de conversão é:
			F=(9*C+160) / 5,
			sendo F a temperatura em Fahrenheit e C a temperatura em
			Celsius.
			*/

			float cel;
			float far;

			Console.WriteLine("    Tabela de converesão: Celsius -> Fahrenheit");
			Console.Write("Digite a temperatura em Celsius: ");
			cel = float.Parse(Console.ReadLine());
			far = (9*cel+160)/5;

			Console.WriteLine("A nova temperatura é: ",far, " F");
		}
	}

}