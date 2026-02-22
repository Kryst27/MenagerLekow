using MenagerLekow.INTERFACES;
using MenagerLekow.MVVM.MODEL;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MenagerLekow.Db
{
    public class BazaDanych : IBazaDanych
    {
        SQLiteConnection polaczenie;
        public BazaDanych()
        {
            polaczenie = new SQLiteConnection(InstancjaDb.sciezka, InstancjaDb.flagi);
            polaczenie.CreateTable<Harmonogram>();
            polaczenie.CreateTable<Leki>();
            polaczenie.CreateTable<HarmonogramDTO>();
            polaczenie.Execute("PRAGMA page_size = 16384;");
            polaczenie.Execute("VACUUM");
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        HarmonogramDTO IBazaDanych.Select()
        {
            throw new NotImplementedException();
        }

        ObservableCollection<HarmonogramDTO> IBazaDanych.SelectAll(string name)
        {
            throw new NotImplementedException();
        }

        Harmonogram IBazaDanych.SelectHarmonogram(string name)
        {
            throw new NotImplementedException();
        }

        Harmonogram IBazaDanych.SelectharmonogramALL()
        {
            throw new NotImplementedException();
        }

        Leki IBazaDanych.SelectLek(string name)
        {
            throw new NotImplementedException();
        }

        Leki IBazaDanych.SelectLekiAll()
        {
            throw new NotImplementedException();
        }
    }
}
