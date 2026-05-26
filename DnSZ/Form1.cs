using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
            MatrixFeltoltese();
            SzobaGeneralasa();
            MatrixMegjelenitese();
            this.KeyPreview = true;
            timer1.Start();
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

            int utolsoSzobaX = 0;
            int utolsoSzobaY = 0;

            int akartSzobaSzam = 10;

            Random rd = new Random();
            while (szobaSzam <= akartSzobaSzam)
             {
               
                 int irany = rd.Next(0, 4);
                 if(irany == 1)
                 {

                    if (matrix[jelelegiHelyY, jelelegiHelyX - 1] == 0 && ErintesChek(jelelegiHelyY, jelelegiHelyX - 1) && ismetlesBal <= 1)
                    {
                        szobaSzam++;
                        matrix[jelelegiHelyY, jelelegiHelyX - 1] = 1;
                        jelelegiHelyX--;
                        ismetlesBal++;
                        ismetlesJobb = 0;
                        ismetlesFel = 0;
                       
                        if(szobaSzam == akartSzobaSzam - 1)
                        {
                            utolsoSzobaX = jelelegiHelyX - 1;
                            utolsoSzobaY = jelelegiHelyY;
                        }
                    }
                }
                 else if(irany == 2)
                 {
    ;
                     if (matrix[jelelegiHelyY - 1, jelelegiHelyX] == 0 && ErintesChek(jelelegiHelyY - 1, jelelegiHelyX) && ismetlesFel <= 1)
                     {
                         szobaSzam++;
                         matrix[jelelegiHelyY-1, jelelegiHelyX] = 1;
                         jelelegiHelyY--;
                        ismetlesFel++;
                        ismetlesJobb = 0;
                        ismetlesBal = 0;

                        if (szobaSzam == akartSzobaSzam - 1)
                        {
                            utolsoSzobaX = jelelegiHelyX;
                            utolsoSzobaY = jelelegiHelyY - 1;
                        }
                    }
                 }
                 else if (irany == 3)
                 {
        
                    if (matrix[jelelegiHelyY, jelelegiHelyX + 1] == 0 && ErintesChek(jelelegiHelyY, jelelegiHelyX + 1) && ismetlesJobb <= 1)
                     {
                         szobaSzam++;
                         matrix[jelelegiHelyY, jelelegiHelyX + 1] = 1;
                         jelelegiHelyX++;
                        ismetlesJobb++;
                        ismetlesBal = 0;
                        ismetlesFel = 0;

                        if (szobaSzam == akartSzobaSzam - 1)
                        {
                            utolsoSzobaX = jelelegiHelyX + 1;
                            utolsoSzobaY = jelelegiHelyY;
                        }
                    }
                 }

             }

            

        }

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
                    else
                    {
                        aktualisSor += "    ";
                    }
                }
                listBox1.Items.Add(aktualisSor);
            }
        }

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
        }

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
        }
    }
}
