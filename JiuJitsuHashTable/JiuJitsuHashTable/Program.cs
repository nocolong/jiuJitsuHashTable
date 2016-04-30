using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuJitsuHashTable
{
    class Program
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Greg McIntyre", "Black Belt");
            ht.Add("Jade Charles", "Blue Belt");
            ht.Add("Echo Charles", "Brown Belt");
            ht.Add("Timmy Ford", "Purple Belt");
            ht.Add("Dean Lister", "Black Belt");
            ht.Add("Jeff Glover", "Black Belt");
            ht.Add("Eric Geib", "Brown Belt");
            ht.Add("Tom Dnomder", "Purple Belt");
            ht.Add("Mel Baldwin", "Black Belt");
            ht.Add("Rudy Silva", "Brown Belt");
            ht.Add("JC Depass", "Purple Belt");
            ht.Add("Juan Bernardo", "Brown Belt");
            ht.Add("Andy Burke", "Brown Belt");
            ht.Add("Brent Wirth", "Brown Belt");
            ht.Add("Dae Li", "White Belt");

            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine(e.Key.ToString(), e.Value);
            }
            Console.ReadLine();
        }
    }
}
