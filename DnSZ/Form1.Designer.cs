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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PL = new System.Windows.Forms.Panel();
            this.AjtoFel = new System.Windows.Forms.PictureBox();
            this.AjtoJobb = new System.Windows.Forms.PictureBox();
            this.AjtoBal = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BorderBal = new System.Windows.Forms.Panel();
            this.BorderJobb = new System.Windows.Forms.Panel();
            this.BorderFel = new System.Windows.Forms.Panel();
            this.BorderLe = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AjtoFel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoJobb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 173);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PL
            // 
            this.PL.BackgroundImage = global::DnSZ.Properties.Resources.AjtoPlaceHolder;
            this.PL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PL.Location = new System.Drawing.Point(493, 268);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(32, 32);
            this.PL.TabIndex = 6;
            // 
            // AjtoFel
            // 
            this.AjtoFel.Image = global::DnSZ.Properties.Resources.ajtoforog;
            this.AjtoFel.Location = new System.Drawing.Point(523, 47);
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
            // BorderBal
            // 
            this.BorderBal.BackColor = System.Drawing.Color.IndianRed;
            this.BorderBal.Location = new System.Drawing.Point(181, 27);
            this.BorderBal.Name = "BorderBal";
            this.BorderBal.Size = new System.Drawing.Size(131, 602);
            this.BorderBal.TabIndex = 7;
            // 
            // BorderJobb
            // 
            this.BorderJobb.BackColor = System.Drawing.Color.IndianRed;
            this.BorderJobb.Location = new System.Drawing.Point(817, 27);
            this.BorderJobb.Name = "BorderJobb";
            this.BorderJobb.Size = new System.Drawing.Size(131, 602);
            this.BorderJobb.TabIndex = 8;
            // 
            // BorderFel
            // 
            this.BorderFel.BackColor = System.Drawing.Color.IndianRed;
            this.BorderFel.Location = new System.Drawing.Point(179, 10);
            this.BorderFel.Name = "BorderFel";
            this.BorderFel.Size = new System.Drawing.Size(768, 66);
            this.BorderFel.TabIndex = 9;
            // 
            // BorderLe
            // 
            this.BorderLe.BackColor = System.Drawing.Color.IndianRed;
            this.BorderLe.Location = new System.Drawing.Point(166, 580);
            this.BorderLe.Name = "BorderLe";
            this.BorderLe.Size = new System.Drawing.Size(768, 56);
            this.BorderLe.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.PL);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AjtoFel);
            this.Controls.Add(this.AjtoJobb);
            this.Controls.Add(this.AjtoBal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BorderLe);
            this.Controls.Add(this.BorderFel);
            this.Controls.Add(this.BorderJobb);
            this.Controls.Add(this.BorderBal);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AjtoFel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoJobb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjtoBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AjtoBal;
        private System.Windows.Forms.PictureBox AjtoJobb;
        private System.Windows.Forms.PictureBox AjtoFel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PL;
        private System.Windows.Forms.Panel BorderBal;
        private System.Windows.Forms.Panel BorderJobb;
        private System.Windows.Forms.Panel BorderFel;
        private System.Windows.Forms.Panel BorderLe;
        private System.Windows.Forms.Timer timer1;
    }
}

