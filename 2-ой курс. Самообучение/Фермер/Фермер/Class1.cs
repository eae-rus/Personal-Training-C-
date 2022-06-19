using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Фермер
{
    class Фермер
    {
        public short КоличесвоКоров;
        private const byte КормаНа1Корову = 30;

        public string ИтоговыйТекст()
        {
            return "Мне необхoдимо " + КоличесвоКоров * КормаНа1Корову + " мешков для " + КоличесвоКоров + " коров";
        }

    }
}
