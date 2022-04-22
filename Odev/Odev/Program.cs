using System;
using System.IO;
using System.Diagnostics;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo prostart = new ProcessStartInfo();
            prostart.Arguments = "-oX nmap -T4 -A -v 192.168.1.1/25"; //prostartın değerleri
            prostart.RedirectStandardOutput = true; //programın çıktısını yönlendiriyor
            prostart.FileName = "nmap"; //programın çıktısının adı
            Process pro = new Process();
            pro.StartInfo = prostart;
            pro.Start();
            StreamReader stdout = pro.StandardOutput; //nmap'in stdout'u çıktısının Console'a çıktısı
            StreamWriter sw = new StreamWriter("odev.txt");
            sw.WriteLine(stdout.ReadToEnd());
            pro.WaitForExit();
            Console.WriteLine("Program Bitti.");
            Console.ReadKey(true);
        }
    }
}
