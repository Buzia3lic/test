int er = 0;

Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());

if (num1 < 10) 
{
    er = 1;
    goto End;
}

Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());

if (num2 > 10) 
{
    er = 2;
    goto End;
}

Console.WriteLine($"Diff is: {num1} - {num2} = {num1 - num2}");

End:
switch(er)
{
    case 1:
        Console.Write("Error! Num 1 must be > 10");
        break;

    case 2:
        Console.Write("Error! Num 2 must be < 10");
        break;

    default:
    break;
}
