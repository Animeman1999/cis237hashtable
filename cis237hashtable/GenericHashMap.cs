using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class GenericHashMap<TKey, Tvalue>
    {
        //Declare a constant for the prime value ot use in the hash function
        private const int PRIME_VALUE = 97;

        //Declare an array for the values
        Tvalue[] theValues;
        TKey[] theKeys;


        //Constructor
        public GenericHashMap()
        {
            //Instanciate the array
            theValues = new Tvalue[PRIME_VALUE];
            theKeys = new TKey[PRIME_VALUE];
        }

        //Put function to put a key value pair into the array/hash table
        public void Put(TKey key, Tvalue value)
        {
            //get the index to put the value into
            int indexForValue = hashFunction(key);

            //put the key into the keys array
            //This part is not needed, but we are doing it so that we can
            //output the keys when we print the hash table out
            theKeys[indexForValue] = key;

            //Store the value into the arry
            theValues[indexForValue] = value;

        }

        //Get a value out using the passed in key
        public Tvalue Get(TKey key)
        {
            //get the index to put the value into
            int indexForValue = hashFunction(key);

            //Get the value out of the array with the calculated key
            return theValues[indexForValue];
        }

        public override string ToString()
        {
            string returnString = "Key     => value\n";
            returnString += "-------------\n";
            for(int i = 0; i < theValues.Length; i++)
            {
                if (theValues[i] != null)
                {
                    returnString += theKeys[i] + " =>" + theValues[i] + "\n";
                }
            }
            return returnString;
        }

        public  string ShowArrays()
        {
            string returnString = "IDx - Key     => value\n";
            returnString += "-------------\n";
            for (int i = 0; i < theValues.Length; i++)
            {
                returnString += "[" + i + "]- " + theKeys[i] + " =>" + theValues[i] + "\n";
                    }
            
            return returnString;
        }
        //Ye ol has function
        private int hashFunction(TKey key)
        {
            //This allows you translate any object into an integer.
            //Use the built in GetHashCode method that comes from object
            //to get an integer value that can be modded with the privevalue
            //This will give us an integer between 0 and the PRIME_VALUE;
            return key.GetHashCode() % PRIME_VALUE;
        }
    }
}
