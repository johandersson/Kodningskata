using PirateLang;
using System;
using System.Collections.Generic;
using System.IO;

namespace PirateLangConsoleApp
{
    class PirateLangConsole
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
