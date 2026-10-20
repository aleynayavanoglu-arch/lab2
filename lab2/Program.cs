Console.Write("enter the score:");
int score = int.Parse(Console.ReadLine()!);
if (score >= 90&& score <= 100)
    Console.WriteLine("A");
else if (score >= 80 && score < 90)
    Console.WriteLine("B");
else if (score >= 70 && score < 80)
    Console.WriteLine("C");
else if (score >= 60 && score < 70)
    Console.WriteLine("D");
else if (score >= 0 && score < 60)
    Console.WriteLine("F");
else
    Console.WriteLine("Invalid score");




int count = 0;
int sum = 0;
int number = 0;
while(true)
{
    Console.Write("enter a number:");
    number = int.Parse(Console.ReadLine()!);
    if (number==0)
    {
        break;

    }
    sum += number;
    count++;

}
double average=(double)sum / count;
Console.WriteLine("count:" + count);
Console.WriteLine("sum:" + sum);
Console.WriteLine($"average: {average:F2}");

