using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1 {

    internal class Pokoj {
        private int nrPokoju;
        private double cenaZaDzien;

        public Pokoj(int nrPokoju, double cenaZaDzien) {
            this.nrPokoju = nrPokoju;
            this.cenaZaDzien = cenaZaDzien;
        }

        public int ReturnnrPokoju() {
            return nrPokoju;
        }

        public double ReturncenaZaDzien() {
            return cenaZaDzien;
        }

        public override string ToString() {
            return "Pokój nr: " + this.nrPokoju + ". Cena za dzień: " + this.cenaZaDzien;
        }
    }
}