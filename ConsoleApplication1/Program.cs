using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = new int[] { 0};
            int[] temp = new int[] { 0};

            int i = 0;
            while(true)
            {
               
                arr = new int[i+1];
                Array.Copy(temp, arr, temp.Length );
                Console.WriteLine("enter the number of the array");
                temp = new int[i+1];
                int n = 0;
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    arr[i] = n;
                    Array.Copy(arr, temp, arr.Length);
                    
                    i++;
                
                }
                else
                    break;
            }
            Console.WriteLine("Array");
            for (int j = 0; j < arr.Length-1; j++)
            {
                Console.WriteLine(arr[j]);
            }
            
            Console.ReadLine();

        }
    }
}
