using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab8._1
{
    /*Створити клас рідина, що має назву (вказівник на рядок), густину. Визначити
    конструктори, деструктор і функцію виведення даних. Створити public-похідні класи
    – спиртні напої, які мають міцність, та холодні напої, що мають температуру
    зберігання. Визначити конструктори за умовчанням і з різним числом параметрів,
    деструктори, функцію виведення. Визначити функції перепризначення міцності.*/
    class Program
    {
        static void Main(string[] args)
        {
            Liquid a = new Liquid();
            Console.WriteLine("Drink a: " + a.ToString());
            Console.WriteLine("-------------------------");
            Alc_drinks b = new Alc_drinks(3, 100);
            Console.WriteLine("Alc_drinks b: " + b.ToString());
            Console.WriteLine("Please enter some changes to Alc_drinks b: ");
            b.Read();
            Console.WriteLine("Changed Alc_drinks b : " + b.ToString());
            Console.WriteLine("-------------------------");
            Cold_drinks c = new Cold_drinks(2, 40);
            Console.WriteLine("Cold_drinks c: " + c.ToString());
            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
    }

}

