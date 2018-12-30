namespace Program
{
    public class Narudzba
    {
        private long id;
        private string opis;
        private double iznos;
        private string status;
        private long jmbag_k;

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

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
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


       
    }
}
