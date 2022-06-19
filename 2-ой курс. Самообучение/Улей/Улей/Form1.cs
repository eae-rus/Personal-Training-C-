using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Улей
{
    public partial class Улей : Form
    {
        Матка матка;
        public Улей()
        {
            InitializeComponent();
            матка = new Матка();
            матка.Создать_пчёл((uint)Количество_пчёл_в_улье.Value);
            Отчёт_о_свободных.Text = матка.обновление_формы_свободные();
            Отчёт_о_работающих.Text = матка.обновление_формы_занятые();
            Мёд_Расход.Text = матка.обновление_формы_Учёт_мёда();
        }

        private void Количество_пчёл_в_улье_ValueChanged(object sender, EventArgs e)
        {
            матка.Создать_пчёл((uint)Количество_пчёл_в_улье.Value);
            Отчёт_о_свободных.Text = матка.обновление_формы_свободные();
            Отчёт_о_работающих.Text = матка.обновление_формы_занятые();
            Мёд_Расход.Text = матка.обновление_формы_Учёт_мёда();
        }

        private void Отчёт_о_свободных_TextChanged(object sender, EventArgs e)
        {

        }

        private void Отчёт_о_работающих_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Распрелделить_пчёл_Click(object sender, EventArgs e)
        {
            матка.Выдача_работы(Варианты_работы.Text, (byte)Кол_Смен.Value, (uint)Кол_пчёл_на_работу.Value);
            Отчёт_о_свободных.Text = матка.обновление_формы_свободные();
            Отчёт_о_работающих.Text = матка.обновление_формы_занятые();
            Мёд_Расход.Text =  матка.обновление_формы_Учёт_мёда();
        }

        private void Смена_прошла_Click(object sender, EventArgs e)
        {
            матка.Прокрутка_смены();
            Отчёт_о_свободных.Text = матка.обновление_формы_свободные();
            Отчёт_о_работающих.Text = матка.обновление_формы_занятые();
            Мёд_Расход.Text = матка.обновление_формы_Учёт_мёда();
        }

        private void Мёд_Расход_TextChanged(object sender, EventArgs e)
        {

        }

        private void Отмена_пчёл_работа_Click(object sender, EventArgs e)
        {
            матка.Вернуть_работу(Варианты_работы.Text, (uint)Кол_пчёл_на_работу.Value);
            Отчёт_о_свободных.Text = матка.обновление_формы_свободные();
            Отчёт_о_работающих.Text = матка.обновление_формы_занятые();
            Мёд_Расход.Text = матка.обновление_формы_Учёт_мёда();
        }
    }
}
