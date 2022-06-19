using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Помощь_парням
{
    class Guy
    {
        public string name;
        public int cash;

        public int givecash(int amount)
        {
            if (amount <= cash & amount > 0)
            {
                cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("У меня не хватает денег" + amount, name + "говорит...");
                return 0;
            }
        }

        public int receivecash(int amount)
        {
            if (amount > 0)
            {
                cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " Мне не нужно", name + "Говорит...");
                return 0;
            }
        }
    }
}
