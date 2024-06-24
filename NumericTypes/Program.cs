// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is the length of your rectangle?");
double l = double.Parse(Console.ReadLine());
Console.WriteLine("What is the width of your rectangle?");
double w = double.Parse(Console.ReadLine());
double area = l * w;
Console.WriteLine("The area of the rectangle is " + area);
