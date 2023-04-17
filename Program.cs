using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] intArr = { 11, 15, 6, 8, 9, 10 };
            int n = intArr.Length;
            int x = 6;
            DeletArrayClass deletArrayForInt = new DeletArrayClass();


            // Delete x from arr[]
            n = deletArrayForInt.DeletArrayMethod(intArr, n, x);

            Console.WriteLine("Modified array is");
            for (int i = 0; i < n; i++)
                Console.Write(intArr[i] + " ");

            char[] charArr = { 'a', 'b', 'c', 'd', 'e', 'f' };
            int n1 = charArr.Length;
            char x1 = 'a';
            DeletArrayClass deletArrayForChar = new DeletArrayClass();


            // Delete x from arr[]
            n1 = deletArrayForChar.DeletArrayMethod(charArr, n1, x1);

            Console.WriteLine("Modified array is");
            for (int i = 0; i < n; i++)
                Console.Write(charArr[i] + " ");



            float[] floatArr = { 11.1f, 15.1f, 6.1f, 8.1f, 9.1f, 10.1f };
            int n2 = floatArr.Length;
            float x2 = 6.1f;
            DeletArrayClass deletArrayForFloat = new DeletArrayClass();


            // Delete x from arr[]
            n = deletArrayForFloat.DeletArrayMethod(floatArr, n2, x2);

            Console.WriteLine("Modified array is");
            for (int i = 0; i < n; i++)
                Console.Write(intArr[i] + " ");

        }
    }
}
