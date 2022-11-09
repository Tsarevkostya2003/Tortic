using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Tortik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int position = 2;
            int position1 = 2;
            int iItogPrice = 0;
            string sItog = "Заказ:";
            ConsoleKeyInfo key;
            ConsoleKeyInfo key1;
            List<string> aMain = new List<string>() { "  Форма торта", "  Размер торта", "  Вкус коржей", "  Количество коржей", "  Глазурь", "  Декор", "  Конец заказа" };

            Zakaz zak = new Zakaz();
            zak.infomenu(zak);   //заполнили данные
            zak.Menu1(aMain); // отрисовать 1 меню
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("->");

            while (true)
            {
                key = Console.ReadKey(); // нажали клавишу

                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (key.Key == ConsoleKey.Enter)
                {

                    if (position == 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Сохраняем информацию в файл. Нажмите любую клавишу.");
                        zak.Zapis(sItog,iItogPrice);
                        sItog = "Заказ:";
                        iItogPrice = 0;
                        Console.ReadKey();
                    }
                    else
                    {

                        do   // цикл второго меню
                        {

                            zak.Menu2(zak, position);  //рисуем второе меню
                            Console.SetCursorPosition(0, position1);
                            Console.WriteLine("->");
                            key1 = Console.ReadKey();


                            if (key1.Key == ConsoleKey.UpArrow)
                            {
                                position1--;
                            }
                            else if (key1.Key == ConsoleKey.DownArrow)
                            {
                                position1++;
                            }
                            else if (key1.Key == ConsoleKey.Enter)
                            {
                                iItogPrice = iItogPrice + zak.Itog(position, position1, zak);
                                sItog = sItog + zak.ItogS(position, position1, zak) + "-" + zak.Itog(position, position1, zak) + "; ";
                            }

                        }
                        while ((key1.Key != ConsoleKey.Escape) & (key1.Key != ConsoleKey.Enter));

                    }
                }
                Console.Clear();
                zak.Menu1(aMain);  //Отрисовывем 1 меню
                Console.WriteLine(sItog);
                Console.WriteLine("Полная цена" + iItogPrice+" рублей");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            }

        }


       


    }
}