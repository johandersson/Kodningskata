using PirateLang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PirateLangConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirateDecrypter = new PirateDecrypter();
            var textFileWithPirateLanguageReader = new StreamReader("pirate-encrypted.txt");
            string pirateString = textFileWithPirateLanguageReader.ReadToEnd();
            Console.WriteLine(pirateDecrypter.DecryptPirateString(pirateString));
        }
    }
}
