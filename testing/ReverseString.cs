using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class ReverseString
    {
        public static void reverse()
        {
            String s = "aditee";
            for (int i = s.Length-1; i >=0 ; i--)
            {
                Console.Write(s[i]);
            }
        }

        public static void reverseWithThirdVar()
        {
            String s = "belhekar";
            var rev ="";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine();
            Console.Write(rev);
        }

        public static void reverseWithoutLength()
        {
            String s = "narayangaon";
            var rev = "";
            int count = 0;
            foreach (int i in s)
            {
                count++; 
            }
            for (int i = count - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine();
            Console.Write(rev);
        }

        public static void reverseWord()
        {
            String s = "I am from pune";
            string []sArr = s.Split(' ');
            for (int i = sArr.Length-1;i>= 0; i--)
            {
                Console.Write(sArr[i] + " ");
            }
        }

        public static void reverseWordMaintainPosition()
        {
            String s = "welcome to TYSS";
            String[] words = s.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                String word = words[i]; String rev = " ";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    rev += word[j];
                }
                words[i] = rev;
                Console.WriteLine();
                Console.Write(words[i] + " ");

            }
        }
    }
}
