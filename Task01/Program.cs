int number = new Random().Next(10, 100);
Console.WriteLine($"Cлучайное число из отрезка 10 - 100 => {number}");

//int festDigit = number / 10;
//int secondDigit = number % 10;

//if (festDigit > secondDigit)
//    Console.WriteLine($"Наибольша цифра числа -> {festDigit}");
//else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");


int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}