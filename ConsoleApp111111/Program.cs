using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.Intrinsics;
using System.Runtime.Serialization;



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
            Console.Write("\tEnter SURNAME -> ");
            strName = Console.ReadLine();
            Console.Write("\tEnter Name -> ");
            strSurname = Console.ReadLine();
            Console.WriteLine("\t1st wrong " + strName + " " + strSurname);
            strTemp = strName;
            strName = strSurname;
            strSurname = strTemp;
            Console.WriteLine("\t2nd right " + strName + " " + strSurname);
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
            Console.Write("\tСколько у вас золота?-> ");
            int nG = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int randPrice = r.Next(1,nG);
            Console.Write("\tСколько хотите купит кристаллов по ценне "+randPrice+" ? -> ");
            int nC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tВы купили " + nC+ " кристаллов " + " золота осталось " + (nG-(nC*randPrice)));
            /*
             Задание 5:
        Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать
        время ожидания в очереди.
        Пользователь вводит кол-во людей в очереди.
        Фиксированное время приема одного человека всегда равно 10 минутам.
        Пример ввода: Введите кол-во старушек: 14
        Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."
             */
            Console.WriteLine("\n\n\n\t\tEx5\n");
            int counter = 0;
            Console.Write("\tВведите кол-во старушек -> ");
            int numStarushka = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < numStarushka; i++)
            {
                counter++;
            }
            Console.WriteLine("\tВам ждать " + counter*10/60 + " часов и " + counter*10%60 + " минут");
        }
    }
}
