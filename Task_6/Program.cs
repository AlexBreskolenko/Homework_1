Console.Clear();

string str;
int number;

Console.Write("Enter the number : ");
str = Console.ReadLine();
number = Convert.ToInt32(str);

if (number % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
