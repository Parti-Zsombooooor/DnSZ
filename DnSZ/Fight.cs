using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnSZ
{
    public partial class Fight : Form
    {
        static List<Player> Player = new List<Player>();
        static List<Enemy> Enemy = new List<Enemy>();

        static int MaxHp = 0;
        static int MaxMana = 0;
        static int MaxHpE = 0;
        static int PotiUsed = 0;

        public Fight()
        {
            InitializeComponent();
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            Player = FileIO.Beolvasas(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Properties", "Player.txt"));
            Enemy = FileIO.BeolvasasE(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Properties", "Enemy.txt"));


            MaxHp = Player[0].HP;
            MaxMana = Player[0].Mana;
            MaxHpE = Enemy[0].HP;

            Kezdes();
        }

        Random Random = new Random();
        private void Kezdes()
        {
            MenuLBOX.Items.Clear();
            MenuLBOX.Items.Add("Fight");
            MenuLBOX.Items.Add("Run");
            MenuLBOX.SelectedIndex = 0;
            MenuLBOX.Focus();
            ellenfelLBOX.Visible = false;
            this.ControlBox = true;


            List<string> szornyekKepekLista = new List<string> { "Varazslo", "Vampir", "Denever", "Boszorkany"};
            Enemy[0].Nev = szornyekKepekLista[Random.Next(0, szornyekKepekLista.Count)];


            PlayerPBOX.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Properties", "Player.png"));
            EnemyPBOX.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Properties", $"{Enemy[0].Nev}.png"));
            Kiiras();
        }
        private void Kiiras()
        {
            hpCSIK.Maximum = MaxHp;
            if (Player[0].HP < 0)
            {
                hpCSIK.Value = 0;
            }
            else
            {
                hpCSIK.Value = Player[0].HP;
            }

            manaCSIK.Maximum = MaxMana;
            if (Player[0].Mana < 0)
            {
                manaCSIK.Value = 0;
            }
            else
            {
                manaCSIK.Value = Player[0].Mana;
            }

            hpCSIKSZ.Text = Player[0].HP.ToString();
            manaCSIKSZ.Text = Player[0].Mana.ToString();

            hpCSIKENEMY.Maximum = MaxHpE;
            if (Enemy[0].HP < 0)
            {
                Enemy[0].HP = 0;
            }
            else
            {
                hpCSIKENEMY.Value = Enemy[0].HP;
            }
            hpCSIKSZENEMY.Text = Enemy[0].HP.ToString();
            enemyNEV.Text = Enemy[0].Nev;

        }
        private void MenuLBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MenuLBOX.SelectedItem.ToString() == "Fight")
                {
                    this.ControlBox = false;
                    HarcBetoltes();
                }
                else if (MenuLBOX.SelectedItem.ToString() == "Run")
                {
                    this.Close();
                }
                else if (MenuLBOX.SelectedItem.ToString() == "Hit")
                {
                    Utesek();
                }
                else if (MenuLBOX.SelectedItem.ToString() == "Potion")
                {
                    Potion();
                }
                else if (MenuLBOX.SelectedItem.ToString() == "Leave")
                {
                    HarcBetoltes();
                }
                else if (MenuLBOX.SelectedItem.ToString().Contains("Heal"))
                {
                    if (Player[0].HPPoti > 0 && Player[0].HP != MaxHp && PotiUsed == 0)
                    {
                        Player[0].HPPoti--;
                        PotiUsed++;
                        if (MaxHp - Player[0].HP >= 10)
                        {
                            Player[0].HP += 10;
                        }
                        else
                        {
                            Player[0].HP = MaxHp;
                        }
                        Kiiras();
                        Potion();
                    }
                }
                else if (MenuLBOX.SelectedItem.ToString().Contains("Mana"))
                {
                    if (Player[0].ManaPoti > 0 && Player[0].Mana != MaxMana && PotiUsed == 0)
                    {
                        Player[0].ManaPoti--;
                        PotiUsed++;
                        if (MaxMana - Player[0].Mana >= 5)
                        {
                            Player[0].Mana += 5;
                        }
                        else
                        {
                            Player[0].Mana = MaxMana;
                        }
                        Kiiras();
                        Potion();
                    }
                }
                else if (MenuLBOX.SelectedItem.ToString().Contains("Punch"))
                {
                    if (Player[0].Mana >= 5)
                    {
                        Player[0].Mana -= 5;
                        int punch = 4;
                        int utes = DmgSzamlalo(punch);
                        Enemy[0].HP -= utes;
                        ellenfelLBOX.Visible = false;
                        Kiiras();
                        EllenfelTamad();
                    }
                }
                else if (MenuLBOX.SelectedItem.ToString().Contains("Kick"))
                {
                    if (Player[0].Mana >= 7)
                    {
                        Player[0].Mana -= 7;
                        int punch = 6;
                        int utes = DmgSzamlalo(punch);
                        Enemy[0].HP -= utes;
                        ellenfelLBOX.Visible = false;
                        Kiiras();
                        EllenfelTamad();
                    }
                }
                else if (MenuLBOX.SelectedItem.ToString().Contains("Spit"))
                {
                    if (Player[0].Mana >= 2)
                    {
                        Player[0].Mana -= 2;
                        int punch = 1;
                        int utes = DmgSzamlalo(punch);
                        Enemy[0].HP -= utes;
                        ellenfelLBOX.Visible = false;
                        Kiiras();
                        EllenfelTamad();
                    }
                }
            }
        }
        private async void EllenfelTamad()
        {
            MenuLBOX.Enabled = false;
            if (Enemy[0].HP <= 0)
            {
                int jutalom = Enemy[0].LVL * 2 + 5;
                Player[0].XP += jutalom;

                int SzerzettSzint = 0;
                int FejlodeshezSzuksegesXP = 10 + (Player[0].Lvl * 5);

                while (Player[0].XP >= FejlodeshezSzuksegesXP)
                {
                    Player[0].XP -= FejlodeshezSzuksegesXP;
                    Player[0].Lvl++;
                    Player[0].HP += 2;
                    SzerzettSzint++;
                    FejlodeshezSzuksegesXP = 10 + (Player[0].Lvl * 5);
                }
                if (SzerzettSzint > 0)
                {
                    MessageBox.Show($"Győztél! Jutalomként {jutalom} XP-t kaptál!\n\nSzintet léptél! Mostani szint: {Player[0].Lvl}\nMaradék XP: {Player[0].XP}");
                }
                else
                {
                    MessageBox.Show($"Győztél! Jutalomként {jutalom} XP-t kaptál!\nMaradék XP a szintlépésig: {FejlodeshezSzuksegesXP - Player[0].XP}");
                }


                FileIO.Mentes(Player, MaxHp, MaxMana);
                Form1 jatekstart = new Form1();
                this.Close();
                jatekstart.ShowDialog();
            }
            else
            {
                ellenfelLBOX.Items.Clear();
                Random random = new Random();
                int randomSZ = random.Next(0, 100);
                int randomHeal = random.Next(1, 4);
                if (randomSZ > 90)
                {
                    int erosseg = 7;
                    int utes = DmgSzamlaloE(erosseg);
                    Enemy[0].HP += randomHeal;
                    Player[0].HP -= utes;
                    ellenfelLBOX.Items.Add($"{Enemy[0].Nev} Critical hit you! -{utes}HP");
                    ellenfelLBOX.Items.Add($"{Enemy[0].Nev} healed for {randomHeal} HP!");
                }
                else if (randomSZ > 60)
                {
                    int erosseg = 5;
                    int utes = DmgSzamlaloE(erosseg);
                    Player[0].HP -= utes;
                    ellenfelLBOX.Items.Add($"{Enemy[0].Nev} hit you! -{utes}HP");
                }
                else if (randomSZ > 30)
                {
                    int erosseg = 3;
                    int utes = DmgSzamlaloE(erosseg);
                    Player[0].HP -= utes;
                    ellenfelLBOX.Items.Add($"{Enemy[0].Nev} hit you! -{utes}HP");
                }
                else
                {
                    int erosseg = 2;
                    int utes = DmgSzamlaloE(erosseg);
                    Enemy[0].HP += randomHeal;
                    Player[0].HP -= utes;
                    ellenfelLBOX.Items.Add($"{Enemy[0].Nev} hit you! -{utes}HP");
                    ellenfelLBOX.Items.Add($"{Enemy[0].Nev} healed for {randomHeal} HP!");
                }
                await Task.Delay(3000);
                Player[0].Mana += 2;
                Kiiras();
                ellenfelLBOX.Visible = true;
                await Task.Delay(2000);
                if (Player[0].HP <= 0)
                {
                    FileIO.Mentes(Player, MaxHp, MaxMana);
                    MessageBox.Show("Vesztettél!");
                    this.Close();
                }
                else
                {
                    PotiUsed = 0;
                    HarcBetoltes();
                }

            }
        }
        private int DmgSzamlaloE(int erosseg)
        {
            double utes = Math.Round(Player[0].Lvl * 0.2 + erosseg * 0.9, 0);
            return Convert.ToInt32(utes);
        }

        private int DmgSzamlalo(int melyik)
        {
            double utes = Math.Round(Player[0].Lvl * 0.5 + melyik, 0);
            return Convert.ToInt32(utes);
        }
        private void Potion()
        {
            MenuLBOX.Items.Clear();
            MenuLBOX.Items.Add($"Heal {Player[0].HPPoti}");
            MenuLBOX.Items.Add($"Mana {Player[0].ManaPoti}");
            MenuLBOX.Items.Add("Leave");
            MenuLBOX.SelectedIndex = 0;
        }
        private void Utesek()
        {
            MenuLBOX.Items.Clear();
            MenuLBOX.Items.Add("Punch (5 Mn)");
            MenuLBOX.Items.Add("Kick (7 Mn)");
            MenuLBOX.Items.Add("Spit (2 Mn)");
            MenuLBOX.Items.Add("Leave");
            MenuLBOX.SelectedIndex = 0;
        }
        private void HarcBetoltes()
        {

            MenuLBOX.Items.Clear();
            MenuLBOX.Items.Add("Hit");
            MenuLBOX.Items.Add("Potion");
            MenuLBOX.SelectedIndex = 0;
            MenuLBOX.Enabled = true;
            MenuLBOX.Focus();
        }


    }
}
