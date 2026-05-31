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
    public partial class Form1 : Form
    {
        int[,] matrix = new int[50, 50];
        Boolean MehetFel = true;
        Boolean MehetLe = true;
        Boolean MehetJobb = true;
        Boolean MehetBal = true;

        static List<Player> Player = new List<Player>();
        static int MaxHp = 0;
        static int MaxMana = 0;

        Boolean ereintiAjtot = false;

        int JelelegiHelyXPlayer = 25;
        int JelelegiHelyYPlayer = 48;

        int utolsoSzobaX = 0;
        int utolsoSzobaY = 0;
        public Form1()
        {
            InitializeComponent();
            Player = FileIO.Beolvasas(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Properties", "Player.txt"));
            MaxHp = Player[0].HP;
            MaxMana = Player[0].Mana;

            MatrixFeltoltese();
            SzobaGeneralasa();
            MatrixMegjelenitese();
            this.KeyPreview = true;
           
            timer1.Start();
            SzobaMegjelenitese();

            AtlatszosagAllito(totemPBox, pictureBox1);
            AtlatszosagAllito(chestPBox, pictureBox1);
        

        }

        private void SzobaMegjelenitese()
        {
            int y = JelelegiHelyYPlayer;
            int x = JelelegiHelyXPlayer;

            //Ez a rész az ajtok megjeleniteset csinalja, megnezi hogy a matrixban
            //a jelenlegi helyhez melyik iranyban van szoba,
            //es annak megfeleloen jeleniti meg az ajtokat.

            int erintettSzobak = 0;
            if (matrix[y, x - 1] != 0)
            {
                AjtoBal.Visible = true;
            }
            else
            {
                AjtoBal.Visible = false;
            }

            if (matrix[y, x + 1] != 0)
            {
                AjtoJobb.Visible = true;
            }
            else
            {
                AjtoJobb.Visible = false;
            }

            if (matrix[y + 1, x] != 0)
            {
                AjtoLe.Visible = true;
            }
            else
            {
                AjtoLe.Visible = false;
            }

            if (matrix[y - 1, x] != 0)
            {
                AjtoFel.Visible = true;
            }
            else
            {
                AjtoFel.Visible = false;
            }



            if (matrix[JelelegiHelyYPlayer, JelelegiHelyXPlayer] == 2)
            {
                chestPBox.Visible = true;
            }
            else
            {
                chestPBox.Visible = false;

            }

            if (JelelegiHelyYPlayer == utolsoSzobaY && JelelegiHelyXPlayer == utolsoSzobaX)
            {
                totemPBox.Visible = true;
            }
            else
            {
                totemPBox.Visible = false;

            }
        }

        private void SzobaGeneralasa()
        {
            int szobaSzam = 0;
            int jelelegiHelyX = 25;
            int jelelegiHelyY = 48;
            matrix[48, 25] = 1;
            int ismetlesFel = 0;
            int ismetlesJobb = 0;
            int ismetlesBal = 0;

            int akartSzobaSzam = 10;
            Random rd = new Random();
            int ladaSzobaSzama = 4;

            while (szobaSzam <= akartSzobaSzam)
            {
                int irany = rd.Next(0, 4);

                if (irany == 1) // Balra generált szoba
                {
                    if (matrix[jelelegiHelyY, jelelegiHelyX - 1] == 0 && ErintesChek(jelelegiHelyY, jelelegiHelyX - 1) && ismetlesBal <= 1)
                    {
                        szobaSzam++;

                        if (ladaSzobaSzama != 0 && rd.Next(0, 3) == 1)
                        {
                            matrix[jelelegiHelyY, jelelegiHelyX - 1] = 2;
                            ladaSzobaSzama--;
                        }
                        else
                        {
                            matrix[jelelegiHelyY, jelelegiHelyX - 1] = 1;
                        }

                        jelelegiHelyX--;
                        ismetlesBal++;
                        ismetlesJobb = 0;
                        ismetlesFel = 0;

                        // Mindig frissítjük az utolsó szoba koordinátáit
                        utolsoSzobaX = jelelegiHelyX;
                        utolsoSzobaY = jelelegiHelyY;
                    }
                }
                else if (irany == 2) // Fel generált szoba
                {
                    if (matrix[jelelegiHelyY - 1, jelelegiHelyX] == 0 && ErintesChek(jelelegiHelyY - 1, jelelegiHelyX) && ismetlesFel <= 1)
                    {
                        szobaSzam++;

                        if (ladaSzobaSzama != 0 && rd.Next(0, 3) == 1)
                        {
                            matrix[jelelegiHelyY - 1, jelelegiHelyX] = 2;
                            ladaSzobaSzama--;
                        }
                        else
                        {
                            matrix[jelelegiHelyY - 1, jelelegiHelyX] = 1;
                        }

                        jelelegiHelyY--;
                        ismetlesFel++;
                        ismetlesJobb = 0;
                        ismetlesBal = 0;

                        // Mindig frissítjük az utolsó szoba koordinátáit
                        utolsoSzobaX = jelelegiHelyX;
                        utolsoSzobaY = jelelegiHelyY;
                    }
                }
                else if (irany == 3) // Jobb generált szoba
                {
                    if (matrix[jelelegiHelyY, jelelegiHelyX + 1] == 0 && ErintesChek(jelelegiHelyY, jelelegiHelyX + 1) && ismetlesJobb <= 1)
                    {
                        szobaSzam++;

                        if (ladaSzobaSzama != 0 && rd.Next(0, 3) == 1)
                        {
                            matrix[jelelegiHelyY, jelelegiHelyX + 1] = 2;
                            ladaSzobaSzama--;
                        }
                        else
                        {
                            matrix[jelelegiHelyY, jelelegiHelyX + 1] = 1;
                        }

                        jelelegiHelyX++;
                        ismetlesJobb++;
                        ismetlesBal = 0;
                        ismetlesFel = 0;

                        // Mindig frissítjük az utolsó szoba koordinátáit
                        utolsoSzobaX = jelelegiHelyX;
                        utolsoSzobaY = jelelegiHelyY;
                    }
                }
            }

            //legutolsó szobában ne legyen láda.
            matrix[utolsoSzobaY, utolsoSzobaX] = 1;
        }

        //Ez a rész azért van hogy ne lehhes több szoba egymás mellet.
        private bool ErintesChek(int Y, int x)
        {
            int erintettSzobak = 0;
            if(matrix[Y, x + 1] == 1)
            {
                erintettSzobak++;
            }
            if (matrix[Y, x - 1] == 1)
            {
                erintettSzobak++;
            }
            if (matrix[Y + 1, x] == 1)
            {
                erintettSzobak++;
            }
            if (matrix[Y - 1, x] == 1)
            {
                erintettSzobak++;
            }

            if(erintettSzobak > 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void MatrixMegjelenitese()
        {
            int legfelsoSor = 50, legalsoSor = -1;
            int legbaloldalibbOszlop = 50, legjobboldalibbOszlop = -1;

            for (int sor = 0; sor < 50; sor++)
            {
                for (int oszlop = 0; oszlop < 50; oszlop++)
                {
                    if (matrix[sor, oszlop] == 1)
                    {
                        if (sor < legfelsoSor) legfelsoSor = sor;
                        if (sor > legalsoSor) legalsoSor = sor;
                        if (oszlop < legbaloldalibbOszlop) legbaloldalibbOszlop = oszlop;
                        if (oszlop > legjobboldalibbOszlop) legjobboldalibbOszlop = oszlop;
                    }
                }
            }

            listBox1.Items.Clear();
            if (legalsoSor == -1)
            {
                listBox1.Items.Add("A mátrix teljesen üres, nincsenek szobák.");
                return;
            }
            for (int sor = legfelsoSor; sor <= legalsoSor; sor++)
            {
                string aktualisSor = "";
                for (int oszlop = legbaloldalibbOszlop; oszlop <= legjobboldalibbOszlop; oszlop++)
                {
                    if (matrix[sor, oszlop] == 1)
                    {
                        aktualisSor += "■ ";
                    }
                    else if(matrix[sor, oszlop] == 2)
                    {
                        aktualisSor += "▦ ";
                    }
                    else
                    {
                        aktualisSor += "    ";
                    }
                }
                listBox1.Items.Add(aktualisSor);
            }
        }


        //Feltőltjük 0-kal a matrixot hogy leheseen bel írni
        private void MatrixFeltoltese()
        {
            
            for (int sor = 0; sor < 50; sor++)
            {
                for (int oszlop = 0; oszlop < 50; oszlop++)
                {
                    matrix[sor, oszlop] = 0;
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatrixFeltoltese();
            SzobaGeneralasa();
            MatrixMegjelenitese();
            SzobaMegjelenitese();
        }
        Random rd2 = new Random();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && MehetFel){
                PL.Location = new Point(PL.Location.X, PL.Location.Y -10);
            }
            if (e.KeyCode == Keys.A && MehetBal)
            {
                PL.Location = new Point(PL.Location.X - 10, PL.Location.Y);
            }
            if (e.KeyCode == Keys.S && MehetLe)
            {
                PL.Location = new Point(PL.Location.X, PL.Location.Y + 10);
            }
            if (e.KeyCode == Keys.D && MehetJobb)
            {
                PL.Location = new Point(PL.Location.X + 10, PL.Location.Y);
            }

            //Átalakítjuk mindkét vezérlő pozícióját globális képernyő-koordinátákká
            Rectangle plKepernyoBounds = PL.RectangleToScreen(PL.ClientRectangle);
            Rectangle chestKepernyoBounds = chestPBox.RectangleToScreen(chestPBox.ClientRectangle);

           
            //Összehasonlítjuk a globális koordinátákat, ÉS megnézzük, hogy a láda egyáltalán látható-e
            if (plKepernyoBounds.IntersectsWith(chestKepernyoBounds) && e.KeyCode == Keys.E && chestPBox.Visible)
            {

                if(rd2.Next(0,3) == 1)
                {
                    if(rd2.Next(0, 4) == 1)
                    {
                        Player[0].HPPoti = Player[0].HPPoti + 2;
                    }
                    else
                    {
                        Player[0].HPPoti++;
                    }
                }
                else
                {
                    if (rd2.Next(0, 4) == 1)
                    {
                        Player[0].ManaPoti = Player[0].ManaPoti + 2;
                    }
                    else
                    {
                        Player[0].ManaPoti++;
                    }
                }
                chestPBox.Visible = false;




            }

            Rectangle plKepernyoBounds2 = PL.RectangleToScreen(PL.ClientRectangle);
            Rectangle totemKepernyoBounds2 = totemPBox.RectangleToScreen(totemPBox.ClientRectangle);


            if (plKepernyoBounds2.IntersectsWith(totemKepernyoBounds2) && e.KeyCode == Keys.E && totemPBox.Visible)
            {

                FileIO.Mentes(Player, MaxHp, MaxMana);
                Fight jatekstart = new Fight();
                this.Hide();
                jatekstart.ShowDialog();
                this.Show();
            }
        }

        private void AtlatszosagAllito(PictureBox child, PictureBox newParent)
        {
            //Átlátszó háttér
            child.BackColor = Color.Transparent;

            //Új szülő beállítása
            child.Parent = newParent;

            //Pozíció eltolása az új szülőhöz képest
            child.Location = new Point(
                child.Location.X - newParent.Location.X,
                child.Location.Y - newParent.Location.Y
            );
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PL.Bounds.IntersectsWith(BorderFel.Bounds))
            {
                MehetFel = false;
            }
            else
            {
                MehetFel = true;
            }

            if (PL.Bounds.IntersectsWith(BorderLe.Bounds))
            {
                MehetLe = false;
            }
            else
            {
                MehetLe = true;
            }

            if (PL.Bounds.IntersectsWith(BorderBal.Bounds))
            {
                MehetBal = false;
            }
            else
            {
                MehetBal = true;
            }

            if (PL.Bounds.IntersectsWith(BorderJobb.Bounds))
            {
                MehetJobb = false;
            }
            else
            {
                MehetJobb = true;
            }


            label1.Text = "X: " + JelelegiHelyXPlayer + " Y: " + JelelegiHelyYPlayer;


            if (PL.Bounds.IntersectsWith(AjtoBal.Bounds) && AjtoBal.Visible == true)
            {
                JelelegiHelyXPlayer--;
                SzobaMegjelenitese();
                PL.Location = new Point(754, 311);
            }

            if (PL.Bounds.IntersectsWith(AjtoFel.Bounds) && AjtoFel.Visible == true)
            {
                JelelegiHelyYPlayer--;
                SzobaMegjelenitese();
                PL.Location = new Point(546, 532);
            }

            if (PL.Bounds.IntersectsWith(AjtoJobb.Bounds) && AjtoJobb.Visible == true)
            {
                JelelegiHelyXPlayer++;
                SzobaMegjelenitese();
                PL.Location = new Point(318, 313);
            }

            if (PL.Bounds.IntersectsWith(AjtoLe.Bounds) && AjtoLe.Visible == true)
            {
                JelelegiHelyYPlayer++;
                SzobaMegjelenitese();
                PL.Location = new Point(554, 82);
            }

    

        
        }
    }
}
