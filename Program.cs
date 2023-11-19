
#region Task3
{
    int a = 6;
    int factorial = 1;
    for (int x = 1; x <= a; x++)
    {
        factorial *= x;
    }
    Console.WriteLine(factorial);
}

#endregion

#region Task1

Console.Write("Enter month: ");
string monthName = Console.ReadLine();
string season = SearchSeason(monthName);

if (season != null) { Console.WriteLine(season); }
else
{
    Console.WriteLine("Incorrect month");
}
string SearchSeason(string monthname)
{
    string season = null;
    switch (monthName.ToLower())
    {
        case "january":
        case "february":
        case "march":
            season = "winter";
              

            break;
        default:
            season = null;
            break;
    }
    return season;
}

#endregion

#region Task2

Console.Write("Enter an integer value: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberOfDigits = CountDigits(number);

Console.WriteLine($"The entered number has {numberOfDigits} digits.");


static int CountDigits(int number)
{




    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }

    return count;
}

#endregion