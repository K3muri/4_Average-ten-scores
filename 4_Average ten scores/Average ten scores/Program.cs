using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_ten_scores
{
    class Program
    {
        static void Main(string[] args)
        {
			// set how meany times its going to loop 
			int NumTest;

			Console.Write("Insert Number Of studins that was Testsed :  ");
			NumTest = int.Parse(Console.ReadLine());

			for (int y = 0; y < NumTest; y++)
			{
				Counter();

			}

		}

        static void Counter()
        {
            double TotalSum = 0;
            double Sum;
            double average;
            int UserTest;
			

           //set up how many "test" are going to get grade
            Console.Write("Enter Number Of Test they took  :  ");
            UserTest = int.Parse(Console.ReadLine());

			//the loop 
            for (int Tests = 0; Tests < UserTest; Tests++)
            {
				
                Console.Write($"Insert test score  {Tests + 1}:  ");
                Sum = double.Parse(Console.ReadLine());
                RestrictionRepeat(Sum, Tests);
                TotalSum += Sum;
            }

			// the math to get the average of the test
            average = Math.Round(Average(TotalSum, UserTest), 2);
			Console.WriteLine($"Your total is {average}");
            Grades(average);

            Console.ReadLine();

        }

		//if user put in a number to low or to hight it will tell them to try again
        static void RestrictionRepeat(double Total, double Add)
        {
            while (Total < 0 || Total > 100)
            {
				//Console.Write($"Insert test to Score to grades {Add + 1}:  ");
				Console.Write($"not a acceptable number must be betwen 0-100 \n" +
							  $"Insert test to Score to grades {Add + 1}: ");
                Total = double.Parse(Console.ReadLine());
            }
        }

		//this give the letter grad to the test 
        static double Average(double Avg, int z)
        {
            return Avg / z;
        }
        static void Grades(double x)
        {

            if (x <= 60)
            {
                Console.Write("You Have Failed!");
            }
            else if (x <= 70)
            {
                Console.Write("You Have Recieved a D!");
            }
            else if (x <= 80)
            {
                Console.Write("You Have Recieved a C!");
            }
            else if (x <= 90)
            {
                Console.Write("You Have Recieved a B!");
            }
            else if (x <= 100)
            {
                Console.Write("You Have Recieved an A!");
            }
        }
    }
}

