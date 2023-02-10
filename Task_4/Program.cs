Console.Clear();

string str;
int num_1, num_2, num_3, max;

Console.Write("Enter the number first number : ");
str = Console.ReadLine();
num_1 = Convert.ToInt32(str);

Console.Write("Enter the number second number : ");
str = Console.ReadLine();
num_2 = Convert.ToInt32(str);

Console.Write("Enter the number third number : ");
str = Console.ReadLine();
num_3 = Convert.ToInt32(str);

if (num_1 > num_2)
{
    max = num_1;
}
else
{
    max = num_2;
}

if (max < num_3)
{
    max = num_3;
}

Console.WriteLine("Max number = " + max);