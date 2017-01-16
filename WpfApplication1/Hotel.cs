using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1 {

    internal class Hotel : IHotel, IData {
        private SortedDictionary<Pokoj, Gosc> rezerwacje = new SortedDictionary<Pokoj, Gosc>();
        private double zysk = 80;
        private DateTime data;

        public void DodajRezerwacje(string imie, string nazwisko, int nrPokoju, double cenaZaDzien) {
            rezerwacje.Add(new Pokoj(nrPokoju, cenaZaDzien), new Gosc(imie, nazwisko));
        }

        public void OdwołajRezerwacje() {
            rezerwacje.Clear();
        }

        public void UstawDate(DateTime Time) {
            data = Time;
        }

        public bool SprawdzDate() {
            if (data > DateTime.Now) return true;
            else return false;
        }

        public override string ToString() {
            string info = "Rezerwacje: ";
            return info;
        }
    }
}