using System;
using System.Collections.Generic;
using System.Text;

namespace MenagerLekow.MVVM.MODEL
{
    class Harmonogram
    {
        public int ID { get; set; }
        public int IDLEKI { get; set; }
        public string Nazwa { get; set; }
        public int IloscNaDzien {  get; set; }
        public DateTime KiedyPrzyjac {  get; set; }
    }
}
