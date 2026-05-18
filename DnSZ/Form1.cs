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
        int[,] matrix = new int[25, 25];

        public Form1()
        {
            InitializeComponent();
            MatrixFeltoltese();
            SzobaGeneralasa();
            MatrixMegjelenitese();
        }

        private void SzobaGeneralasa()
        {
            int szobaSzam = 0;
            int jelelegiHelyX = 12;
            int jelelegiHelyY = 24;
            matrix[12, 24] = 1;

            while(szobaSzam <= 6)
            {
                Random rd = new Random();
                int irany = rd.Next(0, 3);
                if(irany == 1)
                {

                }
                else if(irany == 2)
                {

                }
                else if (irany == 3)
                {

                }

            }
            
        }

        private void MatrixMegjelenitese()
        {
            listBox1.Items.Clear();
            for (int sor = 0; sor < 25; sor++)
            {
                string aktualisSor = "";
                for (int oszlop = 0; oszlop < 25; oszlop++)
                {
                    aktualisSor += matrix[sor, oszlop].ToString().PadLeft(4);
                }
                listBox1.Items.Add(aktualisSor);
            }
        }

        private void MatrixFeltoltese()
        {
            
            for (int sor = 0; sor < 26; sor++)
            {
                for (int oszlop = 0; oszlop < 26; oszlop++)
                {
                    matrix[sor, oszlop] = 0;
                }
            }

            
        }
    }
}
