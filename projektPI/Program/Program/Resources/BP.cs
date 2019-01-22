using System;
using System.Data.SQLite;

namespace Program
{
    public static class BP
    {
        private static string connectionString = "Data Source = D:\\projekt_menzaTOGO\\Program\\mybaza.db";

        internal static SQLiteConnection konekcija = new SQLiteConnection (connectionString);

        public static void otvoriKonekciju()
        {
            konekcija.Open();
        }

        public static void zatvoriKonekciju()
        {
            konekcija.Close();
        }
    }
}
