using System;

namespace nano
{
	class Program
	{
		static void Main(String[] args)
		{
			int n = 1;
			int m = 2;
			int x = 5;
			while(x > n)
			{
				if(n == m){
					Console.WriteLine(n);
				}
				else{
					Console.WriteLine(0);
				}
				x = x - 1;
			}
		}
	}

}