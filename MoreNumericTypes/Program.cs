// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many miles have you driven? ");
int miles = int.Parse(Console.ReadLine());
Console.WriteLine("How many gallons of gas have you used? ");
int gas = int.Parse(Console.ReadLine());
int mpg = miles / gas;
Console.WriteLine("Your mpg for this trip was " + mpg);
