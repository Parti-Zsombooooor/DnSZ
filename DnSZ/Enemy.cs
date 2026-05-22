using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnSZ
{
    internal class Enemy
    {
        public string Nev;
        public int HP;
        public int LVL;
        public int MinDMG;

        public Enemy(string sor)
        {
            Nev = sor.Split(';')[0];
            HP = Convert.ToInt32(sor.Split(';')[1]);
            LVL = Convert.ToInt32(sor.Split(';')[2]);
            MinDMG = Convert.ToInt32(sor.Split(';')[3]);
        }
    }
}
