using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnSZ
{
    internal class FileIO
    {
        public static List<Player> Beolvasas(string path)
        {
            List<Player> player = new List<Player>();
            try
            {
                StreamReader olvas = new StreamReader(path);
                olvas.ReadLine();
                player.Add(new Player(olvas.ReadLine()));
                olvas.Close();
            }
            catch (IOException)
            {
            }
            return player;
        }
        public static List<Enemy> BeolvasasE(string path)
        {
            List<Enemy> Enemys = new List<Enemy>();
            try
            {
                StreamReader olvas = new StreamReader(path);
                olvas.ReadLine();
                Enemys.Add(new Enemy(olvas.ReadLine()));
                olvas.Close();
            }
            catch (IOException)
            {
            }
            return Enemys;
        }

        public static void Mentes(List<Player> Player, int MaxHp, int MaxMana)
        {
            try
            {
                string adatok = $"{Player[0].XP};{Player[0].Lvl};{MaxHp};{MaxMana};{Player[0].HPPoti};{Player[0].ManaPoti}";
                StreamWriter ir = new StreamWriter("Player.txt");
                ir.WriteLine("XP;LVL;HP;Mana;HPPoti;ManaPoti");
                ir.WriteLine(adatok);
                ir.Flush();
                ir.Close();
            }
            catch (IOException)
            {

                throw;
            }
        }

    }
}
