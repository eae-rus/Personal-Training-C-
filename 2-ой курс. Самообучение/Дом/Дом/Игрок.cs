using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Дом
{
    class Игрок : Общий
    {
        public string спрятался = "Гостиная";
        public string название = "под диваном";


        public void спрятаться()
        {
            Random random = new Random();
            Интерфейс_дома место = new Гостиная();
            byte x = 0;
            byte z = 0;
            while (x != 100)
            {
                Перечень_соседних_помещений = место.переписать_соседние_помещения();

                z = (byte)Перечень_соседних_помещений.Length;
                место = Перечень_соседних_помещений[(byte)random.Next(z)];
                x = (byte)random.Next(200);
            }

            спрятался = место.выдать_строку_имя();
            прятки прятаться_тут = место as прятки;
            z = (byte)(random.Next(прятаться_тут.выдать_количество_строк()));
            название = прятаться_тут.выдать_одну_строку_п(z);
            if ((спрятался == "") || (название == ""))
            {
                спрятаться();
            }
        }
    }
}
