Console.Write("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 ) Console.WriteLine("третьей цифры нет"); 

else if(number > 999) Console.WriteLine("Вы ввели не правильное число!");

else Console.WriteLine(number % 10);