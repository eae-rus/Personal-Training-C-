using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Дом
{
    class Гостиная : Общий, Интерфейс_дома, Интерфейс_дверь_на_улицу, прятки
    {
        private string имя = "Гостиная" ;
        private string описание = "Обширная гостиная с красивой люстрой, большим диваном и замечательным теливизором";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[3];
            Перечень_соседних_помещений[0] = new Лужайка();
            Перечень_соседних_помещений[1] = new Столовая();
            Перечень_соседних_помещений[2] = new Лестница();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true;}
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }



        private string описание_двери = "Большая дубовая дверь, ведущая на лужайку";
        private bool в_доме_ли_помещение = true;
        public string выдать_описание_двери()
        { return описание_двери; }
        public bool выдать_домели_помещение()
        { return в_доме_ли_помещение; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        {
            ссылка_на_соседнее_помещение = new Лужайка();
            return ссылка_на_соседнее_помещение;
        }

        //прятки
        private string[] укромные_места = new string[2];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "под диваном";
            укромные_места[1] = "за шторой";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }



    }

    class Лужайка : Общий, Интерфейс_дома, Интерфейс_дверь_на_улицу, прятки
    {
        private string имя = "Лужайка";
        private string описание = "Красивая лужайка с ухоженым газоном";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[2];
            Перечень_соседних_помещений[0] = new Сад();
            Перечень_соседних_помещений[1] = new Гостиная();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public bool проверка_имени(string В_имя, byte цифра,Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }


        private string описание_двери = "Большая дубовая дверь, ведущая в гостиную";
        private bool в_доме_ли_помещение = false;
        public string выдать_описание_двери()
        { return описание_двери; }
        public bool выдать_домели_помещение()
        { return в_доме_ли_помещение; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        { 
            ссылка_на_соседнее_помещение = new Гостиная();
            return ссылка_на_соседнее_помещение;
        }
        //прятки
        private string[] укромные_места = new string[1];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "за дверью";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }

    class Сад : Общий, Интерфейс_дома, прятки
    {
        private string имя = "Сад";
        private string описание = "Прелестный сад с большими многолетними яблонями и другими деревьями";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[2];
            Перечень_соседних_помещений[0] = new Задний_двор();
            Перечень_соседних_помещений[1] = new Лужайка();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        { 
            ссылка_на_соседнее_помещение = null;
            return ссылка_на_соседнее_помещение;
        }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }
        //прятки
        private string[] укромные_места = new string[2];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "за деревом";
            укромные_места[1] = "за дверью скамейкой";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }

    class Задний_двор : Общий, Интерфейс_дома, Интерфейс_дверь_на_улицу, прятки
    {
        private string имя = "Задний двор";
        private string описание = "Задний двор ничем не примечателен";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[2];
            Перечень_соседних_помещений[0] = new Кухня();
            Перечень_соседних_помещений[1] = new Сад();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }
        


        private string описание_двери = "Лёгенькая дверь";
        private bool в_доме_ли_помещение = false;
        public string выдать_описание_двери()
        { return описание_двери; }
        public bool выдать_домели_помещение()
        { return в_доме_ли_помещение; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        { 
            ссылка_на_соседнее_помещение = new Кухня();
            return ссылка_на_соседнее_помещение;
        }
        //прятки
        private string[] укромные_места = new string[1];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "в гараже";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }

    class Кухня : Общий, Интерфейс_дома, Интерфейс_дверь_на_улицу, прятки
    {
        private string имя = "Кухня";
        private string описание = "Просторная кухня с современным оборудованиие";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[2];
            Перечень_соседних_помещений[0] = new Столовая();
            Перечень_соседних_помещений[1] = new Задний_двор();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }


        private string описание_двери= "Лёгенькая дверь";
        private bool в_доме_ли_помещение = true;
        public string выдать_описание_двери()
        { return описание_двери; }
        public bool выдать_домели_помещение()
        { return в_доме_ли_помещение; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        {
            ссылка_на_соседнее_помещение = new Задний_двор();
            return ссылка_на_соседнее_помещение;
        }
        //прятки
        private string[] укромные_места = new string[2];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "под столом";
            укромные_места[1] = "за холодильником";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }

    class Столовая : Общий, Интерфейс_дома, прятки
    {
        private string имя = "Столовая";
        private string описание = "Столовая где можно вкусно поесть";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[2];
            Перечень_соседних_помещений[0] = new Гостиная();
            Перечень_соседних_помещений[1] = new Кухня();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        {
            ссылка_на_соседнее_помещение = null;
            return ссылка_на_соседнее_помещение;
        }
        public bool проверка_имени(string В_имя, byte цифра,Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }
        //прятки
        private string[] укромные_места = new string[2];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "под столом";
            укромные_места[1] = "за шторой";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }

    class Лестница : Общий, Интерфейс_дома, прятки
    {
        private string имя = "Лестница";
        private string описание = "Лестница, по которой можно подняться на второй этаж";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[2];
            Перечень_соседних_помещений[0] = new Гостиная();
            Перечень_соседних_помещений[1] = new Коридор();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        {
            ссылка_на_соседнее_помещение = null;
            return ссылка_на_соседнее_помещение;
        }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }
        //прятки
        private string[] укромные_места = new string[1];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "под лестницей";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }

    class Коридор : Общий, Интерфейс_дома, прятки
    {
        private string имя = "Коридор";
        private string описание = "Это коридор на втором этаже";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[4];
            Перечень_соседних_помещений[0] = new Лестница();
            Перечень_соседних_помещений[1] = new Комната();
            Перечень_соседних_помещений[2] = new Зал();
            Перечень_соседних_помещений[3] = new Ванна();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        {
            ссылка_на_соседнее_помещение = null;
            return ссылка_на_соседнее_помещение;
        }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }
        //прятки
        private string[] укромные_места = null;

        public byte выдать_количество_строк()
        {
            return 0;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return ""; }
    }

    class Комната : Общий, Интерфейс_дома, прятки
    {
        private string имя = "Комната";
        private string описание = "Это комната, в которой спят хозяева";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[1];
            Перечень_соседних_помещений[0] = new Коридор();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        {
            ссылка_на_соседнее_помещение = null;
            return ссылка_на_соседнее_помещение;
        }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }
        //прятки
        private string[] укромные_места = new string[3];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "под кроватью";
            укромные_места[1] = "за шторой";
            укромные_места[2] = "в шкафу";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }

    class Зал : Общий, Интерфейс_дома, прятки
    {
        private string имя = "Зал";
        private string описание = "Зал с большим теливизором и роскошным диваном";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[1];
            Перечень_соседних_помещений[0] = new Коридор();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        {
            ссылка_на_соседнее_помещение = null;
            return ссылка_на_соседнее_помещение;
        }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }
        //прятки
        private string[] укромные_места = new string[3];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "за диваном";
            укромные_места[1] = "за шторой";
            укромные_места[2] = "за телевизором";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }

    class Ванна : Общий, Интерфейс_дома, прятки
    {
        private string имя = "Ванна";
        private string описание = "В ванне есть туалет и ванна с душем, так же имеется большое зеркало";
        public Интерфейс_дома[] переписать_соседние_помещения()
        {
            Перечень_соседних_помещений = new Интерфейс_дома[1];
            Перечень_соседних_помещений[0] = new Коридор();
            return Перечень_соседних_помещений;
        }
        public string выдать_строку_описание()
        { return имя + "\r\n" + описание; }
        public Интерфейс_дома соседнее_помещение_дверь_на_улицу()
        {
            ссылка_на_соседнее_помещение = null;
            return ссылка_на_соседнее_помещение;
        }
        public bool проверка_имени(string В_имя, byte цифра, Интерфейс_дома[] ссылка)
        {
            Перечень_соседних_помещений = ссылка;
            if (В_имя == Перечень_соседних_помещений[цифра].выдать_строку_имя())
            { return true; }
            else
            { return false; }
        }
        public string выдать_строку_имя()
        {
            return имя;
        }
        //прятки
        private string[] укромные_места = new string[1];

        public byte выдать_количество_строк()
        {
            укромные_места[0] = "за дверью";
            return (byte)укромные_места.Length;
        }

        public string выдать_одну_строку_п(byte цифра)
        { return укромные_места[цифра]; }
    }
}
