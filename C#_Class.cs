using System;

namespace ProgrammCS
{
    class MyCar   //класс с машиной и её характеристиками. Class whith car and it`s specifications
    {
        public int wheels = 4;
        public int windows = 6;
        public bool isWorking = false;
    }
    class MainClass
    {
        public static void Main(string[] args)  //функция задающая вопросы: марка машины, калёса, окна, состояние машины. function which asks about: mark car, wheels, windows, 
        {                                       //condition
            string window_many, wheels_answer, isWork, isCar;

            Console.Write("Wich car means? ");
            isCar = Console.ReadLine();

            Console.Write("1. How many wheels you whink? ");
            wheels_answer = Console.ReadLine();

            Console.Write("2. How many windows you think? ");
            window_many = Console.ReadLine();

            Console.Write("3. Is car working? ");
            isWork = Console.ReadLine();

            Check(isCar, wheels_answer, window_many, isWork);
        }
        public static void Check(string f, string a,string b,string c) //функция сверяющая ответы и выводящая их в консоль(если верно выведит true). function which checks
        {                                                              //answers and if correct print true.
            if (f == "audi")                                           //f=isCar, a=wheels_answer, b=window_many, c=isWork
            {
                bool answer_0;
                answer_0 = true;
                Console.WriteLine("0. " + answer_0);
            }
            if (a == "4")
            {
                bool answer_1;
                answer_1 = true;
                Console.WriteLine("1. " + answer_1);
            }
            if (b == "6")
            {
                bool answer_2;
                answer_2 = true;
                Console.WriteLine("2. " + answer_2);
            }
            if (c == "false")
            {
                bool answer_3;
                answer_3 = true;
                Console.WriteLine("3. " + answer_3);
            }
        }
    }
}
