using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class ArrayOperation
    {
        public static void AscendingArray()
        {
			int []a = { 25, 10, 15, 50, 40 };
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = i + 1; j < a.Length; j++)
				{
					if (a[i] > a[j])
					{
						int temp = a[i];
						a[i] = a[j];
						a[j] = temp;
					}
				}
			}
			for (int i = 0;i < a.Length; i++)
            {
				Console.WriteLine(a[i]);
				
            }
			Console.WriteLine("min " + a[0]);
			Console.WriteLine("secondMin " +a[1]);
		}


		public static void KeyBasedDisplayArray()
        {
			int []a = { 1, 0, 5, 9, 0, 0, 3 };
			int key = 3;
			for(int i = 0;i< key; i++)
            {
				int temp = a[0];
				for(int j = 1; j < a.Length; j++)
                {
					a[j - 1] = a[j];
                }
				a[a.Length - 1] = temp;
            }
			foreach (int i in a)
            {
				Console.Write(i);
            }
		}

		public static void printMaxLengthOfString()
        {
			String []str = { "hi", "maximum", "minimum", "string", "bye" };
			String max = str[0];
			for(int i = 0;	i< str.Length; i++)
            {
				if(max.Length < str[i].Length)
                {
					max = str[i];
                }
            }
			foreach(String i in str)
            {
				if(max.Length == i.Length)
					Console.Write(i);
            }
		}

		public static void segregationOfZero()
        {
			int []a = { 1, 0, 5, 9, 0, 0, 3 };
			int []b = new int[a.Length];
			int m = 0, n = a.Length - 1;
			for(int i = 0;i < a.Length; i++)
            {
				if(a[i] == 0)
                {
					b[n]=a[i];
					n--;

                }
                else
                {
					b[m]=a[i];
					m++;
                }
            }
			for(int j = 0;j < b.Length; j++)
            {
				Console.Write(b[j]);
            }
		}
	}
}
