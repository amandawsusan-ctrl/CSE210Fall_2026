using System;

class Program
{
    static void Main(string[] args)
    {
        
        string input;
        Console.Write("What is your score? (Please enter the percentage as an integer) ");
        input = Console.ReadLine();
        int score = int.Parse(input);


        if (score > 130)
        {
            string letterGrade = "A+++";
            Console.WriteLine($" {score}?! I think you're lying.");

        
        }

        else if (score > 100)
        {
            string letterGrade = "A++";
            Console.WriteLine($"Wow! That's a lot of extra credit! Definitly an {letterGrade}");
        }

        else if (score >= 90)
        {
      
            if (score >= 97)
            {
                string letterGrade = "A+";
                Console.WriteLine($"Congratulaions!! You got an {letterGrade}");
            }

            else if (score> 92)
            {
                string letterGrade = "A";
                Console.WriteLine($"Congratulaions!! You got an {letterGrade}");
            }

            else if (score < 93)
            {
                string letterGrade = "A-";
                Console.WriteLine($"Congratulaions!! You got an {letterGrade}");
            }

            else
            {
                string letterGrade = "A-";
                Console.WriteLine($"Congratulaions!! You got an {letterGrade}");
            }

            

        }

        else if (score >= 80 )
        {
            string letterGrade = "B";
            Console.WriteLine($"Not bad! {letterGrade}.");

        }

        else if (score >= 70)
        {
            Console.WriteLine($"That earns you a C. Congratulations! You passed!");

        }

        else if (score >= 60)
        {
            Console.WriteLine($"I'm so sorry. A D doesn't pass.");
        }

        else if (score <60 && score > 0)
        {
            Console.WriteLine($"You flunked. :(( You'll have to retake the class");
        }

        else
        {
            Console.WriteLine($"I'm not sure what {score} means, but I think you're cooked.");
        }




        
    }
}