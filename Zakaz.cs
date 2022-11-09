using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Tortik
{
    internal class Zakaz
    {

        public Tort forma1 = new Tort();
        public Tort forma2 = new Tort();
        public Tort forma3 = new Tort();
        public Tort razmer1 = new Tort();
        public Tort razmer2 = new Tort();
        public Tort razmer3 = new Tort();
        public Tort vkus1 = new Tort();
        public Tort vkus2 = new Tort();
        public Tort vkus3 = new Tort();
        public Tort colCorgey1 = new Tort();
        public Tort colCorgey2 = new Tort();
        public Tort colCorgey3 = new Tort();
        public Tort glazur1 = new Tort();
        public Tort glazur2 = new Tort();
        public Tort glazur3 = new Tort();
        public Tort dekor1 = new Tort();
        public Tort dekor2 = new Tort();
        public Tort dekor3 = new Tort();




        public void Menu1(List<string> aaL) // 1 меню
        {
            Console.WriteLine("Программа заказ тортов");
            Console.WriteLine("----------------------");

            for (int i = 0; i < aaL.Count; i++)
            {
                Console.WriteLine(aaL[i]); // выводим элементы меню из массива
            }


        }
        public void infomenu(Zakaz zak1)   //2 меню
        {
            zak1.forma1.sOpis = "Круг   ";
            zak1.forma1.iPrice = 500;
            zak1.forma2.sOpis = "Квадрат";
            zak1.forma2.iPrice = 600;
            zak1.forma3.sOpis = "Овал   ";
            zak1.forma3.iPrice = 750;
            zak1.razmer1.sOpis = "Маленький";
            zak1.razmer1.iPrice = 1000;
            zak1.razmer2.sOpis = "Средний";
            zak1.razmer2.iPrice = 1500;
            zak1.razmer3.sOpis = "Большой";
            zak1.razmer3.iPrice = 2000;
            // МЕНЮ Вкус
            zak1.vkus1.sOpis = "Клубничный";
            zak1.vkus1.iPrice = 140;
            zak1.vkus2.sOpis = "Ванильный";
            zak1.vkus2.iPrice = 200;
            zak1.vkus3.sOpis = "Малиновый";
            zak1.vkus3.iPrice = 125;
            // МЕНЮ Коржи
            zak1.colCorgey1.sOpis = "1";
            zak1.colCorgey1.iPrice = 200;
            zak1.colCorgey2.sOpis = "3";
            zak1.colCorgey2.iPrice = 500;
            zak1.colCorgey3.sOpis = "5";
            zak1.colCorgey3.iPrice = 500;



            // МЕНЮ Глазурь
            zak1.glazur1.sOpis = "Шоколадная";
            zak1.glazur1.iPrice = 150;
            zak1.glazur2.sOpis = "Ванильная";
            zak1.glazur2.iPrice = 160;
            zak1.glazur3.sOpis = "Сливочная";
            zak1.glazur3.iPrice = 160;
            // МЕНЮ Декор
            zak1.dekor1.sOpis = "Ягодный";
            zak1.dekor1.iPrice = 50;
            zak1.dekor2.sOpis = "Кремовый";
            zak1.dekor2.iPrice = 60;
            zak1.dekor3.sOpis = "Шоколад";
            zak1.dekor3.iPrice = 80;




        }
        public void Menu2(Zakaz zak1, int pos) // 2 меню
        {
                if (pos == 2)
                {
                    Console.Clear();
                    Console.WriteLine("  Выберите форму торта:");
                    Console.WriteLine("  ---------------------");
                    Console.WriteLine("  "+  zak1.forma1.sOpis+ "  " + zak1.forma1.iPrice+" " + "руб.");
                    Console.WriteLine("  "+  zak1.forma2.sOpis+ "  " + zak1.forma2.iPrice+" " + "руб.");
                    Console.WriteLine("  "+ zak1.forma3.sOpis+ "  " + zak1.forma3.iPrice+" " + "руб.");
                }
                else if (pos == 3)
                {
                    Console.Clear();
                    Console.WriteLine("  Выберите размер торта:");
                    Console.WriteLine("  ----------------------");
                    Console.WriteLine("  "+  zak1.razmer1.sOpis+ "  " + zak1.razmer1.iPrice+" " + "руб.");
                    Console.WriteLine("  "+  zak1.razmer2.sOpis+ "  " + zak1.razmer2.iPrice+" " + "руб.");
                    Console.WriteLine("  "+  zak1.razmer3.sOpis+ "  " + zak1.razmer3.iPrice+" " + "руб.");
                }
                else if (pos == 4)
                {
                    Console.Clear();
                    Console.WriteLine("  Выберите вкус торта:");
                    Console.WriteLine("  --------------------");
                    Console.WriteLine("  "+ zak1.vkus1.sOpis+ "  " + zak1.vkus1.iPrice+" " + "руб.");
                    Console.WriteLine("  "+ zak1.vkus2.sOpis+ "  " + zak1.vkus2.iPrice+" " + "руб.");
                    Console.WriteLine("  "+ zak1.vkus3.sOpis+ "  " + zak1.vkus3.iPrice+" " + "руб.");
                }
                else if (pos == 5)
                {
                    Console.Clear();
                    Console.WriteLine("  Выберите количество коржей:");
                    Console.WriteLine("  ---------------------------");
                    Console.WriteLine("  "+ zak1.colCorgey1.sOpis+ "  " + zak1.colCorgey1.iPrice+" " + "руб.");
                    Console.WriteLine("  "+ zak1.colCorgey2.sOpis+ "  " + zak1.colCorgey2.iPrice+" " + "руб.");
                    Console.WriteLine("  "+ zak1.colCorgey3.sOpis+ "  " + zak1.colCorgey3.iPrice+" " + "руб.");
            }
                else if (pos == 6)
                {
                    Console.Clear();
                    Console.WriteLine("  Выберите глазурь:");
                    Console.WriteLine("  -----------------");
                    Console.WriteLine("  "+ zak1.glazur1.sOpis+ "  " + zak1.glazur1.iPrice+" " + "руб.");
                    Console.WriteLine("  "+ zak1.glazur2.sOpis+ "  " + zak1.glazur2.iPrice+" " + "руб.");
                    Console.WriteLine("  " +zak1.glazur3.sOpis+ "  " + zak1.glazur3.iPrice+" " + "руб.");
            }
                else if (pos == 7)
                {
                    Console.Clear();
                    Console.WriteLine("  Выберите декор:");
                    Console.WriteLine("  ---------------");
                    Console.WriteLine("  "+ zak1.dekor1.sOpis+ "  " + zak1.dekor1.iPrice+" " + "руб.");
                    Console.WriteLine("  "+ zak1.dekor2.sOpis+ "  " + zak1.dekor2.iPrice+" " + "руб.");
                    Console.WriteLine("  "+ zak1.dekor3.sOpis+ "  " + zak1.dekor3.iPrice+" " + "руб.");
            }
        }

        public int Itog(int pos, int pos1,Zakaz zak1) // Возращаем цену
        {
           if (pos == 2 & pos1 == 2) { return zak1.forma1.iPrice; }
           if (pos == 2 & pos1 == 3) { return zak1.forma2.iPrice; }
           if (pos == 2 & pos1 == 4) { return zak1.forma3.iPrice; }
           if (pos == 3 & pos1 == 2) { return zak1.razmer1.iPrice; }
           if (pos == 3 & pos1 == 3) { return zak1.razmer2.iPrice; }
           if (pos == 3 & pos1 == 4) { return zak1.razmer3.iPrice; }
           if (pos == 4 & pos1 == 2) { return zak1.vkus1.iPrice; }
           if (pos == 4 & pos1 == 3) { return zak1.vkus2.iPrice; }
           if (pos == 4 & pos1 == 4) { return zak1.vkus3.iPrice; }
           if (pos == 5 & pos1 == 2) { return zak1.colCorgey1.iPrice; }
           if (pos == 5 & pos1 == 3) { return zak1.colCorgey2.iPrice; }
           if (pos == 5 & pos1 == 4) { return zak1.colCorgey3.iPrice; }
           if (pos == 6 & pos1 == 2) { return zak1.glazur1.iPrice; }
           if (pos == 6 & pos1 == 3) { return zak1.glazur2.iPrice; }
           if (pos == 6 & pos1 == 4) { return zak1.glazur3.iPrice; }
           if (pos == 7 & pos1 == 2) { return zak1.dekor1.iPrice; }
           if (pos == 7 & pos1 == 3) { return zak1.dekor2.iPrice; }
           if (pos == 7 & pos1 == 4) { return zak1.dekor3.iPrice; }

            else
            {
                return 0;
            }
        }

        public string ItogS(int pos, int pos1,Zakaz zak1) // Возращаем описание
        {
            if (pos == 2 & pos1 == 2) { return "Форма "+ zak1.forma1.sOpis + "  "; }
            if (pos == 2 & pos1 == 3) { return "Форма "+ zak1.forma2.sOpis + "  "; }
            if (pos == 2 & pos1 == 4) { return "Форма "+ zak1.forma3.sOpis + "  "; }
            if (pos == 3 & pos1 == 2) { return "Размер "+ zak1.razmer1.sOpis + "  "; }
            if (pos == 3 & pos1 == 3) { return "Размер "+ zak1.razmer2.sOpis + "  "; }
            if (pos == 3 & pos1 == 4) { return "Размер "+ zak1.razmer3.sOpis + "  "; }
            if (pos == 4 & pos1 == 2) { return "Вкус "+ zak1.vkus1.sOpis + "  "; }
            if (pos == 4 & pos1 == 3) { return "Вкус "+ zak1.vkus2.sOpis + "  "; }
            if (pos == 4 & pos1 == 4) { return "Вкус "+ zak1.vkus3.sOpis + "  "; }
            if (pos == 5 & pos1 == 2) { return "Количество коржей "+ zak1.colCorgey1.sOpis + "  "; }
            if (pos == 5 & pos1 == 3) { return "Количество коржей "+ zak1.colCorgey2.sOpis + "  "; }
            if (pos == 5 & pos1 == 4) { return "Количество коржей "+ zak1.colCorgey3.sOpis + "  "; }
            if (pos == 6 & pos1 == 2) { return "Глазурь "+ zak1.glazur1.sOpis + "  "; }
            if (pos == 6 & pos1 == 3) { return "Глазурь "+ zak1.glazur2.sOpis + "  "; }
            if (pos == 6 & pos1 == 4) { return "Глазурь "+ zak1.glazur3.sOpis + "  "; }
            if (pos == 7 & pos1 == 2) { return "Декор "+ zak1.dekor1.sOpis + "  "; }
            if (pos == 7 & pos1 == 3) { return "Декор "+ zak1.dekor2.sOpis + "  "; }
            if (pos == 7 & pos1 == 4) { return "Декор "+ zak1.dekor3.sOpis + "  "; }

            else
            {
                return "";
            }
        }
        public void Zapis(string cStr, int iprice) //запишем в файл
        {

            File.WriteAllText("D:\\Mytext.txt", "Заказ от " + DateTime.Now.ToShortDateString() + (char)13 + (char)10);
            File.AppendAllText("D:\\Mytext.txt", cStr + (char)13 + (char)10);
            File.AppendAllText("D:\\Mytext.txt", "Цена " + iprice + "рублей");
        }


    };
}
