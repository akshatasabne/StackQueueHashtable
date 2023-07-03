using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueHashtable
{
    internal class Hashtablepro
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            Console.WriteLine("Enter Id And Name of 10 Students");
            id=Convert.ToInt32(Console.ReadLine());
            name = Convert.ToString(Console.ReadLine());

            Hashtable has = new Hashtable();
            has.Add(id,name);
            //has.Add(2,"ritik");
            //has.Add(3,"sumit");
           
            has.Remove(3);

            foreach (DictionaryEntry item in has)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

        }
    }
}
