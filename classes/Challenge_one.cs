public class Challenge_one
{
    public void PrintNumbers()
    {
 
        for(int number = 1; number < 11; number++) 
        {
            Console.WriteLine(number);
        }
        
    }

    public void PrintStrings(string[] arr)
    {
        foreach(string lol in arr)
        {
            Console.WriteLine(lol); 
        }
        /* Todo: Print out each string that is passed to the array as an argument*/
    }

    public void CheckIfNumberIsPositiveOrNegative(int number)
    {
        if(number == 0)
        {
            Console.WriteLine("\nNumber is zero\n");
        }

        else if (number > 0)
        {
            Console.WriteLine("\nNumber is positive\n");
        }

        else  
        {
           Console.WriteLine("\nNumber is negative\n");
        }
        
                /*
        Todo: Check if a number is positive, negative or zero.
        */
    }


}