using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("basket", "sepet");
            dictionary.Add("pencil", "kalem");
            dictionary.Add("shoe", "ayakkabı");

            //Console.WriteLine(dictionary["basket"]);

            foreach(var item in dictionary) 
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("wall"));
            Console.WriteLine(dictionary.ContainsKey("shoe"));

            Console.ReadLine();
        }


    }
}








