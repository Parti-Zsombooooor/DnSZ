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
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            TitlePBOX.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Properties", "titlecard.png"));
            TitlePBOX.BackColor = Color.Transparent;
            nametxtPBOX.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Properties", "nametxt.png"));
            nametxtPBOX.BackColor = Color.Transparent;

            FileIO.Tisztitas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 jatekstart = new Form1();
            this.Hide();
            jatekstart.ShowDialog();
            this.Show();
        }

    }
}
