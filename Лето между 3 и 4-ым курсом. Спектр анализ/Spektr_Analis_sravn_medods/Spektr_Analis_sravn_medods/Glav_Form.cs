using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spektr_Analis_sravn_medods
{
    public partial class Glav_Form : Form
    {
        public Glav_Form()
        {
            InitializeComponent();

        }

        private void MadeSignal_TSM_Click(object sender, EventArgs e)
        {
            MadeSignal madesignal = new MadeSignal();                                   //создание переменной "форма"
            madesignal.Show();                                                          //показать форму
            madesignal.WindowState = System.Windows.Forms.FormWindowState.Maximized;    //задать ей максимальный размер
        }

        private void WorkSignal_TSM_Click(object sender, EventArgs e)
        {
            WorkSignal worksignal = new WorkSignal();                                   //создание переменной "форма"
            worksignal.Show();                                                          //показать форму
            worksignal.WindowState = System.Windows.Forms.FormWindowState.Maximized;    //задать ей максимальный размер
        }
    }
}
