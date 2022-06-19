using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Интерфейсы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Высокий_парень высокий_парень = new Высокий_парень() { Имя = "Алексей", Рост = 164 }; 
            высокий_парень.Рассказать_о_себе();
        }
    }
}
