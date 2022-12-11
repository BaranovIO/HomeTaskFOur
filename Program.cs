
int NumberPower (int number, int power)
{
    int product = 1;
   // int currentPower = 1;
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