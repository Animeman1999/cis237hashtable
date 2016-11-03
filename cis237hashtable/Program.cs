using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericHashMap<int, string> ValleyNumToName = new GenericHashMap<int, string>();

            //this is the built in C# version
            Dictionary<int, string> ValleyNumToNameDictionary = new Dictionary<int, string>();

            Console.SetBufferSize(80, 1200);

            Console.WriteLine("Adding some entries to the HashMap");
            Console.WriteLine("EX: valleyNumToName.Put (45678, \"Jean-Luc Picard\")");

            ValleyNumToName.Put(12345, "James Kirk");
            ValleyNumToName.Put(23456, "Benjamin Sisko");
            ValleyNumToName.Put(34567, "Kathryn Janeway");
            ValleyNumToName.Put(45678, "Jean-Luc Picard");
            ValleyNumToName.Put(56789, "Jonathoan Archer");

            Console.WriteLine("The created hast table");
            Console.WriteLine(ValleyNumToName.ToString());
            Console.WriteLine();
            Console.WriteLine("The full array as it got filled out");
            Console.WriteLine(ValleyNumToName.ShowArrays());
            Console.WriteLine();
                



            Console.WriteLine("********************************************");
            Console.WriteLine("ValleyNumeToName.get(45678");
            Console.WriteLine(ValleyNumToName.Get(45678));
            Console.WriteLine();

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine("What if we add 2 entries to the hash table map to the ");
            Console.WriteLine("same locatoin?");
            Console.WriteLine("ValleyNumToName.Put(26189, \"First Entry\")");
            ValleyNumToName.Put(26189, "First Entry");
            Console.WriteLine("ValleyNumToName.Put(26092, \"Second Entry\")");
            ValleyNumToName.Put(26092, "Second Entry");

            // Print the Hash table and array
            Console.WriteLine("The created hast table");
            Console.WriteLine(ValleyNumToName.ToString());
            Console.WriteLine();
            Console.WriteLine("The full array as it got filled out");
            Console.WriteLine(ValleyNumToName.ShowArrays());
            Console.WriteLine();



            Console.WriteLine("Let's try to get out the first entry");
            Console.WriteLine("It should not exist since it was overwritten");
            Console.WriteLine("by the second entry. Therfore retriving the first");
            Console.WriteLine("will actually retrun the second");
            Console.WriteLine();
            Console.WriteLine("VallyeNumtToName.Get(26189)");
            Console.WriteLine(ValleyNumToName.Get(26189));

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Add some entries to build in c# Dictionary");


            Console.WriteLine("Adding some entries to the HashMap");
            Console.WriteLine("EX: valleyNumToName.Add (45678, \"Jean-Luc Picard\")");

            ValleyNumToNameDictionary.Add(12345, "James Kirk");
            ValleyNumToNameDictionary.Add(23456, "Benjamin Sisko");
            ValleyNumToNameDictionary.Add(34567, "Kathryn Janeway");
            ValleyNumToNameDictionary.Add(45678, "Jean-Luc Picard");
            ValleyNumToNameDictionary.Add(56789, "Jonathoan Archer");

            Console.WriteLine("The created hast table");
            var theArray = (ValleyNumToNameDictionary.ToArray());
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine("[" + i + "]- " + theArray[i] + "\n");
            }
            Console.WriteLine();
            Console.WriteLine("The full array as it got filled out");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine("[" + i + "]- " + theArray[i] + "\n");
            }
            Console.WriteLine();




            Console.WriteLine("********************************************");
            Console.WriteLine("ValleyNumeToName.TryGetValue(45678");
            string theValueIwant;
            ValleyNumToNameDictionary.TryGetValue(45678, out theValueIwant);
            Console.WriteLine(theValueIwant);
            Console.WriteLine();

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            Console.WriteLine("*********************************************");
            Console.WriteLine();
            Console.WriteLine("What if we add 2 entries to the hash table map to the ");
            Console.WriteLine("same locatoin?");
            Console.WriteLine("ValleyNumToName.Put(26189, \"First Entry\")");
            ValleyNumToNameDictionary.Add(26189, "First Entry");
            Console.WriteLine("ValleyNumToName.Put(26092, \"Second Entry\")");
            ValleyNumToNameDictionary.Add(26092, "Second Entry");

            // Print the Hash table and array
            Console.WriteLine("The created hast table");
            ValleyNumToNameDictionary.TryGetValue(45678, out theValueIwant);
            Console.WriteLine(theValueIwant);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The full array as it got filled out");
            ValleyNumToNameDictionary.TryGetValue(45678, out theValueIwant);
            Console.WriteLine(theValueIwant);
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Let's try to get out the first entry");
            Console.WriteLine("It should not exist since it was overwritten");
            Console.WriteLine("by the second entry. Therfore retriving the first");
            Console.WriteLine("will actually retrun the second");
            Console.WriteLine();
            Console.WriteLine("VallyeNumtToName.Get(26189)");
            ValleyNumToNameDictionary.TryGetValue(45678, out theValueIwant);
            Console.WriteLine(theValueIwant);
            Console.WriteLine();

        }
    }
}
