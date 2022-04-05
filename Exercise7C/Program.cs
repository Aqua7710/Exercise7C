double sideA, sideB, sideC;
Console.WriteLine("Hello user! This program will ask for the lengths of three sides of a triangle as inputs and then it will \ncalculate whether or not the triangle is a right angled triangle.");
Console.Write("\nLength A = ");
sideA = Convert.ToDouble(Console.ReadLine());
sideA = Math.Pow(sideA, 2);
while(sideA < 0)
{
   Console.Write("Invalid input! Try again = ");
   sideA = Convert.ToDouble(Console.ReadLine());
   sideA = Math.Pow(sideA, 2);
}
Console.Write("\nLength B = ");
sideB = Convert.ToDouble(Console.ReadLine());
sideB = Math.Pow(sideB, 2);
while (sideB < 0)
{
    Console.Write("Invalid input! Try again = ");
    sideB = Convert.ToDouble(Console.ReadLine());
    sideB = Math.Pow(sideB, 2);
}
Console.Write("\nLength C = ");
sideC = Convert.ToDouble(Console.ReadLine());
sideC = Math.Pow(sideC, 2);
while (sideC < 0)
{
    Console.Write("Invalid input! Try again = ");
    sideC = Convert.ToDouble(Console.ReadLine());
    sideC = Math.Pow(sideC, 2);
}

if (sideA * sideA == sideB * sideB + sideC * sideC || sideB * sideB == Math.Pow(sideA, 2) + Math.Pow(sideC, 2) || Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
{
    Console.WriteLine("\n\nThis is a Right Angled Triangle");
}
else
{
    Console.WriteLine("\n\nThis is not a right angled triangle");
}


