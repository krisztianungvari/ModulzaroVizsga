using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulzaroVizsga
{
    enum Tetotipusa
    {
        cserép,
        zsindely,
        nád
    }
    class Csaladihaz : Hazak
    {
        int ottelok;
        bool garazs;
        string tetotipusa;

        public int Ottelok { get => ottelok; set => ottelok = value; }
        public bool Garazs { get => garazs; set => garazs = value; }
        internal string Tetotipusa { get => tetotipusa; set => tetotipusa = value; }

        public Csaladihaz(string cim, int alapterület, bool csaladi, string epitesianyag, DateTime kezdes, DateTime befejezes, int ottelok, bool garazs, string tetotipusa):base(cim,alapterület, epitesianyag, kezdes, befejezes,csaladi)
        {
            Ottelok = ottelok;
            Garazs = garazs;
            Tetotipusa = tetotipusa;
            Ottelok = ottelok;
            Garazs = garazs;
            Tetotipusa = tetotipusa;
        }
        public int becsultar()
        {
            return Alapterület * Ottelok * 10000;
        }
        public override string ToString()
        {
            return string.Join(";", Cim, Alapterület, Epitesianyag,Kezdes,Befejezes);
        }
    }


   
   
}
