using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork13
{
    static class StringHelper
    {
        static public string[] SplitTextToWords(string text)
        {
            var retVal = text.Split(' ', '.', '?');

            foreach (var item in retVal)
            {
                Console.Write(item);
            }

            return retVal;
        }
        static public string SplitTextToWords2(string text)
        {
            string textAfter = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' || text[i] == '.' || text[i] == ',' || text[i] == '?' || text[i] == '!')
                {
                   
                }
                else
                {

                    textAfter += text[i];
                }   
            }  
            return textAfter;
        }

        static public string SplitCammelCase(string text)
        {
            string textAfter = "";
            text = SplitTextToWords2(text);
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) && i !=0)
                {
                    textAfter += " " + char.ToLower(text[i]);
                }
                else
                {
                    textAfter += text[i];
                }
            }
            return textAfter;
        } 
    }
}
