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
             int jelelegiHelyX = 25;
             int jelelegiHelyY = 49;
             matrix[49, 25] = 1;

            Random rd = new Random();
            while (szobaSzam <= 20)
             {
               
                 int irany = rd.Next(0, 4);
                 if(irany == 1)
                 {
                
                    if (matrix[jelelegiHelyY, jelelegiHelyX - 1] == 0)
                     {
                         szobaSzam++;
                         matrix[jelelegiHelyY, jelelegiHelyX - 1] = 1;
                         jelelegiHelyX--;
                     }
                 }
                 else if(irany == 2)
                 {
    ;
                     if (matrix[jelelegiHelyY - 1, jelelegiHelyX] == 0)
                     {
                         szobaSzam++;
                         matrix[jelelegiHelyY-1, jelelegiHelyX] = 1;
                         jelelegiHelyY--;
                     }
                 }
                 else if (irany == 3)
                 {
        
                    if (matrix[jelelegiHelyY, jelelegiHelyX + 1] == 0)
                     {
                         szobaSzam++;
                         matrix[jelelegiHelyY, jelelegiHelyX + 1] = 1;
                         jelelegiHelyX++;
                     }
                 }

             }

         }

        private void MatrixMegjelenitese()
        {
            listBox1.Items.Clear();
            for (int sor = 0; sor < 50; sor++)
            {
                string aktualisSor = "";
                for (int oszlop = 0; oszlop < 50; oszlop++)
                {
               
                    if (matrix[sor, oszlop] == 0)
                    {
                        aktualisSor += "□ ";
                    }
                    else if (matrix[sor, oszlop] == 1)
                    {
                        aktualisSor += "■ ";
                    }
                    else
                    {
         
                        aktualisSor += matrix[sor, oszlop].ToString() + " ";
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
    }
}
