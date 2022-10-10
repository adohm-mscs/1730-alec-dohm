
namespace ex2b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntExit = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUSDTotal = new System.Windows.Forms.TextBox();
            this.txtUSDUK = new System.Windows.Forms.TextBox();
            this.txtUSDJapan = new System.Windows.Forms.TextBox();
            this.txtUSDGermany = new System.Windows.Forms.TextBox();
            this.txtUSDDenmark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRateUK = new System.Windows.Forms.TextBox();
            this.txtRateJapan = new System.Windows.Forms.TextBox();
            this.txtRateGermany = new System.Windows.Forms.TextBox();
            this.txtRateDenmark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmountUK = new System.Windows.Forms.TextBox();
            this.txtAmountJapan = new System.Windows.Forms.TextBox();
            this.txtAmountGermany = new System.Windows.Forms.TextBox();
            this.txtAmountDenmark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picUSA = new System.Windows.Forms.PictureBox();
            this.picUK = new System.Windows.Forms.PictureBox();
            this.picJapan = new System.Windows.Forms.PictureBox();
            this.picGermany = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJapan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGermany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(477, 359);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(133, 36);
            this.bntExit.TabIndex = 34;
            this.bntExit.Text = "E&xit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // bntReset
            // 
            this.bntReset.Location = new System.Drawing.Point(312, 359);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(133, 36);
            this.bntReset.TabIndex = 32;
            this.bntReset.Text = "&Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(41, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "$ U.S.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(878, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 51;
            this.label8.Text = "+";
            // 
            // txtUSDTotal
            // 
            this.txtUSDTotal.Location = new System.Drawing.Point(964, 294);
            this.txtUSDTotal.Name = "txtUSDTotal";
            this.txtUSDTotal.ReadOnly = true;
            this.txtUSDTotal.Size = new System.Drawing.Size(165, 22);
            this.txtUSDTotal.TabIndex = 52;
            this.txtUSDTotal.TabStop = false;
            this.txtUSDTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDUK
            // 
            this.txtUSDUK.Location = new System.Drawing.Point(650, 294);
            this.txtUSDUK.Name = "txtUSDUK";
            this.txtUSDUK.ReadOnly = true;
            this.txtUSDUK.Size = new System.Drawing.Size(165, 22);
            this.txtUSDUK.TabIndex = 50;
            this.txtUSDUK.TabStop = false;
            this.txtUSDUK.Text = "0.00";
            this.txtUSDUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDJapan
            // 
            this.txtUSDJapan.Location = new System.Drawing.Point(466, 294);
            this.txtUSDJapan.Name = "txtUSDJapan";
            this.txtUSDJapan.ReadOnly = true;
            this.txtUSDJapan.Size = new System.Drawing.Size(165, 22);
            this.txtUSDJapan.TabIndex = 49;
            this.txtUSDJapan.TabStop = false;
            this.txtUSDJapan.Text = "0.00";
            this.txtUSDJapan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDGermany
            // 
            this.txtUSDGermany.Location = new System.Drawing.Point(280, 294);
            this.txtUSDGermany.Name = "txtUSDGermany";
            this.txtUSDGermany.ReadOnly = true;
            this.txtUSDGermany.Size = new System.Drawing.Size(165, 22);
            this.txtUSDGermany.TabIndex = 48;
            this.txtUSDGermany.TabStop = false;
            this.txtUSDGermany.Text = "0.00";
            this.txtUSDGermany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDDenmark
            // 
            this.txtUSDDenmark.Location = new System.Drawing.Point(94, 294);
            this.txtUSDDenmark.Name = "txtUSDDenmark";
            this.txtUSDDenmark.ReadOnly = true;
            this.txtUSDDenmark.Size = new System.Drawing.Size(165, 22);
            this.txtUSDDenmark.TabIndex = 47;
            this.txtUSDDenmark.TabStop = false;
            this.txtUSDDenmark.Text = "0.00";
            this.txtUSDDenmark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Rate:";
            // 
            // txtRateUK
            // 
            this.txtRateUK.Location = new System.Drawing.Point(650, 266);
            this.txtRateUK.Name = "txtRateUK";
            this.txtRateUK.Size = new System.Drawing.Size(165, 22);
            this.txtRateUK.TabIndex = 38;
            this.txtRateUK.Text = "1.1513497";
            this.txtRateUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateUK.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateJapan
            // 
            this.txtRateJapan.Location = new System.Drawing.Point(466, 266);
            this.txtRateJapan.Name = "txtRateJapan";
            this.txtRateJapan.Size = new System.Drawing.Size(165, 22);
            this.txtRateJapan.TabIndex = 37;
            this.txtRateJapan.Text = "0.0071366308";
            this.txtRateJapan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateJapan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateGermany
            // 
            this.txtRateGermany.Location = new System.Drawing.Point(280, 266);
            this.txtRateGermany.Name = "txtRateGermany";
            this.txtRateGermany.Size = new System.Drawing.Size(165, 22);
            this.txtRateGermany.TabIndex = 36;
            this.txtRateGermany.Text = "0.99637475";
            this.txtRateGermany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateGermany.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateDenmark
            // 
            this.txtRateDenmark.Location = new System.Drawing.Point(94, 266);
            this.txtRateDenmark.Name = "txtRateDenmark";
            this.txtRateDenmark.Size = new System.Drawing.Size(165, 22);
            this.txtRateDenmark.TabIndex = 35;
            this.txtRateDenmark.Text = "0.13398653";
            this.txtRateDenmark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateDenmark.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Amount:";
            // 
            // txtAmountUK
            // 
            this.txtAmountUK.Location = new System.Drawing.Point(650, 238);
            this.txtAmountUK.Name = "txtAmountUK";
            this.txtAmountUK.Size = new System.Drawing.Size(165, 22);
            this.txtAmountUK.TabIndex = 31;
            this.txtAmountUK.Text = "0.00";
            this.txtAmountUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountUK.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountJapan
            // 
            this.txtAmountJapan.Location = new System.Drawing.Point(466, 238);
            this.txtAmountJapan.Name = "txtAmountJapan";
            this.txtAmountJapan.Size = new System.Drawing.Size(165, 22);
            this.txtAmountJapan.TabIndex = 29;
            this.txtAmountJapan.Text = "0.00";
            this.txtAmountJapan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountJapan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountGermany
            // 
            this.txtAmountGermany.Location = new System.Drawing.Point(280, 238);
            this.txtAmountGermany.Name = "txtAmountGermany";
            this.txtAmountGermany.Size = new System.Drawing.Size(165, 22);
            this.txtAmountGermany.TabIndex = 26;
            this.txtAmountGermany.Text = "0.00";
            this.txtAmountGermany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountGermany.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountDenmark
            // 
            this.txtAmountDenmark.Location = new System.Drawing.Point(94, 238);
            this.txtAmountDenmark.Name = "txtAmountDenmark";
            this.txtAmountDenmark.Size = new System.Drawing.Size(165, 22);
            this.txtAmountDenmark.TabIndex = 25;
            this.txtAmountDenmark.Text = "0.00";
            this.txtAmountDenmark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountDenmark.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1008, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "U.S. Dollar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Pound Sterling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Japanese Yen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Euro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Danish Krone";
            // 
            // picUSA
            // 
            this.picUSA.Image = ((System.Drawing.Image)(resources.GetObject("picUSA.Image")));
            this.picUSA.Location = new System.Drawing.Point(964, 47);
            this.picUSA.Name = "picUSA";
            this.picUSA.Size = new System.Drawing.Size(165, 156);
            this.picUSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUSA.TabIndex = 33;
            this.picUSA.TabStop = false;
            // 
            // picUK
            // 
            this.picUK.Image = ((System.Drawing.Image)(resources.GetObject("picUK.Image")));
            this.picUK.Location = new System.Drawing.Point(650, 47);
            this.picUK.Name = "picUK";
            this.picUK.Size = new System.Drawing.Size(165, 156);
            this.picUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUK.TabIndex = 30;
            this.picUK.TabStop = false;
            // 
            // picJapan
            // 
            this.picJapan.Image = ((System.Drawing.Image)(resources.GetObject("picJapan.Image")));
            this.picJapan.Location = new System.Drawing.Point(466, 47);
            this.picJapan.Name = "picJapan";
            this.picJapan.Size = new System.Drawing.Size(165, 156);
            this.picJapan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJapan.TabIndex = 28;
            this.picJapan.TabStop = false;
            // 
            // picGermany
            // 
            this.picGermany.Image = ((System.Drawing.Image)(resources.GetObject("picGermany.Image")));
            this.picGermany.Location = new System.Drawing.Point(280, 47);
            this.picGermany.Name = "picGermany";
            this.picGermany.Size = new System.Drawing.Size(165, 156);
            this.picGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGermany.TabIndex = 27;
            this.picGermany.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 525);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUSDTotal);
            this.Controls.Add(this.txtUSDUK);
            this.Controls.Add(this.txtUSDJapan);
            this.Controls.Add(this.txtUSDGermany);
            this.Controls.Add(this.txtUSDDenmark);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRateUK);
            this.Controls.Add(this.txtRateJapan);
            this.Controls.Add(this.txtRateGermany);
            this.Controls.Add(this.txtRateDenmark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmountUK);
            this.Controls.Add(this.txtAmountJapan);
            this.Controls.Add(this.txtAmountGermany);
            this.Controls.Add(this.txtAmountDenmark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picUSA);
            this.Controls.Add(this.picUK);
            this.Controls.Add(this.picJapan);
            this.Controls.Add(this.picGermany);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picUSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJapan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGermany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUSDTotal;
        private System.Windows.Forms.TextBox txtUSDUK;
        private System.Windows.Forms.TextBox txtUSDJapan;
        private System.Windows.Forms.TextBox txtUSDGermany;
        private System.Windows.Forms.TextBox txtUSDDenmark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRateUK;
        private System.Windows.Forms.TextBox txtRateJapan;
        private System.Windows.Forms.TextBox txtRateGermany;
        private System.Windows.Forms.TextBox txtRateDenmark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmountUK;
        private System.Windows.Forms.TextBox txtAmountJapan;
        private System.Windows.Forms.TextBox txtAmountGermany;
        private System.Windows.Forms.TextBox txtAmountDenmark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picUSA;
        private System.Windows.Forms.PictureBox picUK;
        private System.Windows.Forms.PictureBox picJapan;
        private System.Windows.Forms.PictureBox picGermany;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

