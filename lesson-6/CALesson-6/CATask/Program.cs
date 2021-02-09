using System;
using System.Diagnostics;

namespace CATask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Full list of running processes: ");
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id} Name: {process.ProcessName}");
            }

            Console.Write("Enter the process id or name to turn it off: ");

            try
            {
                int idProc = Convert.ToInt32(Console.ReadLine());
                Process procKill = Process.GetProcessById(idProc);
                procKill.Kill();
            }
            catch
            {
                Console.WriteLine("You entered an invalid value");
            }
        }
    }
}
