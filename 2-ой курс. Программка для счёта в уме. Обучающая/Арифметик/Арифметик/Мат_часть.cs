using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Арифметик
{
    class Мат_часть
    {
        private byte cложность;
        private ulong первое_число;
        private ulong второе_число;
        private byte знак;
        private ulong ответ;

        private void выдать_знак()
        {
            Random random = new Random();
            знак = (byte)(1 + random.Next(5)); //цифра под скобками равна количеству арифметических выражений
        }
        private void генератор_сложение()
        {
            Random random = new Random();
            sbyte Сложность = (sbyte)cложность;
           
            ulong x = (byte)random.Next(2);
            ulong y = (byte)random.Next(2);
            while ((Сложность + 1)> 0)
            { 
                if (Сложность % 5 == 0)
                { x *= 10; y *= 10; }
                x += (byte)random.Next(3);
                y += (byte)random.Next(3);
                Сложность -= 1;
            }
            первое_число = x;
            второе_число = y;
            ответ = x+y;
        }
        private void генератор_вычитание()
        {
            генератор_сложение();
            ответ += первое_число;
            первое_число = ответ - первое_число;
            ответ = ответ - первое_число;

        }
        private void генератор_умножение()
        {
            Random random = new Random();
            byte Сложность = cложность;
            ulong предел = 1;
            while (Сложность >4)
            {
                предел *= 10;
                Сложность = (byte)(Сложность - 5);
            }

            if ((cложность % 5) == 0)
            { предел *= 10; }
            else
            { предел = предел * 10 + (предел * 2 * (ulong)(cложность % 5)); }

            предел = (ulong)Math.Sqrt(предел);
            ushort x = (ushort)random.Next(cложность,(ushort)предел);
            ushort y = (ushort)random.Next(cложность, (ushort)предел);
            первое_число = x;
            второе_число = y;
            ответ = (ulong)(x * y);
        }
        private void генератор_деление()
        {
            bool проверка = true;
            while (проверка)
            {
                генератор_умножение();
                ответ += первое_число;
                первое_число = ответ - первое_число;
                ответ = ответ - первое_число;
                if (второе_число == 0)
                {
                    проверка = true;
                }
                else
                {
                    проверка = false;
                }
            }
        }
        private void генератор_извлечение_корня()
        {
            Random random = new Random();
            byte Сложность = cложность;
            ulong предел = 1;
            while (Сложность > 4)
            {
                предел *= 10;
                Сложность = (byte)(Сложность - 5);
            }

            if ((cложность % 5) == 0)
            { предел *= 10; }
            else
            { предел = предел * 10 + (предел * 2 * (ulong)(cложность % 5)); }
            предел *= 5;

            предел = (ulong)Math.Sqrt(предел);
            ushort x = (ushort)random.Next(cложность, (ushort)предел);
            первое_число = (ulong)(x * x);
            ответ = x;
        }

        public string Выдать_Строку(byte Сложность_вход)
        {
            cложность = Сложность_вход;
            string строка = "";
            выдать_знак();
            switch (знак)
            {
            
                case 1:
                    {
                        генератор_сложение();
                        строка = первое_число + "\r\n" + "+\r\n" + второе_число + "\r\n=";
                        break;
                    }
                case 2:
                    {
                        генератор_вычитание();
                        строка = первое_число + "\r\n" + "-\r\n" + второе_число + "\r\n=";
                        break;
                    }
                case 3:
                    {
                        генератор_умножение();
                        строка = первое_число + "\r\n" + "*\r\n" + второе_число + "\r\n=";
                        break;
                    }
                case 4:
                    {
                        генератор_деление();
                        строка = первое_число + "\r\n" + "/\r\n" + второе_число + "\r\n=";
                        break;
                    }
                case 5:
                    {
                        генератор_извлечение_корня();
                        строка = "Квадратный корень из числа\r\n" + первое_число + "\r\n=";
                        break;
                    }
                default:
                    {
                        строка = "";
                        break;
                    }
            }
            return строка; 
        }

        public bool Ответ(string Ответ_вход)
        {
            string Ответ = "" + ответ;
            if (Ответ == Ответ_вход)
            { return true; }
            else
            { return false; }
        }
    }
}
