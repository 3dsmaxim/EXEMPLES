
using ListMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace ConsoleVS
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayMaster am = new();
            for (int i = 0; i < 10; i++)
            {
                am.Add(new Random().Next(1, 5));
            }
            for (int i = 0; i < am.GetCount(); i++)
            {
                Console.WriteLine(am.GetValue(i));    
            }
        }

     

   }
}