using MenagerLekow.Db;
using MenagerLekow.INTERFACES;
using MenagerLekow.MVVM.MODEL;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenagerLekow.MVVM.VIEWMODEL
{
    [AddINotifyPropertyChangedInterface]

    [QueryProperty(nameof(LEK), "LEK")]
    public class DodajElementViewModel

    {
        private Leki leki;
        public Leki LEK { get => leki; set => leki = value; }
        //dodana instancja bazy danych

       private readonly IBazaDanych idb;
        public DodajElementViewModel(IBazaDanych idb)
        {
            this.idb = idb;

        }
      
        public void DodajNowyElement(Leki LEK)
        {
            
                idb.CreateLeki(LEK);


        }
     
    }
 
}
