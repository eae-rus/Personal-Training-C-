using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cлоны
{

    public partial class Form1 : Form
    {
        Слоны1 Линда1;
        Слоны1 Лойд1;

        public Form1()
        {
            InitializeComponent();
            Линда1 = new Слоны1() { Имя = "Линда", Размер_Уха = 33 };
            Лойд1 = new Слоны1() { Имя = "Лойд", Размер_Уха = 40 };
            Линда.Text = "Линда";
            Лойд.Text = "Лойд";

        }

        private void Линда_Click(object sender, EventArgs e)
        {
            Линда1.Вывод_текста_о_ушах();
        }

        private void Лойд_Click(object sender, EventArgs e)
        {
            Лойд1.Вывод_текста_о_ушах();
        }

        private void Смена_Click(object sender, EventArgs e)
        {
            Слоны1 Смена1;

            Смена1 = Линда1;
            Линда1 = Лойд1;
            Лойд1 = Смена1;
            if ("Лойд" == Линда1.Имя)
            {
                Линда.Text = "Лойд";
                Лойд.Text = "Линда";
            }
            else 
            {
                Линда.Text = "Линда";
                Лойд.Text = "Лойд";
            }
        }
    }
}
