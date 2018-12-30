using System;
using Mono.Data.Sqlite;

namespace Program
{
    public static class BP
    {
        private static string connectionString = "URI=file:Baza.db";

        internal static SqliteConnection konekcija = new SqliteConnection(connectionString);

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
