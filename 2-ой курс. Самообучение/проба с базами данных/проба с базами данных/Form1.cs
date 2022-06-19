using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void карточкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.карточкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Карточка". При необходимости она может быть перемещена или удалена.
            this.карточкаTableAdapter.Fill(this.database1DataSet1.Карточка);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
