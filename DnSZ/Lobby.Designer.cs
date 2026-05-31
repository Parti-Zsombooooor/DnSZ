namespace DnSZ
{
    partial class Lobby
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
            this.button1 = new System.Windows.Forms.Button();
            this.TitlePBOX = new System.Windows.Forms.PictureBox();
            this.nametxtPBOX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nametxtPBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::DnSZ.Properties.Resources.Start;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(752, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 140);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitlePBOX
            // 
            this.TitlePBOX.Image = global::DnSZ.Properties.Resources.kepbarle;
            this.TitlePBOX.Location = new System.Drawing.Point(225, 12);
            this.TitlePBOX.Name = "TitlePBOX";
            this.TitlePBOX.Size = new System.Drawing.Size(625, 460);
            this.TitlePBOX.TabIndex = 2;
            this.TitlePBOX.TabStop = false;
            // 
            // nametxtPBOX
            // 
            this.nametxtPBOX.Location = new System.Drawing.Point(12, 624);
            this.nametxtPBOX.Name = "nametxtPBOX";
            this.nametxtPBOX.Size = new System.Drawing.Size(360, 24);
            this.nametxtPBOX.TabIndex = 3;
            this.nametxtPBOX.TabStop = false;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DnSZ.Properties.Resources.hatter;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.nametxtPBOX);
            this.Controls.Add(this.TitlePBOX);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Lobby";
            this.Text = "Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.TitlePBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nametxtPBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox TitlePBOX;
        private System.Windows.Forms.PictureBox nametxtPBOX;
    }
}