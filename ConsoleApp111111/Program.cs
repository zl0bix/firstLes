using System;
using System.ComponentModel;
using System.Runtime.Intrinsics;



namespace ConsoleApp111111
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string str = "";
            Console.Write("Enter number -> ");
            str = Console.ReadLine();          
            int n;           
                int.TryParse(str, out n);
            if (n != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }*/
            /*
             Задание 1:
        Вы задаете вопросы пользователю, по типу "как вас зовут", "какой ваш знак зодиака" и тд, после
        чего, по данным, которые он ввел, формируете небольшой текст о пользователе.
        "Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе."
             */
            Console.WriteLine("\n\n\n\t\tEx1\n");
            Console.Write("\tEnter your name-> ");
            string str1, str2;
            str1 = Console.ReadLine();
            Console.Write("\tEnter your sign of zodiac-> ");
            str2 = Console.ReadLine();
            Console.WriteLine("\tYour name is " + str1 + " Your zodiac sign is " + str2);
            /*
             Задание 2:
        На экране, в специальной зоне, выводятся картинки, по 3 в ряд (условно, ничего рисовать не
        надо). Всего у пользователя в альбоме 52 картинки. Код должен вывести, сколько полностью
        заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.
        В качестве решения ожидаются объявленные переменные с необходимыми значениями и,
        основываясь на значениях переменных, вывод необходимых данных. По задаче требуется
        выполнить простые математические действия.
             */
            Console.WriteLine("\n\n\n\t\tEx2\n");
            int lot = 52;
            int row = 3;
            Console.WriteLine("\tОтоброзиться рядов с картинками -> " + (lot / row) + " и кортинок сверх меры -> " + (lot % row));
            /*
             Задание 3:
        Даны две переменные. Поменять местами значения двух переменных. Вывести на экран
        значения переменных до перестановки и после.
        К примеру, есть две переменные имя и фамилия, они сразу инициализированные, но данные не
        верные, перепутанные. Вот эти данные и надо поменять местами через код.
             */
            Console.WriteLine("\n\n\n\t\tEx3\n");
            string strName, strSurname, strTemp;
            Console.Write("Enter SURNAME -> ");
            strName = Console.ReadLine();
            Console.Write("Enter Name -> ");
            strSurname = Console.ReadLine();
            Console.WriteLine("1st wrong" + strName + " " + strSurname);
            strTemp = strName;
            strName = strSurname;
            strSurname = strTemp;
            Console.WriteLine("2nd right" + strName + " " + strSurname);
            /*
             Задание 4:
        Вы приходите в магазин и хотите купить за своё золото кристаллы. В вашем кошельке есть
        какое-то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить?
        После сделки у вас остаётся какое-то количество золота и появляется какое-то количество
        кристаллов. При старте программы пользователь вводит начальное количество золота. Потом
        ему предлагается купить какое-то количество кристаллов по цене N(задать в программе
        самому). Пользователь вводит число и его золото конвертируется в кристаллы. Остаток золота и
        кристаллов выводится на экран.
             */
            Console.WriteLine("\n\n\n\t\tEx4\n");
        }
    }
}
