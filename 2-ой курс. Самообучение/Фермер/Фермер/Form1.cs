using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Фермер
{
    public partial class Form1 : Form
    {
        Фермер фермер;
        public Form1()
        {
            фермер = new Фермер { КоличесвоКоров = 5 };
            InitializeComponent();

        }

        private void Посчитать_Click(object sender, EventArgs e)
        {
            фермер.КоличесвоКоров =  (short)КолКоров.Value;
            ИтогТекст.Text = фермер.ИтоговыйТекст();
            
        }
    }
}
