using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cлоны
{
    class Слоны1
    {
        public string Имя;
        public byte Размер_Уха;

        public void Вывод_текста_о_ушах()
        {
            MessageBox.Show("Размер моего уха = " + Размер_Уха, " " + Имя + " говорит...");
        }
    }
}
