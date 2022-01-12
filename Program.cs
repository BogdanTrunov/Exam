﻿using System;
/*
    Задание 9 - вариант 1.
    Т.к. C# - полностью ООП ЯП, создан класс Program, метод Main (Является точной входа в программу), где 
    в цикле While объявлены переменные, к которым присвоены результаты выполения методов (функций), а именно: 
    1. Метод func является основным методом решения данного варианта работы (в нем прописаны через условные 
        операторы условия выполнения варианта работы);

    2. Метод Round класса Math, входящий в состав пространства имен System (в первой строчке объявлен 
       через ключевое слово using (По простому - библиотека))
       работает с математическими функциями (Возведение в степень, округление результата);

    3. Вывод информации осуществляется с использованием метода WriteLine класса Console.
 */

namespace Lessons
{
    //namespace Lesson - автоматически VS создал такое пространство имен. В данной программке его можно убрать. Но для объема его оставил
    class Program
    {
        //Код ниже - создание статических переменных типа double
        static double x = -3;
        static double y = 8.1;
        static double dx = 0.3;
        static double function_result;
        static double F;
        // Код ниже - объявление метода func, аргументами которого являются переменнные arg1 и arg2 типов double, возвращаемый тип double
        // При соблюдении условия (см. параметры условных операторов) переменная function_result принимает значение, прописанные в варианте работы
        public static double func(double arg1, double arg2)
        {
            if (arg1 < -0.9)
            {
                function_result = 3 * arg1 + arg1 - 6;
            }
            else if (arg1 >= - 0.9 && arg1 <= 0.9)
            {
                function_result = 74 * arg2;
            }
            else if (arg1 > 0.9)
            {
                function_result = (Math.Pow((arg2), (arg1 + 1))  - 5 * arg1);
            }
            return function_result;
        }
        // Код ниже - точка входа в программу
        static void Main(string[] args)
        {
            while (x <= 2)
            //Про цикл while написать нечего. Выбрал его для простоты. for слишком громоздкий, лень писать
            {
                // В переменную F прсваивается результат работы метода func (принимает значение переменной function_result из метода func)
                F = func(x, y);  
                Console.WriteLine("X= " + x + " F= " + Math.Round(F, 5));
                x = Math.Round(x, 5) + dx;
            }
        }
    }
}