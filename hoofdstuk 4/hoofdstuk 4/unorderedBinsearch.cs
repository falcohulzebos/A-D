using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class unorderedBinsearch
{
	public unorderedBinsearch()
	{
        ArrayList Lijst = new ArrayList();
        Random rnd = new Random(100);
	}

    public void FillArray()
    {
        for(int i = 0; i<100; i++)
        {
            Lijst.Insert(rnd.Next(100));
            
        }
       
    }

    
}
