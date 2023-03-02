using System;
using System.Linq;
namespace PirateLang
{
    public class PirateDecrypter
    {
        public PirateDecrypter()
        {
        }

        public bool? IsConsonant(char c)
        {
            string consonantsStr = "bcdfghjklmnpqrstvxz";
            if (consonantsStr.Contains(c) || consonantsStr.ToUpper().Contains(c))
            {
                return true;
            }

            return false;
        }


        public String DecryptPirateString(String pirateString)
        {
            if (string.IsNullOrWhiteSpace(pirateString))
            {
                return "";
            }

            string decryptedPirateString = "";
            int i = 0;
            while (i < pirateString.Length)
            {
                char c = pirateString[i];
                if (IsConsonant(c) == true)
                {
                    char c2 = pirateString[i + 1];
                    char c3 = pirateString[i + 2];
                    if (c == c3 && (c2 == 'o' || c2=='O'))
                    { // dubblerad konsonant
                        decryptedPirateString += c;
                        i += 3;
                    }
                }
                else
                {
                    decryptedPirateString += c;
                    i++;
                }
            }
            return decryptedPirateString;
        }
    }
}