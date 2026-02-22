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

        public void CreateHarmonogram(Harmonogram harm)
        {
            throw new NotImplementedException();
        }

        public void CreateLeki(Leki lek)
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

        public Harmonogram SelectHarmonogram(string name)
        {
            throw new NotImplementedException();
        }

        public Harmonogram SelectharmonogramALL()
        {
            throw new NotImplementedException();
        }

        public Leki SelectLek(string name)
        {
            throw new NotImplementedException();
        }

        public Leki SelectLekiAll()
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
    }
}
