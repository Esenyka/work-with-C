﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ураа, это же Маша!!!");
}
else
{
    Console.Write("Привет, " + username);
}
