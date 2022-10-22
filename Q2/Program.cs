using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
     //使用 while , 在畫面顯示所有可以整除 300 的整數
     //例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
		static void Main(string[] args)
		{
			var result = new Divisor().GetInput(); //1.
			//Divisor result = new Divisor() ;     //2.
			//result.GetInput();
			Console.WriteLine(result);
			
		}
	}
	class Divisor
	{
		
		public string GetInput()
		{
			Console.Write("請輸入一個正整數: ");
			string value = Console.ReadLine();
			string tables = string.Empty;
			
			bool isInt = int.TryParse(value, out int table);

			if (isInt == false)
			{
				throw new Exception("輸入的值必須為正整數");
			}

			tables = tables + DivisorsSerch(table);

			return tables;
		}

		private string DivisorsSerch (int value)
		{
			
			int current = 1;
			string depiction = $"可以整除{value}的整數有: ";
			string result = string.Empty;

			while (current <= (value / 2))
			{

				if (value % current == 0)
				{
					string row = current.ToString()+" ";
					result += row;
				}

				current++;
			}
			return depiction + result;
		}
	}
}
