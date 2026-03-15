using System;

namespace TP_MODUL4_103022400095
{
    class Program
    {
        static void Main()
        {
            KodePos kp = new KodePos();

            Console.WriteLine("Batununggal: " + kp.getKodePos("Batununggal"));
            Console.WriteLine("Kujangsari: " + kp.getKodePos("Kujangsari"));
            Console.WriteLine("Mengger: " + kp.getKodePos("Mengger"));
            Console.WriteLine("Wates: " + kp.getKodePos("Wates"));
            Console.WriteLine("Cijaura: " + kp.getKodePos("Cijaura"));
            Console.WriteLine("Jatisari: " + kp.getKodePos("Jatisari"));
            Console.WriteLine("Margasari: " + kp.getKodePos("Margasari"));
            Console.WriteLine("Sekejati: " + kp.getKodePos("Sekejati"));
            Console.WriteLine("Kebonwaru: " + kp.getKodePos("Kebonwaru"));
            Console.WriteLine("Maleer: " + kp.getKodePos("Maleer"));
        }
    }
}