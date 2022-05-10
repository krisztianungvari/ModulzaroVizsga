using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulzaroVizsga
{
    class Tombhaz:Hazak
    {
        int lakasokszama;
        string tipus;
        bool lift;

        public Tombhaz(bool csaladi,string cim, int alapterület, string epitesianyag, DateTime kezdes, DateTime befejezes,int lakasokszama, string tipus, bool lift):base(cim,alapterület,epitesianyag,kezdes,befejezes,csaladi)
        {
            this.lakasokszama = lakasokszama;
            this.tipus = tipus;
            this.lift = lift;
        }
        public int becsultar()
        {
            return Alapterület * lakasokszama * 8000 + (lift ? 0 : 100000);
        }
    }
}
