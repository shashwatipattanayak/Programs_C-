using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class WordOperation
    {
        public static void occurence()
        {
            String s = "I am from pune now I am in banglore";
            String[] s2 = s.Split(" ");
            HashSet<String> set = new HashSet<String>();
            foreach (String str in s2)
            {
                set.Add(str);
            }
            foreach (String str in set)
            {
                int count=0;
                for(int i=0; i<s2.Length; i++)
                {
                    if (str.Equals(s2[i]))
                    {
                        count++;
                    }
                }
                Console.WriteLine(str +" occurence of " +count);
            }
        }
        public static void duplicate()
        {
            String s = "I am from pune now I am in banglore";
            String[] s2 = s.Split(" ");
            HashSet<String> set = new HashSet<String>();
            foreach (String str in s2)
            {
                set.Add(str);
            }
            foreach (String str in set)
            {
                int count = 0;
                for (int i = 0; i < s2.Length; i++)
                {
                    if (str.Equals(s2[i]))
                    {
                        count++;
                    }
                }
                if(count>1)
                Console.WriteLine(str + " occurence of " + count);
            }
        }
        public static void unique()
        {
            String s = "I am from pune now I am in banglore";
            String[] s2 = s.Split(" ");
            HashSet<String> set = new HashSet<String>();
            foreach (String str in s2)
            {
                set.Add(str);
            }
            foreach (String str in set)
            {
                int count = 0;
                for (int i = 0; i < s2.Length; i++)
                {
                    if (str.Equals(s2[i]))
                    {
                        count++;
                    }
                }
                if(count == 1)
                {
                    Console.WriteLine(str + " occurence of " + count);

                }
            }
        }

        public static void removeDuplicate()
        {
            String s = "I am from pune now I am in banglore";
            String[] s2 = s.Split(" ");
            HashSet<String> set = new HashSet<String>();
            foreach (String str in s2)
            {
                set.Add(str);
            }
            foreach (String str in set)
            {
                
                    Console.WriteLine(str);

            }
        }

    }
}
