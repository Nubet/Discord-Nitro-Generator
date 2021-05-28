using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;

namespace Name
{
    class Program
    {
        public static string Nitro;

        static void Main(string[] args)

       
        {
                            int lenght = 16;
                            var range = "123AbCcDdEeFfGgHhIiJjKkLlMm789NnOoPpQqRrSsTt0UuVvWwXxYyZz456";
                            var GenerujRandomowyString = new Random();
                            string Nitro;
            
                            Nitro = "https://discord.gift/"+ new string(
                            Enumerable.Repeat(range, lenght)
                           .Select(s => s[GenerujRandomowyString.Next(s.Length)])
                           .ToArray());
                          
        }
                             
        
    }
}
    //a piece of my code                                                                        
