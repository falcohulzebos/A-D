using System;

public class Hashing
{
    //Hash function
    static int simpleHash(string s, string[] arr)
    {
        //setting the total, the total will be filled with the hash value of a string
        int tot = 0;
        //Creating an character array
        char[] cname;
        //Converting the string from the parameter to the character array
        cname = s.ToCharArray();
        for (int i = 0; i <= cname.GetUpperBound(0); i++)
        {
            //adding the hashvalues of each character to the variable tot
            tot += (int)cname[i];
        }
        return tot % arr.GetUpperBound(0);
    }
    //Here is the function where the array names is shown.
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

    public void betterHash(string s, string[] arr)
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
}
