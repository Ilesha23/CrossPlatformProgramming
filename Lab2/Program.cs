﻿/*Вариант 3
Пусть дана строка, состоящая из слов, отделенных друг от друга одним и более пробелами.
Сформировать новую строку, состоящую из слов исходной строки. В словах оставить
символы, которые встречаются только один раз (в том порядке, в котором они
встречаются в слове).
Пример: «а роза упала на лапу азора», результат: «а роза упал на лапу азор»*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "а роза упала на лапу азора"; //исходная строка
            string[] temp = str.Split(); //разделение строки на массив строк, что бы неповторяющиеся символы выделялись в каждом слове отдельно
            string result = ""; //строка для записи результата в нее

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = string.Concat(temp[i].Distinct()); //удаление повторяющихся символов
                if (temp[i] != "") //проверка на пустые элементы в массиве, что бы не было лишних пробелов при соединении
                    result = string.Concat(result, " ", temp[i]); //поэлементное присоединение элементов массива в одну строку через разделитель " "
            }

            Console.WriteLine(result); //вывод результата
        }
    }
}