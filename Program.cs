using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HMAC_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] myKey = new byte[32];

            for(int i = 0; i < myKey.Length; i++)
            {
                myKey[i] = 0x0b;
            }

            using (HMACSHA256 crypto = new HMACSHA256())
            {
                crypto.Key = myKey;

                byte[] message = new byte[]
                {

                    0x4d, 0x41, 0x43, 0x73, 0x20, 0x61, 0x72, 0x65, 0x20, 0x76, 0x65, 0x72, 0x79, 0x20, 0x75, 0x73, 0x65, 0x66, 0x75, 0x6c, 0x20, 0x69, 0x6e, 0x20, 0x63, 0x72, 0x79, 0x70, 0x74, 0x6f, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79, 0x21
                };

                byte[] hash = crypto.ComputeHash(crypto.ComputeHash(message));
                foreach(byte item in hash)
                {
                    Console.WriteLine("{0:X2}", item);
                }
            }

        }
    }
}
