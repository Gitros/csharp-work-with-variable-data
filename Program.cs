string[] values = { "12,3", "45", "ABC", "11", "DEF" };
string message = "";

decimal total = 0m;

foreach (var value in values)
{
    decimal decimalNumber;
    if (decimal.TryParse(value, out decimalNumber))
    {
        total += decimalNumber;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine(message);
Console.WriteLine(total);