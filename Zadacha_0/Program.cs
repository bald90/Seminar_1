Console.Clear(); //команда для очистки терминала
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
//Console.Write(number);
int sqr = number * number;
//Console.WriteLine("Квадрат числа " + number + " равен " + sqr); взамен строки 7, но увеличивает стороку изза пробелов
Console.WriteLine($"Квадрат числа {number} равен {sqr}");