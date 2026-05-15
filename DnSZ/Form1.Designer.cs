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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pBBal = new System.Windows.Forms.PictureBox();
            this.pBMap = new System.Windows.Forms.PictureBox();
            this.pBJobb = new System.Windows.Forms.PictureBox();
            this.pBFel = new System.Windows.Forms.PictureBox();
            this.pBLe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJobb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLe)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 160);
            this.listBox1.TabIndex = 0;
            // 
            // pBBal
            // 
            this.pBBal.Image = global::DnSZ.Properties.Resources.AjtoPlaceHolder;
            this.pBBal.Location = new System.Drawing.Point(271, 264);
            this.pBBal.Name = "pBBal";
            this.pBBal.Size = new System.Drawing.Size(39, 103);
            this.pBBal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBal.TabIndex = 2;
            this.pBBal.TabStop = false;
            // 
            // pBMap
            // 
            this.pBMap.Location = new System.Drawing.Point(292, 39);
            this.pBMap.Name = "pBMap";
            this.pBMap.Size = new System.Drawing.Size(570, 570);
            this.pBMap.TabIndex = 1;
            this.pBMap.TabStop = false;
            // 
            // pBJobb
            // 
            this.pBJobb.Image = global::DnSZ.Properties.Resources.AjtoPlaceHolder;
            this.pBJobb.Location = new System.Drawing.Point(843, 264);
            this.pBJobb.Name = "pBJobb";
            this.pBJobb.Size = new System.Drawing.Size(39, 103);
            this.pBJobb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBJobb.TabIndex = 3;
            this.pBJobb.TabStop = false;
            // 
            // pBFel
            // 
            this.pBFel.Image = global::DnSZ.Properties.Resources.AjtoPlaceHolder;
            this.pBFel.Location = new System.Drawing.Point(519, 26);
            this.pBFel.Name = "pBFel";
            this.pBFel.Size = new System.Drawing.Size(103, 39);
            this.pBFel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBFel.TabIndex = 4;
            this.pBFel.TabStop = false;
            // 
            // pBLe
            // 
            this.pBLe.Image = global::DnSZ.Properties.Resources.AjtoPlaceHolder;
            this.pBLe.Location = new System.Drawing.Point(519, 591);
            this.pBLe.Name = "pBLe";
            this.pBLe.Size = new System.Drawing.Size(103, 39);
            this.pBLe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLe.TabIndex = 5;
            this.pBLe.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pBLe);
            this.Controls.Add(this.pBFel);
            this.Controls.Add(this.pBJobb);
            this.Controls.Add(this.pBBal);
            this.Controls.Add(this.pBMap);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pBBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBJobb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pBMap;
        private System.Windows.Forms.PictureBox pBBal;
        private System.Windows.Forms.PictureBox pBJobb;
        private System.Windows.Forms.PictureBox pBFel;
        private System.Windows.Forms.PictureBox pBLe;
    }
}

