using System;
using System.Collections.Generic;
using System.Linq;

namespace bot0001
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Hello World!");
            List<string> resPrivet = new List<string>() {"Привет", "Welcum To The Club ", "Здарова"};
            List<string> resAnekdot = new List<string>() 
            {
                "Как называется негр на велосипеде? Вор.", 
                "Какие у негра есть три белых вещи? Глаза, зубы и хозяин",
                "Что надо сделать, если вам навстречу бежит окровавленный негр?Перезарядить."
            };
            List<string> resPoka = new List<string>() {"До скорого", "Аривидерчи", "Ну пока" };

            int privIndex = rnd.Next(resPrivet.Count);
            int anekIndex = rnd.Next(resAnekdot.Count);
            int pokaIndex = rnd.Next(resPoka.Count);

            Console.WriteLine("Как тебя зовут");
            string name = Console.ReadLine();

            bool isWork = true;
            while(isWork)
            {
            string priv;
            priv = Console.ReadLine();
                switch (priv)
                {
                    case "привет":
                    case "хай":
                        Console.WriteLine("Chat Bot GAY: {0}", resPrivet[privIndex] + ' '+ name);
                        break;
                    case "прикол":
                    case "анекдот":
                        Console.WriteLine("Chat Bot GAY: {0}", resAnekdot[anekIndex]);
                        break;
                    case "пока":
                    case "до скорого":
                        Console.WriteLine("Chat Bot GAY: {0}", resPoka[pokaIndex] + ' ' + name);
                        break;
                    default:
                        Console.WriteLine("я хз кст");
                        isWork = false;
                        break;
                }
            }
        }
    }
}
