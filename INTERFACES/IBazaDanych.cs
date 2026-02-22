using MenagerLekow.MVVM.MODEL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MenagerLekow.INTERFACES
{
    interface IBazaDanych
    {
        public void Create(); 
        public void Update();
        public void Delete();
        public void DeleteAll();
        public ObservableCollection<HarmonogramDTO> SelectAll(string name);
        public HarmonogramDTO Select();
        public Leki SelectLek(string name);
        public Leki SelectLekiAll();
        public Harmonogram SelectHarmonogram(string name);
        public Harmonogram SelectharmonogramALL();
    }
}
