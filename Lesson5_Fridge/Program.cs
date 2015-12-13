using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //TVset Sony = new TVset();

            //Sony.SetChannel(8);
            //Console.WriteLine(Sony.Channel);

            //Sony.NextChannel();
            //Console.WriteLine(Sony.Channel);

            //2
            //Student Vasil = new Student("Vasya", 5, 888);
            //Vasil.Info();



            //5
            Fridge Zanussi = new Fridge(false, FridgeModes.normal);
            while (true)
            {
                Console.Clear();
                Console.WriteLine(Zanussi.Info() + "\n");
                Console.WriteLine("Доступные действия: ");
                Console.WriteLine("1 - включить холодильник");
                Console.WriteLine("2 - выключить холодильник");
                Console.WriteLine("3 - нормальный режим");
                Console.WriteLine("4 - северный режим");
                Console.WriteLine("5 - южный режим");
                Console.WriteLine("e - завершить программу");

                char key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case '1':
                        Zanussi.On();
                        break;
                    case '2':
                        Zanussi.Off();
                        break;
                    case '3':
                        Zanussi.Normal();
                        break;
                    case '4':
                        Zanussi.North();
                        break;
                    case '5':
                        Zanussi.South();
                        break;

                    case 'e':
                    case 'у':
                        return;
                }
            }



        }
    }
}
