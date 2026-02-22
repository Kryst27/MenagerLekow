using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenagerLekow.MVVM.MODEL
{
    public class Leki
    {
        [AutoIncrement]
        public int ID  { get; set; }
        public string nazwa { get; set; }
        public int ilosc { get; set; }
        public DateTime datazakupu { get; set; }
        public DateTime datawaznosci {  get; set; }

    }
}
