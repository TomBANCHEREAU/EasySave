using System;
using System.IO;

namespace CryptoSoft
{
    class Program
    {
        
        static int Main(string[] args)
        {

            string OutputFile = @"C:\Users\bonne\OneDrive\Documents\cours exia\Programmation système\EasySave\OutEncryption.txt";
            byte[] data = File.ReadAllBytes(@"C:\Users\bonne\OneDrive\Documents\cours exia\Programmation système\EasySave\point d'armée.txt");

            byte[] key = File.ReadAllBytes(@"C:\Users\bonne\OneDrive\Documents\cours exia\Programmation système\EasySave\key.txt" );

            for (int i = 0; i < data.Length; i++)
            {
                byte x = key[(byte)(i % key.Length)];
                data[i] = (byte)(data[i] ^ x);
            }
            File.WriteAllBytes(OutputFile, data);

            return 4; 

        }
    }
}
