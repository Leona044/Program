using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Program
{
    public static class BPnarudzba
    {
        public static void Spremi(Narudzba n)
        {
            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = String.Format("Insert into Narudzba (menu, sadrzaj, iznos, status, id_k, kolicina, adresa, broj_mobitela, nacin_placanja) Values ('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}')",
                                                n.Menu, n.Sadrzaj, n.Iznos, n.Status, n.Jmbag_k, n.Kolicina, n.Adresa, n.Broj_mobitela, n.Nacin_placanja);

            command.ExecuteNonQuery();

            command.Dispose();

            BP.zatvoriKonekciju();
        }
        
        public static void Uredi(long id, string status)
        {
            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = String.Format(@"Update narudzba set status = '{0}' where id = '{1}'", status, id);

            command.ExecuteNonQuery();

            command.Dispose();

            BP.zatvoriKonekciju();
        }
     
        public static List<Narudzba> DohvatiSve()
        {
            List<Narudzba> lista = new List<Narudzba>();

            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = String.Format("Select * from narudzba");

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Narudzba n = new Narudzba();

                n.Jmbag_k = Convert.ToInt32(reader["id_k"]);
                n.Id = Convert.ToInt32(reader["id_n"]);
                n.Iznos = Convert.ToDouble(reader["iznos"]);
                n.Status = (string)reader["status"];
                n.Kolicina = Convert.ToInt32(reader["kolicina"]);
                n.Menu = (string)reader["menu"];
                n.Sadrzaj = (string)reader["sadrzaj"];
                n.Adresa = (string)reader["adresa"];
                n.Broj_mobitela = (string)reader["broj_mobitela"];
                n.Nacin_placanja = (string)reader["nacin placanja"];

                lista.Add(n);
            }

            reader.Dispose();
            command.Dispose();

            BP.zatvoriKonekciju();

            return lista;
        }

        public static int DohvatiBroj()
        {
            int broj = 0;
            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = String.Format("Select * from narudzba");

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                broj++;
            }

            reader.Dispose();
            command.Dispose();

            BP.zatvoriKonekciju();

            return broj;
        }

        public static List<Narudzba> Dohvati(string status)
        {
            List<Narudzba> lista = new List<Narudzba>();

            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = String.Format("Select * from narudzba where status = '{0}'", status);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Narudzba n = new Narudzba();

                n.Jmbag_k = Convert.ToInt32(reader["id_k"]);
                n.Id = Convert.ToInt32(reader["id_n"]);
                n.Iznos = Convert.ToDouble(reader["iznos"]);
                n.Status = (string)reader["status"];
                n.Kolicina = Convert.ToInt32(reader["kolicina"]);
                n.Menu = (string)reader["menu"];
                n.Sadrzaj = (string)reader["sadrzaj"];
                n.Adresa = (string)reader["adresa"];
                n.Broj_mobitela = (string)reader["broj_mobitela"];
                n.Nacin_placanja = (string)reader["nacin placanja"];


                lista.Add(n);
            }

            reader.Dispose();
            command.Dispose();

            BP.zatvoriKonekciju();

            return lista;
        }

        public static void Izbrisi(long id)
        {
            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = String.Format(@"Delete from narudzba where id = '{0}'", id);

            command.ExecuteNonQuery();

            command.Dispose();

            BP.zatvoriKonekciju();
        }
    }
}
