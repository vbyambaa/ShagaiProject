namespace ShagaiProject
{
    partial class Shagai
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.clickThisButton = new System.Windows.Forms.Button();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.countsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.White;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.welcomeLabel.Location = new System.Drawing.Point(107, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(575, 45);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Shagai Fortune Teller";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShagaiProject.Properties.Resources.camel;
            this.pictureBox1.Location = new System.Drawing.Point(48, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShagaiProject.Properties.Resources.goat;
            this.pictureBox2.Location = new System.Drawing.Point(224, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ShagaiProject.Properties.Resources.horse;
            this.pictureBox3.Location = new System.Drawing.Point(410, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ShagaiProject.Properties.Resources.sheep;
            this.pictureBox4.Location = new System.Drawing.Point(594, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(156, 118);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // clickThisButton
            // 
            this.clickThisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickThisButton.ForeColor = System.Drawing.Color.Olive;
            this.clickThisButton.Location = new System.Drawing.Point(195, 284);
            this.clickThisButton.Name = "clickThisButton";
            this.clickThisButton.Size = new System.Drawing.Size(370, 51);
            this.clickThisButton.TabIndex = 5;
            this.clickThisButton.Text = "Click This";
            this.clickThisButton.UseVisualStyleBackColor = true;
            this.clickThisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.BackColor = System.Drawing.Color.White;
            this.attemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attemptsLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.attemptsLabel.Location = new System.Drawing.Point(1, 447);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(147, 33);
            this.attemptsLabel.TabIndex = 6;
            this.attemptsLabel.Text = "Attempts";
            this.attemptsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attemptsLabel.Click += new System.EventHandler(this.attemptsLabel_Click);
            // 
            // countsLabel
            // 
            this.countsLabel.BackColor = System.Drawing.Color.White;
            this.countsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countsLabel.ForeColor = System.Drawing.Color.Blue;
            this.countsLabel.Location = new System.Drawing.Point(273, 447);
            this.countsLabel.Name = "countsLabel";
            this.countsLabel.Size = new System.Drawing.Size(518, 33);
            this.countsLabel.TabIndex = 7;
            this.countsLabel.Text = "Counter";
            this.countsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countsLabel.Click += new System.EventHandler(this.sideCounter_Click);
            // 
            // Shagai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(790, 479);
            this.Controls.Add(this.countsLabel);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.clickThisButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Shagai";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button clickThisButton;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Label countsLabel;
    }
}

