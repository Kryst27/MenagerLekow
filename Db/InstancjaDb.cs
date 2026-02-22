using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenagerLekow.Db
{
     public class InstancjaDb
    {
        private const string Baza = "bazalekow.db3";
        public const SQLiteOpenFlags flagi = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;
        public static string sciezka {  get { return Path.Combine(FileSystem.AppDataDirectory, Baza); } }
    }
}
