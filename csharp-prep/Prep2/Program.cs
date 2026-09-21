using System;

class Program
{
    static void Main(string[] args)
    {
        
        string input;
        Console.Write("What is your score? (Please enter your answer as a percentage) ");
        input = Console.ReadLine();
        int score = int.Parse(input);


        if (score > 130)
        {
            Console.WriteLine($" {score}?! I think you're lying.");
        
        }

        else if (score > 100)
        {
            Console.WriteLine($"Wow! That's a lot of extra credit! Definitly an A++");
        }

        else if (score > 90)
        {
            Console.WriteLine($"Congratulaions!! You got an A");

        }

        else if (score > 80 )
        {
            Console.WriteLine($"Not bad! B.");

        }

        else if (score > 70)
        {
            Console.WriteLine($"That earns you a C. Congratulations! You passed!");

        }

        else if (score > 60)
        {
            Console.WriteLine($"I'm so sorry. a D doesn't pass");
        }

        else
        {
            Console.WriteLine($"You flunked. :(( You'll have to retake the class");
        }




        
    }
}