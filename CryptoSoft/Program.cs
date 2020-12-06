using System;
using System.IO;
using System.Diagnostics;

namespace CryptoSoft
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Directory.Exists(args[1]) == false
            if (args.Length != 2 || File.Exists(args[0]) == false )
            {
                stopwatch.Stop();
                int timeExe = -1;
                //Console.WriteLine(timeExe);
                return timeExe;
            }
            else
            {
                try
                {
                    string OutputFile = args[1];
                    byte[] data = File.ReadAllBytes(args[0]);

                    byte[] key = File.ReadAllBytes(@".\key.txt");

                    for (int i = 0; i < data.Length; i++)
                    {
                        byte x = key[(byte)(i % key.Length)];
                        data[i] = (byte)(data[i] ^ x);
                    }
                    File.WriteAllBytes(OutputFile, data);

                    stopwatch.Stop();

                    int timeExe = (int)(stopwatch.Elapsed.TotalSeconds * 1000);
                    //Console.WriteLine(timeExe);
                    return timeExe;
                }
                catch
                {
                    return -1;
                }

            }
        }
    }
}
