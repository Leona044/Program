namespace Program
{
    public class Narudzba
    {
        private long id;
        private int kolicina;
        private double iznos;
        private string status;
        private long jmbag_k;
        private string menu;
        private string sadrzaj;
        private string adresa;
        private string broj_mobitela;
        private string nacin_placanja;

        public Narudzba()
        {
            status = "zaprimljeno";
            iznos = 0;
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
            }
        }

        public double Iznos
        {
            get
            {
                return iznos;
            }

            set
            {
                iznos = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public long Jmbag_k
        {
            get
            {
                return jmbag_k;
            }

            set
            {
                jmbag_k = value;
            }
        }

        public string Menu
        {
            get
            {
                return menu;
            }
            set
            {
                menu = value;
            }
        }

        public string Sadrzaj
        {
            get
            {
                return sadrzaj;
            }
            set
            {
                sadrzaj = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                adresa = value;
            }
        }

        public string Broj_mobitela
        {
            get
            {
                return broj_mobitela;
            }
            set
            {
                broj_mobitela = value;
            }
        }

        public string Nacin_placanja
        {
            get
            {
                return nacin_placanja;
            }
            set
            {
                nacin_placanja = value;
            }
        }




    }
}
