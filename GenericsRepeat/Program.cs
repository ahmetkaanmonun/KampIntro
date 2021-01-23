using System;
using System.Collections.Generic;

namespace GenericsRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            MyList<string> sehirler2 = new MyList<string>();
            
            sehirler2.Add("Ankara");
            sehirler2.Add("Istanbul");
            Console.WriteLine(sehirler2.Count);

        }
    }
}
