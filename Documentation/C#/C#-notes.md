## C# methods

## Methods
Console.WriteLine();
Console.ReadLine();
program.Display();
addition.calculate();

- C# String Functions:
    - Enum
    - Trim()
    - Clone()
    - Random
    - Format()
    - Interpolation
    - IndexOf
    - Buffer
    - Cheked

    - [Math.Pow()](https://docs.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-6.0)


```cs
Convert
String.Format("{0:.##}", y)
Math.Round()
```


## Show numbers with n decimals

The best approach if you want to ALWAYS show two decimal places (even if your number only has one decimal place) is to use
```cs
yournumber.ToString("0.00");
decimal Debitvalue = 1156.547m;
decimal DEBITAMT = Convert.ToDecimal(string.Format("{0:F2}", Debitvalue));
```
If you want to round the decimal, look at Math.Round()
String.Format("{0:.##}", Debitvalue)
String.Format("{0:C}", Debitvalue)
