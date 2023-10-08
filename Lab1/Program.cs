using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Lab1
{
    class Program
    {

        static void Main(string[] args)
        { 
            Console.WriteLine(" Введите скорость км/ч");
            var speed = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine(" Введите время ч");
            var time = Convert.ToDouble(Console.ReadLine());



            int distance  = Calculate.CalculateSpeed(time, speed) ;
            Console.WriteLine("Пройденное расстояние " + distance + "км");

        }
    }

   
}