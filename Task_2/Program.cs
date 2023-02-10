Console.Clear();

string str;
int num_1, num_2;

Console.Write("Enter the first number : ");
str = Console.ReadLine();

num_1 = Convert.ToInt32(str);

Console.Write("Enter the second number : ");
str = Console.ReadLine();

num_2 = Convert.ToInt32(str);

if (num_1 > num_2)
{
    Console.WriteLine("Max number = " + num_1);
}
else
{
    Console.WriteLine("Max number = " + num_2);
}