using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Вычмат_1;

namespace Vicmat_G
{
    public partial class Glav_Form : Form
    {
        public Glav_Form()
        {
            InitializeComponent();
        }

        private void Glav_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void INTEGRAL_Click(object sender, EventArgs e)
        {
            Vichmat.Forma_int INT = new Vichmat.Forma_int();
            INT.ShowDialog();

        }



        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TSMineINT_Click(object sender, EventArgs e)
        {
            Vichmat.Forma_int INT = new Vichmat.Forma_int();
            INT.ShowDialog();
        }

        private void TSMineUrav_Click(object sender, EventArgs e)
        {
            Vichmat_Prokt.Urav Uravnen = new Vichmat_Prokt.Urav(this);
            Uravnen.ShowDialog();
        }

        private void SLU_TSM_Click(object sender, EventArgs e)
        {
            Вычмат_1.Form_CLU SLU = new Вычмат_1.Form_CLU();
            SLU.ShowDialog();
        }

        private void CHY_F_Click(object sender, EventArgs e)
        {
            Вычмат_1.nelen_sist SHU = new nelen_sist();
            SHU.ShowDialog();
        }

        private void ODU_TSMenu_Click(object sender, EventArgs e)
        {
            Вычмат_1.ODU odu = new ODU();
            odu.ShowDialog();
        }
    }
}
