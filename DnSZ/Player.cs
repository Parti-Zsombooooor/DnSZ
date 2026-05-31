using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnSZ
{
    internal class Player
    {
        public int XP;
        public int Lvl;
        public int HP;
        public int Mana;
        public int HPPoti;
        public int ManaPoti;


        public Player(string sor)
        {
            XP = Convert.ToInt32(sor.Split(';')[0]);
            Lvl = Convert.ToInt32(sor.Split(';')[1]);
            HP = Convert.ToInt32(sor.Split(';')[2]);
            Mana = Convert.ToInt32(sor.Split(';')[3]);
            HPPoti = Convert.ToInt32(sor.Split(';')[4]);
            ManaPoti = Convert.ToInt32(sor.Split(';')[5]);


        }
    }
}
