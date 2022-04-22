namespace WpfApplication1 {
    public class Transakce {
        private string datum;
        private string druh;
        private string ucet;
        private string cena;
        private string kategorie;
        private string osoba;

        public Transakce() {
        }

        public Transakce(string datum, string druh, string ucet, string cena, string kategorie, string osoba) {
            this.datum = datum;
            this.druh = druh;
            this.ucet = ucet;
            this.cena = cena;
            this.kategorie = kategorie;
            this.osoba = osoba;
        }

        public string Datum {
            get => datum;
            set => datum = value;
        }

        public string Druh {
            get => druh;
            set => druh = value;
        }

        public string Ucet {
            get => ucet;
            set => ucet = value;
        }

        public string Cena {
            get => cena;
            set => cena = value;
        }

        public string Kategorie {
            get => kategorie;
            set => kategorie = value;
        }

        public string Osoba {
            get => osoba;
            set => osoba = value;
        }
    }
}