// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Title = "What is your name";
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WindowHeight =40;

Console.WriteLine("What is Your Name");

string userName = Console.ReadLine();

Console.WriteLine("Hello " + userName + ", nice to meet you!");

double num01;
double num02;

Console.Write("input a number: ");
num01 = Convert.ToDouble( Console.ReadLine() );

Console.Write("input a second number: ");
num02 = Convert.ToDouble( Console.ReadLine() );

double result = num01 + num02 ;
Console.WriteLine("The Average of These numbers is " + result/2);

Console.ReadKey();