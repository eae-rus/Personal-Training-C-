using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Помощь_парням
{
    public partial class Form1 : Form
    {

        Guy joe;
        Guy bob;
        int bank = 100;


        public void UpdateForm()
        {
            joescashlabel.Text = joe.name + " имеет $" + joe.cash;
            bobscashlabel.Text = bob.name + " имеет $" + bob.cash;
            bankcashlabel.Text = "В банке сейчас $" + bank;
        }

        public Form1()
        {
            InitializeComponent();
            joe = new Guy()
            {
                name = "Joy",
                cash = 50
            };


            bob = new Guy()
            {
                name = "Bob",
                cash = -100
            };

            joescashlabel.Text = "Joy имеет $50";
            bobscashlabel.Text = "Bob имеет $-100";
            bankcashlabel.Text = "В банке сейчас $100";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.receivecash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("В банке нет денег");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.givecash(5);
            UpdateForm();
        }

        private void joegivestobob_Click(object sender, EventArgs e)
        {
            joe.cash -= 10;
            bob.cash += 10;
            UpdateForm();
        }

        private void bobgivetojoe_Click(object sender, EventArgs e)
        {
            bob.cash -= 5;
            joe.cash += 5;
            UpdateForm();
        }
    }
}
