using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] lowerBytes = { 222, 168, 2, 1 };
            byte[] upperBytes = { 222, 168, 5, 10 };

            {
                byte[] addressBytes = { 222, 169, 3, 5 };
                Console.WriteLine("Lies :" + IPLiesInRange(lowerBytes, upperBytes, addressBytes));
            }

            {
                byte[] addressBytes = { 222, 168, 3, 5 };
                Console.WriteLine("Lies :" + IPLiesInRange(lowerBytes, upperBytes, addressBytes));
            }

            Console.ReadLine();
        }

        public static bool IPLiesInRange(byte[] lowerBytes, byte[] upperBytes, byte[] addressBytes)
        {
            int start = BitConverter.ToInt32(lowerBytes.Reverse().ToArray(), 0);
            int end = BitConverter.ToInt32(upperBytes.Reverse().ToArray(), 0);
            int add = BitConverter.ToInt32(addressBytes.Reverse().ToArray(), 0);
            return ((start <= add) && (add <= end));
        }
    }
}