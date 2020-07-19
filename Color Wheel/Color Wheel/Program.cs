using System;
namespace Color_circle
{
    class Wheel
    {
        static void Privet()//вступительные слова с правилами и возможностями
        {
            Console.WriteLine("\t\t\t   Здравствуй, Дорогой Друг!\n\t     Я - 'цветовой круг' и помогу тебе найти Гармонию цвета!");
            System.Threading.Thread.Sleep(1000 * 1);
            Console.WriteLine("\t\t\tЯ имею в своей палитре 12 цветов\n");
            System.Threading.Thread.Sleep(1000 * 1);
            Console.WriteLine("\t\t    Напиши мне любой цвет из перечисленных \n\t      и я назову тебе идеально гармоничный цвет для него!");
            System.Threading.Thread.Sleep(1000 * 1);
            Console.WriteLine("1)Красный\n2)Красно-Оранжевый\n3)Оранжевый\n4)Жёлто-Оранжевый\n5)Жёлтый\n6)Жёлто-Зелёный\n7)Зелёный\n8)Сине-Зелёный\n9)Синий\n10)Сине-Фиолетовый\n11)Фиолетовый\n12)Красно-Фиолетовый");
            System.Threading.Thread.Sleep(1000 * 3);
            Console.WriteLine("\t\tНапиши цвет ВТОЧНОСТИ, как он написан в списке выше, \n\t\t\tлибо же напиши цифру из списка выше!\n\t\t      Для выхода из программы введи число 0!");
            System.Threading.Thread.Sleep(1000 * 1);
        }
        static void DoIt(string x)//обработка введёных данных и вывод ответа
        {
            switch (x)
            {
                case "1)Красный":
                case "Красный":
                case "1":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Зелёный", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "2)Красно-Оранжевый":
                case "Красно-Оранжевый":
                case "2":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Сине-Зелёный", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "3)Оранжевый":
                case "Оранжевый":
                case "3":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Синий", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "4)Жёлто-Оранжевый":
                case "Жёлто-Оранжевый":
                case "4":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Сине-Фиолетовый", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "5)Жёлтый":
                case "Жёлтый":
                case "5":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Фиолетовый", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "6)Жёлто-Зелёный":
                case "Жёлто-Зелёный":
                case "6":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Красно-Фиолетовый", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "7)Зелёный":
                case "Зелёный":
                case "7":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Красный", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "8)Сине-Зелёный":
                case "Сине-Зелёный":
                case "8":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Красно-Оранжевый", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "9)Синий":
                case "Синий":
                case "9":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Оранжевый", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "10)Сине-Фиолетовый":
                case "Сине-Фиолетовый":
                case "10":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Жёлто-Оранжевый", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "11)Фиолетовый":
                case "Фиолетовый":
                case "11":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Жёлтый", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                case "12)Красно-Фиолетовый":
                case "Красно-Фиолетовый":
                case "12":
                    Console.WriteLine("Ты выбрал {0}, а значит гармоничным будет Жёлто-Зелёный", x);
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nТы ввёл ' {0} '\n", x);
                    Console.WriteLine("Прости, но такого варианта нет в моей палитре. \nПосмотри внимательнее, либо обрати внимание на опечатки!");
                    System.Threading.Thread.Sleep(1000 * 5);
                    Console.Clear();
                    break;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Privet();
                Console.Write("\nЯ ХОЧУ ЦВЕТ ");
                var vvod = Console.ReadLine();
                if (vvod == "0")
                    break;
                DoIt(vvod);
            }
        }
    }
}
