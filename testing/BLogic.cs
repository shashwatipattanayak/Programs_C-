using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class BLogic
    {
        public void convertString(String words)
        {
            
            char[] wordsArr = words.ToCharArray();
            char[] newStr   = new char[wordsArr.Length + 5] ;
            int j= 0;
            for(int i =0; i < wordsArr.Length; i++)
            {
                if (char.IsUpper(wordsArr[i]))
                {
                    if (i == 0)
                    {
                        newStr[j] = char.ToLower(wordsArr[i]);
                        j++;
                        continue;
                    }
                    newStr[j] = '_';
                    newStr[++j] = char.ToLower(wordsArr[i]);
                    j++;
                    continue;
                }
                newStr[j] = wordsArr[i];
                j++;
            }
            Console.Write(newStr);
        }

        public void convertString1(String words)
        {
            char[] newStr = {} ;
            
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsUpper(words[i]))
                {
                    if (i == 0)
                    {
                        newStr[i] = words[i];
                     
                        //continue;
                    }
                    newStr[i] = '_';
                    newStr[++i] = words[i];
                    //i++;
                    continue;
                }
                newStr[i] = words[i];
                //i++;
            }
            Console.Write(newStr);
        }
    }
}
