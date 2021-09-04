using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_Program
{
    class incryption
    {
        

            public static string Encrypt(string string_to_encrypt)
            {
                string rr = "";
                char[] charactersArray = string_to_encrypt.ToCharArray();
                int numberOFcharacters = charactersArray.Length;
                int[] nn = new int[numberOFcharacters];
                for (int x = 0; x <= numberOFcharacters - 1; x++)
                {
                    nn[x] = (char.ConvertToUtf32(charactersArray[x].ToString(), 0)) + (x * 3) + 7;
                }

                for (int x = 0; x <= numberOFcharacters - 1; x++)
                {
                    rr += Convert.ToChar(nn[x]);
                }
                return rr;
            }

            public static string Decrypt(string string_to_decrypt)
            {
                string rr1 = "";
                char[] charactersArray = string_to_decrypt.ToCharArray();
                int numberOFcharacters = charactersArray.Length;
                int[] nn = new int[numberOFcharacters];
                for (int x = 0; x <= numberOFcharacters - 1; x++)
                {
                    nn[x] = (char.ConvertToUtf32(charactersArray[x].ToString(), 0)) - (x * 3) - 7;

                }

                for (int x = 0; x <= numberOFcharacters - 1; x++)
                {
                    rr1 += Convert.ToChar(nn[x]);
                }
                return rr1;

            }
        
    }
}
