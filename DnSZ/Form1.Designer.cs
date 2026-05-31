namespace DnSZ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BorderBal = new System.Windows.Forms.Panel();
            this.BorderFel = new System.Windows.Forms.Panel();
            this.BorderLe = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BorderJobb = new System.Windows.Forms.Panel();
            this.AjtoLe = new System.Windows.Forms.PictureBox();
            this.AjtoFel = new System.Windows.Forms.PictureBox();
            this.AjtoJobb = new System.Windows.Forms.PictureBox();
            this.AjtoBal = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chestPBox = new System.Windows.Forms.PictureBox();
            this.totemPBox = new System.Windows.Forms.PictureBox();
            this.PL = new System.Windows.Forms.PictureBox();
            this.lvlLabel = new System.Windows.Forms.Label();
            this.ManaPotiLabel = new System.Windows.Forms.Label();
            this.HpPotiLabel = new System.Windows.Forms.Label();
            this.Ebetu = new System.Windows.Forms.Label();
            this.totemLb = new System.Windows.Forms.Label();
            this.BorderLe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoLe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoFel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoJobb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totemPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PL)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderBal
            // 
            this.BorderBal.BackColor = System.Drawing.Color.Transparent;
            this.BorderBal.Location = new System.Drawing.Point(170, 27);
            this.BorderBal.Name = "BorderBal";
            this.BorderBal.Size = new System.Drawing.Size(131, 602);
            this.BorderBal.TabIndex = 7;
            // 
            // BorderFel
            // 
            this.BorderFel.BackColor = System.Drawing.Color.Transparent;
            this.BorderFel.Location = new System.Drawing.Point(179, 4);
            this.BorderFel.Name = "BorderFel";
            this.BorderFel.Size = new System.Drawing.Size(768, 66);
            this.BorderFel.TabIndex = 9;
            // 
            // BorderLe
            // 
            this.BorderLe.BackColor = System.Drawing.Color.Transparent;
            this.BorderLe.Controls.Add(this.totemLb);
            this.BorderLe.Controls.Add(this.Ebetu);
            this.BorderLe.Location = new System.Drawing.Point(166, 587);
            this.BorderLe.Name = "BorderLe";
            this.BorderLe.Size = new System.Drawing.Size(768, 56);
            this.BorderLe.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BorderJobb
            // 
            this.BorderJobb.BackColor = System.Drawing.Color.Transparent;
            this.BorderJobb.Location = new System.Drawing.Point(822, 27);
            this.BorderJobb.Name = "BorderJobb";
            this.BorderJobb.Size = new System.Drawing.Size(131, 602);
            this.BorderJobb.TabIndex = 8;
            // 
            // AjtoLe
            // 
            this.AjtoLe.Image = global::DnSZ.Properties.Resources.ajtoforog;
            this.AjtoLe.Location = new System.Drawing.Point(514, 583);
            this.AjtoLe.Name = "AjtoLe";
            this.AjtoLe.Size = new System.Drawing.Size(96, 24);
            this.AjtoLe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AjtoLe.TabIndex = 11;
            this.AjtoLe.TabStop = false;
            // 
            // AjtoFel
            // 
            this.AjtoFel.Image = global::DnSZ.Properties.Resources.ajtoforog;
            this.AjtoFel.Location = new System.Drawing.Point(520, 47);
            this.AjtoFel.Name = "AjtoFel";
            this.AjtoFel.Size = new System.Drawing.Size(96, 24);
            this.AjtoFel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AjtoFel.TabIndex = 4;
            this.AjtoFel.TabStop = false;
            // 
            // AjtoJobb
            // 
            this.AjtoJobb.Image = global::DnSZ.Properties.Resources.ajto;
            this.AjtoJobb.Location = new System.Drawing.Point(819, 282);
            this.AjtoJobb.Name = "AjtoJobb";
            this.AjtoJobb.Size = new System.Drawing.Size(24, 96);
            this.AjtoJobb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AjtoJobb.TabIndex = 3;
            this.AjtoJobb.TabStop = false;
            // 
            // AjtoBal
            // 
            this.AjtoBal.Image = global::DnSZ.Properties.Resources.ajto;
            this.AjtoBal.Location = new System.Drawing.Point(283, 282);
            this.AjtoBal.Name = "AjtoBal";
            this.AjtoBal.Size = new System.Drawing.Size(24, 96);
            this.AjtoBal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AjtoBal.TabIndex = 2;
            this.AjtoBal.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DnSZ.Properties.Resources.mapElso;
            this.pictureBox1.Location = new System.Drawing.Point(283, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chestPBox
            // 
            this.chestPBox.BackColor = System.Drawing.Color.Black;
            this.chestPBox.Image = global::DnSZ.Properties.Resources.chestClose;
            this.chestPBox.Location = new System.Drawing.Point(515, 283);
            this.chestPBox.Name = "chestPBox";
            this.chestPBox.Size = new System.Drawing.Size(100, 100);
            this.chestPBox.TabIndex = 0;
            this.chestPBox.TabStop = false;
            this.chestPBox.Visible = false;
            // 
            // totemPBox
            // 
            this.totemPBox.BackColor = System.Drawing.Color.Black;
            this.totemPBox.Image = global::DnSZ.Properties.Resources.totem;
            this.totemPBox.Location = new System.Drawing.Point(487, 201);
            this.totemPBox.Name = "totemPBox";
            this.totemPBox.Size = new System.Drawing.Size(146, 210);
            this.totemPBox.TabIndex = 12;
            this.totemPBox.TabStop = false;
            this.totemPBox.Visible = false;
            // 
            // PL
            // 
            this.PL.Image = global::DnSZ.Properties.Resources.PlayerGame;
            this.PL.Location = new System.Drawing.Point(536, 417);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(50, 50);
            this.PL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PL.TabIndex = 13;
            this.PL.TabStop = false;
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.lvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvlLabel.ForeColor = System.Drawing.Color.White;
            this.lvlLabel.Location = new System.Drawing.Point(12, 27);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(79, 29);
            this.lvlLabel.TabIndex = 14;
            this.lvlLabel.Text = "LVL: 0";
            // 
            // ManaPotiLabel
            // 
            this.ManaPotiLabel.AutoSize = true;
            this.ManaPotiLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManaPotiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManaPotiLabel.ForeColor = System.Drawing.Color.White;
            this.ManaPotiLabel.Location = new System.Drawing.Point(12, 65);
            this.ManaPotiLabel.Name = "ManaPotiLabel";
            this.ManaPotiLabel.Size = new System.Drawing.Size(139, 29);
            this.ManaPotiLabel.TabIndex = 15;
            this.ManaPotiLabel.Text = "ManaPoti: 0";
            // 
            // HpPotiLabel
            // 
            this.HpPotiLabel.AutoSize = true;
            this.HpPotiLabel.BackColor = System.Drawing.Color.Transparent;
            this.HpPotiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HpPotiLabel.ForeColor = System.Drawing.Color.White;
            this.HpPotiLabel.Location = new System.Drawing.Point(12, 103);
            this.HpPotiLabel.Name = "HpPotiLabel";
            this.HpPotiLabel.Size = new System.Drawing.Size(111, 29);
            this.HpPotiLabel.TabIndex = 16;
            this.HpPotiLabel.Text = "HpPoti: 0";
            // 
            // Ebetu
            // 
            this.Ebetu.AutoSize = true;
            this.Ebetu.BackColor = System.Drawing.Color.Transparent;
            this.Ebetu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ebetu.ForeColor = System.Drawing.Color.White;
            this.Ebetu.Location = new System.Drawing.Point(175, 23);
            this.Ebetu.Name = "Ebetu";
            this.Ebetu.Size = new System.Drawing.Size(19, 29);
            this.Ebetu.TabIndex = 17;
            this.Ebetu.Text = " ";
            // 
            // totemLb
            // 
            this.totemLb.AutoSize = true;
            this.totemLb.BackColor = System.Drawing.Color.Transparent;
            this.totemLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totemLb.ForeColor = System.Drawing.Color.White;
            this.totemLb.Location = new System.Drawing.Point(204, 23);
            this.totemLb.Name = "totemLb";
            this.totemLb.Size = new System.Drawing.Size(19, 29);
            this.totemLb.TabIndex = 18;
            this.totemLb.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DnSZ.Properties.Resources.hatter;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.HpPotiLabel);
            this.Controls.Add(this.ManaPotiLabel);
            this.Controls.Add(this.lvlLabel);
            this.Controls.Add(this.PL);
            this.Controls.Add(this.totemPBox);
            this.Controls.Add(this.chestPBox);
            this.Controls.Add(this.AjtoLe);
            this.Controls.Add(this.AjtoFel);
            this.Controls.Add(this.AjtoJobb);
            this.Controls.Add(this.AjtoBal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BorderFel);
            this.Controls.Add(this.BorderBal);
            this.Controls.Add(this.BorderLe);
            this.Controls.Add(this.BorderJobb);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.BorderLe.ResumeLayout(false);
            this.BorderLe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoLe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoFel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoJobb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totemPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AjtoBal;
        private System.Windows.Forms.PictureBox AjtoJobb;
        private System.Windows.Forms.PictureBox AjtoFel;
        private System.Windows.Forms.Panel BorderBal;
        private System.Windows.Forms.Panel BorderFel;
        private System.Windows.Forms.Panel BorderLe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel BorderJobb;
        private System.Windows.Forms.PictureBox AjtoLe;
        private System.Windows.Forms.PictureBox chestPBox;
        private System.Windows.Forms.PictureBox totemPBox;
        private System.Windows.Forms.PictureBox PL;
        private System.Windows.Forms.Label lvlLabel;
        private System.Windows.Forms.Label ManaPotiLabel;
        private System.Windows.Forms.Label HpPotiLabel;
        private System.Windows.Forms.Label Ebetu;
        private System.Windows.Forms.Label totemLb;
    }
}

