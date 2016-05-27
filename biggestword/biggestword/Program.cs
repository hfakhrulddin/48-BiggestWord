using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggestword
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            while (Exit == false)
            {
                var foos1 = Console.ReadLine();
                int Max = solution(foos1);
                Console.WriteLine(Max);
            }
        }
    
        public static int solution(string S)
        {
            int result1 = 0;
            string[] arr3;
            string[] arr1 = S.Split('.');
            int l = arr1.Length;

            for (int x = 0; x < l; x++)
            {
                string arr2 = arr1[x];

                arr3 = arr2.Split(' ');
                for (int y = 0; y < arr3.Length; y++)
                {
                    if (arr3[y] == "") { continue; }
                    else {
                        if (arr3.Length > result1)
                        { result1 = arr3.Length; }
                        else { continue; }
                    }
                }

            }
            return result1;
        }
    }
}