﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1 {

    internal interface IHotel {

        void DodajRezerwacje(string imie, string nazwisko, int nr, double cena);

        void OdwołajRezerwacje();
    }
}