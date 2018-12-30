using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Program
{
    public static class BPkorisnik
    {
        public static void Spremi(Korisnik k)
        {
            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = String.Format(@"Insert into korisnik (jmbag, email, lozinka, adresa, kontaktbroj) Values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                              k.Jmbag, k.Email, k.Lozinka, k.Adresa, k.KontaktBroj, 0);

            command.ExecuteNonQuery();

            command.Dispose();

            BP.zatvoriKonekciju();
        }

        public static List<Korisnik> DohvatiSve()
        {
            List<Korisnik> listaKorisnika = new List<Korisnik>();

            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = "Select * from korisnik";

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Korisnik k = new Korisnik();

                //k.Jmbag = (int)(Int64)reader["jmbag"];
                k.Jmbag = Convert.ToInt32(reader["jmbag"]);
                k.KontaktBroj = Convert.ToInt32(reader["kontaktbroj"]);
                k.Adresa = (string)reader["adresa"];
                k.Email = (string)reader["email"];
                k.Lozinka = (string)reader["lozinka"];

                listaKorisnika.Add(k);
            }

            reader.Dispose();
            command.Dispose();

            BP.zatvoriKonekciju();

            return listaKorisnika;
        }
    }
}
