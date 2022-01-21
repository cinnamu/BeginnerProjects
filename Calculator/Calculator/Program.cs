int num1;
int num2;

string answer;

int result;

Console.WriteLine("Welcome to Calculator!");
Console.WriteLine("Enter your first Number.");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your second Number.");

num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What type of operation whould you like to do?");
Console.WriteLine("Please enter 'a' for addition, 's' for subtraction, 'm' for multiplication, or any other key for division");

answer = Console.ReadLine();

if(answer == "a")
{
    result = num1 + num2;
}
else if (answer == "s")
{
    result = num1 - num2;
}
else if (answer == "m")
{
    result = num1 * num2;
}
else
{
    result = num1 / num2;
}

Console.WriteLine("The result is " + result);
Console.WriteLine("Thank you for using the Calculator program!");

Console.ReadKey();