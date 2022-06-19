using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Карты_1
{
    enum Масти : byte
    {
        черва,
        бубна,
        креста,
        пика,
    }

    enum Значение_карт : byte
    {
        туз = 1,
        двойка = 2,
        тройка = 3,
        четвёрка = 4,
        пятёрка = 5,
        шестёрка = 6,
        семёрка = 7,
        восьмёрка = 8,
        девятка = 9,
        десятка = 10,
        валет = 11,
        дама = 12,
        король = 13,
    }

    class Карты
    {
        public Масти Масть { get; set; }
        public Значение_карт Значение_карты { get; set; }

        public Карты(Масти масть, Значение_карт значение_карты) 
        { 
            this.Масть = масть; this.Значение_карты = значение_карты; 
        }

        public string Имя
        {
            get { return  Значение_карты.ToString() + " " + Масть.ToString(); }
        }
    }
}
