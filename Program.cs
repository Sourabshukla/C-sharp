using System.Diagnostics.Metrics;
using System.Globalization;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //string? Name = Console.ReadLine();
            //if (!string.IsNullOrEmpty(Name))
            //{
            //    Console.WriteLine(Name);
            //}
            //else
            //{
            //    Console.WriteLine("Please enter name as you didnt gave any name");
            //}
            ////Console.WriteLine($"You entered { Name}");
            ///

            //int num = 10;
            //Console.WriteLine(num);
            //Console.WriteLine("Enter the first number");
            //int num1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number"); 
            //int num2=Convert.ToInt32(Console.ReadLine());
            //int sum = num1 + num2;
            //Console.WriteLine($"The sum of the two numbers is: {sum}");


            //              double
            //double num1 = 25.3;
            //double num2 = 10.7;
            //double sum = num1 + num2;
            //Console.WriteLine($"sum of number is {sum}");

            //string myboolstring = "True";
            //bool mybool=Convert.ToBoolean(myboolstring);
            //Console.WriteLine(mybool);

            //string ll=Convert.ToString(mybool);
            //Console.WriteLine(ll.GetType());
            //Console.WriteLine(mybool);
            //Console.WriteLine(mybool.GetType());

            //int num1 = 2;
            //int num2 = 3;
            //Console.WriteLine("Addition "+ num1+num2);// This will concatenate the numbers as strings 
            // Console.WriteLine("Addition " + (num1 + num2)); // This will add the numbers as integers
            //Console.WriteLine("subtraction "+ num1-num2);// error: This will concatenate the numbers as strings
            // Console.WriteLine("subtraction " + (num1 - num2)); // This will subtract the numbers as integers
            //Console.WriteLine("multiplication " + (num1 * num2)); // This will multiply the numbers as integers
            //Console.WriteLine("division " + num1/num2); // error: This will concatenate the numbers as strings
            //c("division " + (num1 / num2)); // This will divide the numbers as integers

            //------------------------------------------------------

            // int age = 22;
            //Console.WriteLine("Enter your age");
            //try
            //{
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("you can drive");
            //    }
            //    else if (age >= 16)
            //    {
            //        if (age == 17)
            //        {
            //            Console.WriteLine("if your with parents enter y or n");
            //            string ? withParents = Console.ReadLine()?.ToLower();
            //            if(withParents=="y")
            //            {
            //                Console.WriteLine("you can drive with parents");
            //            }
            //            else if (withParents == "n")
            //            {
            //                Console.WriteLine("you cannot drive without parents");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Please enter valid input");
            //            }
            //        }
            //        //Console.WriteLine("can drive but permission required");
            //    }
            //    else if (age == 0)
            //    {
            //        Console.WriteLine("Please enter valid age");
            //    }
            //    else
            //    {
            //        Console.WriteLine("your kid maccha");
            //    }
            //}

            //catch (Exception ex)
            //{
            //    //Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            //    Console.WriteLine("An error ocurred "+ ex.Message);
            //}
            //Console.WriteLine("Please Enter a month number");
            //string Month;
            //int ? monthInput = int.Parse(Console.ReadLine()?.ToLower());
            //switch (monthInput)
            //{
            //    case 1:
            //        Month = "january";
            //        //Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Month = "february";
            //        //Console.WriteLine(monthInput +" month is " + Month);
            //        break;
            //    default:
            //        Month = "undefiend";
            //        //Console.WriteLine($"{monthInput} is {Month}");
            //        break;
            //}

            //for(int i = 10; i>0; i--)
            //{
            //    Console.WriteLine("I is "+ i);
            //}
            //in string \ is an escape character, so to print a backslash you need to use \\
            //string str ="Hi \n\n HI";
            //for(int i=0; i<str.Length; i++)
            //{
            //    if (str[i] == '\n')
            //    {
            //        Console.WriteLine("New line found at index " + i);
            //    }
            //    else
            //    {
            //        Console.WriteLine(str[i]);
            //    }
            //    //Thread.Sleep(100); // Sleep for 1 second
            //}
            //            string rocket = "";
            //            rocket =

            //"    ^\r\n" +
            //"   /^\\\r\n" +
            //"   |*|\r\n" +
            //"  /_|_\\\r\n" +
            //"   / \\\r\n" +
            //"  /___\\\r\n" +
            //"  |___|\r\n" +
            //"   | |\r\n" +
            //"  /   \\\r\n" +
            //" /_____\\\r\n" +
            //"   / \\\r\n" +
            //"  /   \\\r\n" +
            //" /_____\\";
            //            for (int i = 10; i >= 0; i--)
            //            {
            //                Console.Clear(); // Clear the console to refresh the output


            //                Console.WriteLine("i is "+ i);
            //                Console.WriteLine(rocket);
            //                rocket="\r\n" + rocket; // Add a new line before the rocket
            //                Thread.Sleep(1000); // Sleep for 1 second
            //            }
            //Console.WriteLine("The rocket landed");

            //int number = 0;
            //while (number < 10)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            //bool isgood = true;
            //while (isgood)
            //{
            //    Console.WriteLine("nice your good");
            //    isgood = false; // This will exit the loop after one iteration
            //}
            //int scrnu = (int)(Math.Floor(new Random().NextDouble()*100))+1;
            //Random random = new Random();
            //int scrnu = random.Next(1, 101); // Generates a random number between 1 and 100
            //Console.WriteLine("please enter a number");
            //int? uerInput = 0;
            //while (uerInput == "go")
            //{
            //    Console.WriteLine("excellent");
            //    uerInput = Console.ReadLine();
            //}
            //int counter = 0;
            //while (uerInput != scrnu)
            //{
            //    counter++;
            //    Console.WriteLine("enter ur guess");
            //    uerInput = int.Parse(Console.ReadLine());
            //    if (uerInput < scrnu)
            //    {
            //        Console.WriteLine("low");
            //    }
            //    else if (uerInput > scrnu)
            //    {
            //        Console.WriteLine("high");
            //    }
            //    else if (uerInput == scrnu)
            //    {
            //        Console.WriteLine("you guessed it right at "+ counter);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid number");
            //    }

            //}
            //Console.WriteLine("Welcome in the game");
            //Console.WriteLine("Enter your name");
            //string Player = Console.ReadLine();
            //Console.WriteLine($"Hello {Player}, let's start the game!");

            //Console.WriteLine("Please select the character (Krish,super,spider)");
            //string? character = Console.ReadLine();
            //Console.WriteLine($" {Player}, selected character is {character}");
            //Console.WriteLine("do you want to enter in forest pr camp (choose: Enter or exit)");
            //string? userinput = Console.ReadLine();
            //if (userinput?.ToLower() == "enter")
            //{
            //    Console.WriteLine("you selected you want to enter in forest and fun");
            //}
            //else
            //{
            //    Console.WriteLine("have a great journey");
            //}

            //bool gamecountine = true;

            //while (gamecountine) {
            //    Console.WriteLine("your in forest so select left or right");
            //    string? direction= Console.ReadLine();
            //    if(direction.ToLower() == "right")
            //    {
            //        Console.WriteLine("you found the quiz");
            //        gamecountine= false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("your in adventure");
            //        Console.WriteLine("what u want select fight or flee");
            //        string input= Console.ReadLine();

            //        if(input?.ToLower() == "fight")
            //        {
            //            Random random1 = new Random();
            //            int luck = random1.Next(1, 11);
            //            if (luck >5) 
            //            {
            //                Console.WriteLine("you beat wild");
            //                if (luck > 8)
            //                {
            //                    Console.WriteLine("wild beat dropped a tresure");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("you were attacked");
            //                gamecountine = false;
            //            }
            //        }
            //    }
            //}
            ////Console.WriteLine("game Over");
            //int counter = 0;
            //int curretScore = 0;
            //int sum = 0;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //while (counter<5);
            //try
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter score, enter -1 to finish");
            //        curretScore = Convert.ToInt32(Console.ReadLine());
            //        if (curretScore != -1)
            //        {
            //            sum += curretScore;
            //            counter++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("You have finished entering scores.");
            //        }
            //        //sum += curretScore;
            //        //counter++;
            //    } while (curretScore != -1);
            //    int average = sum / counter;
            //    Console.WriteLine("the average is " + average);
            //}catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //int i = 0;

            //for( i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == 2)
            //    {

            //        Console.WriteLine("Skipping the number 2");
            //        continue; // Skip the rest of the loop when i is 2
            //    }

            //}
            //Console.WriteLine(i);

            //int n1 = 0;


            //int n2 = 0;
            //int n3 = 0;
            //int n4 = 0;
            //int[] num = new int[4];

            //try
            //{
            //    num[0] = 5;
            //    num[1] = 6;
            //    num[2] = 7;
            //    num[3] = 8;
            //    Console.WriteLine(num[0]);
            //}catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //int[] num = { 1, 2, 3, 4 };
            //foreach (int n in num)
            //{
            //    if (n == 1)
            //    {
            //        Console.WriteLine("one");
            //    }
            //    else if (n == 2)
            //    {
            //        Console.WriteLine("two");
            //    }
            //    else if (n == 3)
            //    {
            //        Console.WriteLine("three");
            //    }
            //    else if (n == 4)
            //    {
            //        Console.WriteLine("four");
            //    }
            //    else
            //    {
            //        Console.WriteLine("number is not in range of 1 to 4");
            //    }
            //}
            //int[] num = [1,2, 3, 4, 5, 6, 7, 8, 9, 10];
            //Console.WriteLine(num[8]);

            //string[] month = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

            ////Console.WriteLine(month[5]);

            //foreach(string mnt in  month )
            //{

            //    Console.WriteLine(mnt);
            //}
            //int[,] array2d = new int[3,3];
            //int[,,] array3d = new int[3,3,3];

            //int[,] array2di = { { 1, 2}, { 4, 5 }, { 7, 8} };
            //int[,] array3di = { {1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // Console.WriteLine(array2di[1, 0]);

            //for (int i = 0; i < array2di.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array2di.GetLength(1); j++) { 
            //        Console.Write(array2di[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0]=new int[] { 1, 2, 3 };
            //jaggedArray[1] = new int[] { 4, 5, 6, 7 };
            //jaggedArray[2] = new int[] { 8, 9 };

            //for(int i = 0; i < jaggedArray.Length; i++)
            //{

            //    for(int k = 0; k < jaggedArray[i].Length; k++)
            //    {
            //        Console.Write(jaggedArray[i][k] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] array2d = new int[3, 3];
            //int[,] array2di = {
            //        { 1, 2, 3 },
            //        { 4, 5, 6 },
            //        { 7, 8, 9 }

            //      };


            //for (int i = 0; i < array2di.GetLength(0); i++)
            //{
            //    int rowsum = 0;
            //    for (int j = 0; j < array2di.GetLength(1); j++)
            //    {
            //        //Console.Write(array2di[i, j] + " ");
            //        rowsum += array2di[i, j];
            //    }
            //    Console.WriteLine(rowsum);

            //}




        }
    }
}