using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadraticHash
{
    class QuadraticHash
    {
        static void Main()
        {
            QuadraticHash();

        }
        static void QuadraticHash()
        {
            //Creates an Array with the optimal size of 10007
            string[] names = new string[10007];
            //creates an string where the names are put to store in the arraylist
            string name;
            //arraylist where the names are in
            string[] somenames = new string[] { "David", "David", "Donnie", "Jennifer", "Donnie", "Mayo", "Raymond", "Bernica", "Mike", "Clayton", "Beata", "Michael", "Robbin", "Patrick", "Falco", "Chris", "Andries", "Gerjan", "Drew", "Kees", "Berta", "Edward" };
            //The value that's the output of the Hash ffunction
            int hashVal;
            //Here are the values hashed and put into another array
            for (int i = 0; i < somenames.Count(); i++)
            {
                name = somenames[i];
                hashVal = betterHash(name, names);


                if (names[hashVal] != null)
                {
                    
                    names[(hashVal /2 + 1)] = name;
                }
                else
                {
                    names[hashVal] = name;
                }
            }
            //Showing all the names that are hashed and put into the array "names" with the keys and the values
            showDistrib(names);
            Console.ReadLine();
        }
        
        static int betterHash(string s, string[] arr)
        {
            //setting the total, the total will be filled with the hash value of a string
            long tot = 0;
            //Creating an character array
            char[] cname;
            //Converting the string from the parameter to the character array
            cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
            {
                //adding the hashvalues of each character to the variable tot, but here we multiply it with 37 because the spread is more equal then with the simple hash
                tot += 37 * tot + (int)cname[i];
            }
            tot = tot % arr.GetUpperBound(0);
            if (tot < 0)
            {
                tot += arr.GetUpperBound(0);
            }
            return (int)tot;
        }
        static void showDistrib(string[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                //Checking if the value isn't empty if it is nothing happens else the values are shown
                if (arr[i] != null)
                {
                    //Writing the keys and values to the console
                    Console.WriteLine(i + " " + arr[i]);
                }
            }
        }
    }

}
