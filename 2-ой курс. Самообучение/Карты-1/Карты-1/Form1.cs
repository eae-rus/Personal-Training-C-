using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Карты_1
{
    public partial class Рандом_карт : Form
    {
        Random random;
        public Рандом_карт()
        {
            InitializeComponent();
        }

        private void Случайная_карта_Click(object sender, EventArgs e)
        {
            random = new Random();
            Карты карты = new Карты( (Масти)random.Next(4),(Значение_карт)random.Next(1,14));
            MessageBox.Show(карты.Имя);

        }
    }
}
