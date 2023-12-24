using System;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Collections;

namespace CodigoUnicoPC
{
    class Program
    {
        // Entry point of the program
        public static void Main(string[] args)
        {
            // Get CPU ID and generate a key based on its length
            string cpu = GetCPUId();
            string key = GetKey(cpu.Length);

            // Display the generated ID and Key
            Console.WriteLine("ID:" + cpu + "//KEY:" + key);

            // Wait for user input before exiting
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

        // Method to retrieve the CPU ID
        public static string GetCPUId()
        {
            string cpuInfo = String.Empty;
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();

            // Loop through all instances of the Win32_Processor class
            foreach (ManagementObject mo in moc)
            {
                // Only return ProcessorId from the first CPU
                if (cpuInfo == String.Empty)
                {
                    cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                }
            }
            return cpuInfo;
        }

        // Method to generate a random key of a given length
        public static string GetKey(int cant)
        {
            Random r = new Random();
            string[] abc = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                            "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S",
                            "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2",
                            "3", "4", "5", "6", "7", "8", "9"};

            // Build a random key by selecting characters from the 'abc' array
            string c = "";
            for (int i = 0; i < cant; i++)
            {
                c += abc[r.Next(0, abc.Length)];
            }
            return c;
        }
    }
}

