using MenagerLekow.Db;
using MenagerLekow.INTERFACES;
using MenagerLekow.MVVM.MODEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenagerLekow.MVVM.VIEWMODEL
{
    public class DodajElementViewModel
    {
        //dodana instancja bazy danych

        IBazaDanych idb;
        public async void DodajElement(IBazaDanych idb)
        {
            this.idb= idb;
        }
        public void DodajNowyElement(Leki LEK)
        {
            idb.CreateLeki(LEK);
        }
    }
 
}
