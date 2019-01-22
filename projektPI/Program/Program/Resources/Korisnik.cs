namespace Program
{
   
        public class Korisnik
        {
            private long jmbag;
            private string adresa;
            private string email;
            private string lozinka;
            private int kontaktBroj;

            public Korisnik()
            {
            }

            public long Jmbag
            {
                get
                {
                    return jmbag;
                }

                set
                {
                    jmbag = value;
                }
            }

           

            public int KontaktBroj
            {
                get
                {
                    return kontaktBroj;
                }

                set
                {
                    kontaktBroj = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }
            }

            public string Lozinka
            {
                get
                {
                    return lozinka;
                }

                set
                {
                    lozinka = value;
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
        }
    }

