using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GrannyXMLDecryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Drag a file here and press enter: ");
            string path;
            path = Console.ReadLine();
            Console.WriteLine("Decrypting...");
            Console.WriteLine("");
            Console.WriteLine("");
            byte[] file = File.ReadAllBytes(path);
            for (int i = 0; i < file.Length; i += 16) file[i] -= 98;
            for (int i = 1; i < file.Length; i += 16) file[i] -= 56;
            for (int i = 2; i < file.Length; i += 16) file[i] -= 51;
            for (int i = 3; i < file.Length; i += 16) file[i] -= 100;
            for (int i = 4; i < file.Length; i += 16) file[i] -= 111;
            for (int i = 5; i < file.Length; i += 16) file[i] -= 112;
            for (int i = 6; i < file.Length; i += 16) file[i] -= 50;
            for (int i = 7; i < file.Length; i += 16) file[i] -= 55;
            for (int i = 8; i < file.Length; i += 16) file[i] -= 55;
            for (int i = 9; i < file.Length; i += 16) file[i] -= 105;
            for (int i = 10; i < file.Length; i += 16) file[i] -= 112;
            for (int i = 11; i < file.Length; i += 16) file[i] -= 111;
            for (int i = 12; i < file.Length; i += 16) file[i] -= 114;
            for (int i = 13; i < file.Length; i += 16) file[i] -= 107;
            for (int i = 14; i < file.Length; i += 16) file[i] -= 54;
            for (int i = 15; i < file.Length; i += 16) file[i] -= 50;
            Console.Write(System.Text.Encoding.ASCII.GetString(file));
            File.WriteAllBytes(path + "_decrypted.txt", file);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Decryption finished (I think)");
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
        }
    }
}
