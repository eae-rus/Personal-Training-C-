using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Интерфейсы
{
    class Высокий_парень : Пробный_интрерфейс
    {
        public string Имя;
        public byte Рост;
        public void Рассказать_о_себе()
        {
            MessageBox.Show("Меня зовут " + Имя + ", мой рост = " + Рост + "см");
           
        }
        public string Считывающий { get { return ";;;"; } }

        public void honk()
        {
            MessageBox.Show("биби");
        }

    }
}
