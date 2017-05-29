using System;

namespace nano
{
	class Program
	{
		static void Main(String[] args)
		{
			int n;
			int m;
			int x;
			n = 1;
			m = 2;
			x = 5;
			while(x > n)
			{
				n = n + m;
				Console.WriteLine(n);
			}
		}
	}

}