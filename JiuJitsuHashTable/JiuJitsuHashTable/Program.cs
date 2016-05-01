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
            //new instance of a hashtable class,
            //then added key value pairs to it.
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

            //Using DictionaryEntry to loop through all entries in the table.
            foreach (DictionaryEntry e in ht)
            {
                Console.WriteLine("{0}, {1}", e.Key, e.Value);
            }
            Console.WriteLine();
            //if the table doesn't contain key Kyla McIntyre, add it to the table.
            if (!ht.ContainsKey("Kyla McIntyre"))
            {
                ht.Add("Kyla McIntyre", "Pink Belt");
                //Prints the value of the added key.
                Console.WriteLine("Belt value added for Kyla McIntyre : {0}", ht["Kyla McIntyre"]);
            }
            Console.WriteLine();
            //look up the value of key Greg McIntyre
            string value = (string)ht["Greg McIntyre"];
            Console.WriteLine("Belt value for Greg McIntyre is : {0}", value);

            Console.WriteLine();
            //Using ArrayList to store the keys.
            ArrayList aL = new ArrayList(ht.Keys);
            foreach (string key in aL)
            {
                Console.WriteLine(key);
            }
            Console.ReadLine();
        }
    }
}
