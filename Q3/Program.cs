using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入數字:") ;
            string input=Console.ReadLine();
            int number=Convert.ToInt32(input);
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("請輸入數字");
                return;
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("此數字是偶數");
            }
            else
            {
                Console.WriteLine("此數字是奇數");
            }
            
            
        }
    }
}
