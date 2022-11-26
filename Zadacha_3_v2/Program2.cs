//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.Clear();
Console.Write("Введите порядковый номер дня недели: "); 
int number = int.Parse(Console.ReadLine());

string[] days = new string[8];
days[0] = "не такого дня!";

days[1] = "Понедельник";
days[2] = "Вторник";
days[3] = "Среда";
days[4] = "Четверг";
days[5] = "Пятница";
days[6] = "Суббота";
days[7] = "Воскресенье";

Console.WriteLine($"День {number}: {days[number]}");