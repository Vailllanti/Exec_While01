using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		//1+ 2 + 3 + 4 + .... + N <105
		//請問 N 是多少?
		static void Main(string[] args)
		{
			int sum = 105;
			int current = 0;
			int result = 0;
		
			while (result < sum) 
			{

				current++;
				result += current;

			}
			Console.WriteLine($"N={current}");
		}
	}
}
