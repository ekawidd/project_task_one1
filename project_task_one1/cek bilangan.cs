using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_task_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private cekBil cek= new cekBil ();
        private void proses_Click(object sender, EventArgs e)
        {
            int angka;
            angka=Convert.ToInt16(input.Text );
            texthasil.Text = cek.bilangan(angka).ToString();
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}