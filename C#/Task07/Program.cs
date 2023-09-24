Console.WriteLine("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 10;
Console.Write($"Последняя цифра вашего числа - {lastDigit}");
