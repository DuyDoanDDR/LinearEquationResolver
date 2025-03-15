Console.WriteLine("Linear Equation Resolver");
Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
double a;
double b;
while (true)
{
    Console.WriteLine("a :");
    if (double.TryParse(Console.ReadLine(), out a))
        break;
    else Console.WriteLine("Please enter 'a' as a number ");
}
while (true)
{
    Console.WriteLine("b :");
    if (double.TryParse(Console.ReadLine(), out b))
        break;
    else Console.WriteLine("Please enter 'b' as a number ");
}
if (a == 0)
{
    if (b == 0)
    {
        Console.WriteLine(" The solution is all x ");
    }
    else Console.WriteLine(" There is no solution ");
}
else
{
    if (b == 0)
    {
        Console.WriteLine(" The solution is 0 ");
    }
    else
    {
        double x = -b / a;
        Console.WriteLine(" The solution is: " + x);
    }
}





