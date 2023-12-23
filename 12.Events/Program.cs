﻿using System.Text;
using System.Threading.Channels;

namespace _12.Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Car bmw = new Car(10,220,"BMW X3");
            bmw.CarEvent += GetInfo_CarEvent;
            //bmw.CarEventAbout += Bmw_CarEventAbout;
            //Анонімний метод
            //bmw.CarEventAbout += delegate(string message)
            //{
            //    var defaultColor = Console.ForegroundColor;
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine($"-----{message}------");
            //    Console.ForegroundColor = defaultColor;
            //};
            //Лямда вираз
            bmw.CarEventAbout += (string message) =>
            {
                var defaultColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"-----{message}------");
                Console.ForegroundColor = defaultColor;
            };
            Alert("Сало");

            for (int i = 0; i < 7; i++) 
            {
                bmw.Accelerate(50);
            }
        }
        //private static int Add(int a, int b) => a + b;
        private static void Alert(string msg) => Console.WriteLine($"---{msg}---");

        //private static void Bmw_CarEventAbout(string message)
        //{
        //    var defaultColor = Console.ForegroundColor;
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine($"-----{message}------");
        //    Console.ForegroundColor = defaultColor;
        //}

        private static void GetInfo_CarEvent(string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"-----{message}------");
            Console.ForegroundColor = defaultColor;
        }


    }
}
