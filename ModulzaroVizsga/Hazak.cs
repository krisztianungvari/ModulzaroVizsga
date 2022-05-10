using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulzaroVizsga
{
    class Hazak
    {
        string cim;
        int alapterület;
        string epitesianyag;
        DateTime kezdes;
        DateTime befejezes;
        bool csaladi;


        public Hazak(string cim, int alapterület, string epitesianyag, DateTime kezdes, DateTime befejezes, bool csaladi)
        {
            this.Cim = cim;
            this.Alapterület = alapterület;
            this.Epitesianyag = epitesianyag;
            this.Kezdes = kezdes;
            this.Befejezes = befejezes;
            this.csaladi = csaladi;
        }

        public string Cim { get => cim; set => cim = value; }
        public int Alapterület { get => alapterület; set => alapterület = value; }
        public string Epitesianyag { get => epitesianyag; set => epitesianyag = value; }
        public DateTime Kezdes { get => kezdes; set => kezdes = value; }
        public DateTime Befejezes { get => befejezes; set => befejezes = value; }

        public override string ToString()
        {
            return cim;
        }
    }
    

}
