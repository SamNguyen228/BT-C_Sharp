using System;

class Program
{
    static void Main()
    {
        int day;
        bool isValid;

        do
        {
            Console.Write("Input your choice (1 - 7): ");

            isValid = int.TryParse(Console.ReadLine(), out day);
            if (isValid && day >= 1 && day <= 7)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please input again.");
                isValid = false; 
            }

        } while (!isValid);
    }
}
