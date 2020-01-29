using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_C_Sharp
{
    class SimpleCipher
    {
        public static void Test()
        {
            Console.WriteLine(Cipher("ab cd", 3));
            Console.WriteLine(Cipher("abcd", 4));
            Console.WriteLine(Cipher("abcd", 5));
            Console.WriteLine(Cipher("abcd", 6));
            Console.WriteLine(Decipher(Cipher("abcd", 6), 6));

            Console.ReadLine();
        }

        public static string Cipher(string menssage, int shift)
        {
            char[] messageArr = menssage.ToCharArray();
            int firstCharIdx = 'a';
            int offSet = ('z' - 'a') + 1; // number of letters in alphabet
            for(int i =0; i< messageArr.Length; i++)
            {
                char oldCharIdx = messageArr[i];
                int oldIdxInAlphabet = oldCharIdx - firstCharIdx;
                int newIdxAlphabet = (oldIdxInAlphabet + shift) % offSet;
                char newCharIdx = (char)(firstCharIdx + newIdxAlphabet);
                messageArr[i] = newCharIdx;
            }
            return string.Concat(messageArr);
        }

        public static string Decipher(string cipheredMessage, int shift)
        {
            return Cipher(cipheredMessage, -shift);
        }
    }
}
