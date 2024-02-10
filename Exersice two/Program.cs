// See https://aka.ms/new-console-template for more information

Console.WriteLine("The area of a triangle");
int Base, height;
Console.WriteLine("Write a base: ");
Base = int.Parse (Console.ReadLine ());

Console.WriteLine("Write a height: ");
height = int.Parse (Console.ReadLine ());

int area;
area= Base *  height / 2;

Console.WriteLine("You area is: " + area);
Console.WriteLine("Thanks!!");
Console.ReadLine ();
