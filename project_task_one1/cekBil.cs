using System;
using System.Collections.Generic;
using System.Text;

namespace project_task_one
{
    class cekBil
    {
        public string bilangan(int angka)
        {
            string hasil;
            if (angka % 2 == 0)
            { hasil = "bilangan ini adalah bilangan GENAP"; }
            else 
            { hasil = "bilangan ini adalah bilangan GANJIL"; }
            return hasil;
        }
    }
}
