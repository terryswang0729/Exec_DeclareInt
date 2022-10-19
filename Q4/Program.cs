using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    int number1 = 1;
			int number2 = 10;
			int temp = number1;
			number1 = number2;
			number2 = temp;
			Console.WriteLine($"對調結果:number1={number1},number2={number2}");


		}
	}
}
