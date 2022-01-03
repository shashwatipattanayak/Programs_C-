using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class CharOperation
    {
        public static void occurence()
        {
            String s = "aditee";
            HashSet<char> set = new HashSet<char>();
            foreach (char c in s)
            {
                set.Add(c);
            }
            foreach (char c in set)
            {
                int count=0;
                for (int i = 0; i < s.Length; i++)
                {
                    if(s[i] == c)
                    {
                       count++;
                    }
                }
                Console.WriteLine(c +" occurence is "+ count);
            }
            
        }

        public static void uniqueChar()
        {
            String s = "aditee";
            HashSet<char> set = new HashSet<char>();
            foreach (char c in s)
            {
                set.Add(c);
            }
            foreach (char c in set)
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == c)
                    {
                        count++;
                    }
                }
                if(count ==1)
                {
                    Console.WriteLine(c + " occurence is " + count);
                }
                
            }

        }
        public static void duplicateChar()
        {
            String s = "aditee";
            HashSet<char> set = new HashSet<char>();
            foreach (char c in s)
            {
                set.Add(c);
            }
            foreach (char c in set)
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == c)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine(c + " occurence is " + count);
                }

            }

        }
        public  static void removeDuplicate()
        {
            String s = "aditee";
            HashSet<char> set = new HashSet<char>();
            foreach (char c in s)
            {
                set.Add(c);
            }
            foreach(char c in set)
            {
                Console.Write(c +" ");
            }
        }
    }
}
