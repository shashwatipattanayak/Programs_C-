using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class StringOperation
    {
        public static void AddOfNumInString()
        {
			String s = "15ab60@25";
			int sum = 0; int totalSum = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (char.IsDigit(s[i]))
				{
					int n = s[i] - 48;
					sum = sum * 10 + n;
				}
				else
				{
					totalSum += sum;
					sum = 0;
				}
			}
			totalSum += sum;
			Console.Write(totalSum);
		}

		public static void ConvertFirstCharIntoUpperCase()
        {
			String str = "welcome to tyss";
			String[] sArr = str.Split(" ");
			foreach(String s in sArr)
            {
				for(int i = 0; i<s.Length; i++)
                {
					if(i == 0)
                    {
						Console.Write(char.ToUpper(s[i]));
                    }
                    else
                    {
						Console.Write(s[i]);
                    }

				}
				
			}
			Console.WriteLine();
			foreach(String s in sArr)
            {
				String s1 = "" + s[0];
				Console.Write(s1.ToUpper() + s.Substring(1));
			}
		}

		public static void PrintTwoStringConcurrently()
        {
			String s = "abc" + "xyz";
			for (int i = 0; i < s.Length / 2; i++)
			{
				String s1 = "" + s[i] + s[s.Length/2 +i];

				Console.Write(s1);
			}
		}
		public static void pyramid()
        {
			String word = "welcome";
			String rev = " ";
			for (int i = 0; i < word.Length; i++)
			{

				rev += word[i];
				Console.WriteLine(rev + " ");
			}
		}

		public static void SwapStringWithoutUsingThirdVar()
        {
			String s1 = "java";
			String s2 = "selenium";
			s1 = s1 + s2;
			s2 = s1.Substring(0,s1.Length - s2.Length);
			s1 = s1.Substring(s2.Length);
			Console.WriteLine(s1);
			Console	.WriteLine(s2);
		}
	}
}
