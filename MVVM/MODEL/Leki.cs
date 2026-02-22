using System;
using System.Collections.Generic;
using System.Text;

namespace MenagerLekow.MVVM.MODEL
{
    class Leki
    {
        public int ID  { get; set; }
        public string nazwa { get; set; }
        public int ilosc { get; set; }
        public DateTime datazakupu { get; set; }
        public DateTime datawaznosci {  get; set; }

    }
}
