/*
int NumberPower (int number, int power)
{
    int product = 1;
   
     for ( int currentPower = 1; currentPower <= power; currentPower++)
     {
         product = product * number;
     }
   
    return product;
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень, в которую нужно возвести число: ");
int userPower = Convert.ToInt32(Console.ReadLine());

int result = NumberPower(userNumber, userPower);
Console.WriteLine($"{userNumber} в степени {userPower} равно {result}");
*/


int SumOfDigits (int number)
{
    int sum = 0;

    while (number > 0)
    {
        int remainderOfDivision = number % 10;
        sum = sum + remainderOfDivision;
        number = number / 10;
    }
    
    return sum;
}

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(userNumber);
Console.WriteLine($"Сумма цифр числа {userNumber} равна {result}");




