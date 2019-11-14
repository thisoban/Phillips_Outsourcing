namespace Phillips
{
    partial class WijzigGebruikControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IdTb = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            VoorNaamTb = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            AchterNaamTb = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            LengteTb = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            InsulineTb = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            CountryTb = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            PostCodeTb = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            TelTb = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            StadTb = new System.Windows.Forms.TextBox();
            AdresNrTb = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            WijzigenBt = new System.Windows.Forms.Button();
            PfPb = new System.Windows.Forms.PictureBox();
            GeslachtCb = new System.Windows.Forms.ComboBox();
            uploadBt = new System.Windows.Forms.Button();
            AdresTb = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            EmailTb = new System.Windows.Forms.TextBox();
            label123 = new System.Windows.Forms.Label();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            GewichtTb = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(PfPb)).BeginInit();
            SuspendLayout();
            // 
            // IdTb
            // 
            IdTb.BackColor = System.Drawing.SystemColors.WindowFrame;
            IdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            IdTb.Location = new System.Drawing.Point(113, 64);
            IdTb.Multiline = true;
            IdTb.Name = "IdTb";
            IdTb.Size = new System.Drawing.Size(275, 20);
            IdTb.TabIndex = 3;
            IdTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(OnlyNumbers);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(79, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(21, 13);
            label1.TabIndex = 2;
            label1.Text = "ID ";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VoorNaamTb
            // 
            VoorNaamTb.BackColor = System.Drawing.SystemColors.WindowFrame;
            VoorNaamTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            VoorNaamTb.Location = new System.Drawing.Point(113, 90);
            VoorNaamTb.Multiline = true;
            VoorNaamTb.Name = "VoorNaamTb";
            VoorNaamTb.Size = new System.Drawing.Size(275, 20);
            VoorNaamTb.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(48, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 4;
            label2.Text = "Voornaam";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AchterNaamTb
            // 
            AchterNaamTb.BackColor = System.Drawing.SystemColors.WindowFrame;
            AchterNaamTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            AchterNaamTb.Location = new System.Drawing.Point(113, 116);
            AchterNaamTb.Multiline = true;
            AchterNaamTb.Name = "AchterNaamTb";
            AchterNaamTb.Size = new System.Drawing.Size(275, 20);
            AchterNaamTb.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(43, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 13);
            label3.TabIndex = 6;
            label3.Text = "Achternaam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(54, 145);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 13);
            label4.TabIndex = 8;
            label4.Text = "Geslacht";
            // 
            // LengteTb
            // 
            LengteTb.Location = new System.Drawing.Point(113, 168);
            LengteTb.Multiline = true;
            LengteTb.Name = "LengteTb";
            LengteTb.Size = new System.Drawing.Size(275, 20);
            LengteTb.TabIndex = 11;
            LengteTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(OnlyNumbers);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(63, 171);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 13);
            label5.TabIndex = 10;
            label5.Text = "Lengte";
            // 
            // InsulineTb
            // 
            InsulineTb.Location = new System.Drawing.Point(113, 194);
            InsulineTb.Multiline = true;
            InsulineTb.Name = "InsulineTb";
            InsulineTb.Size = new System.Drawing.Size(275, 20);
            InsulineTb.TabIndex = 13;
            InsulineTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(OnlyNumbers);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 197);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 13);
            label6.TabIndex = 12;
            label6.Text = "Insuline Sense";
            // 
            // CountryTb
            // 
            CountryTb.Location = new System.Drawing.Point(113, 297);
            CountryTb.Multiline = true;
            CountryTb.Name = "CountryTb";
            CountryTb.Size = new System.Drawing.Size(275, 20);
            CountryTb.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(69, 300);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(43, 13);
            label7.TabIndex = 14;
            label7.Text = "Country";
            // 
            // PostCodeTb
            // 
            PostCodeTb.Location = new System.Drawing.Point(113, 323);
            PostCodeTb.Multiline = true;
            PostCodeTb.Name = "PostCodeTb";
            PostCodeTb.Size = new System.Drawing.Size(275, 20);
            PostCodeTb.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(51, 326);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(52, 13);
            label8.TabIndex = 16;
            label8.Text = "Postcode";
            // 
            // TelTb
            // 
            TelTb.Location = new System.Drawing.Point(113, 349);
            TelTb.Multiline = true;
            TelTb.Name = "TelTb";
            TelTb.Size = new System.Drawing.Size(275, 20);
            TelTb.TabIndex = 18;
            TelTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(OnlyNumbers);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(61, 352);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(39, 13);
            label9.TabIndex = 19;
            label9.Text = "Tel. Nr";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(432, 352);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(29, 13);
            label10.TabIndex = 23;
            label10.Text = "Stad";
            // 
            // StadTb
            // 
            StadTb.Location = new System.Drawing.Point(478, 349);
            StadTb.Multiline = true;
            StadTb.Name = "StadTb";
            StadTb.Size = new System.Drawing.Size(254, 20);
            StadTb.TabIndex = 22;
            // 
            // AdresNrTb
            // 
            AdresNrTb.Location = new System.Drawing.Point(478, 323);
            AdresNrTb.Multiline = true;
            AdresNrTb.Name = "AdresNrTb";
            AdresNrTb.Size = new System.Drawing.Size(27, 20);
            AdresNrTb.TabIndex = 21;
            AdresNrTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(OnlyNumbers);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(440, 326);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(21, 13);
            label11.TabIndex = 20;
            label11.Text = "Nr.";
            // 
            // WijzigenBt
            // 
            WijzigenBt.Location = new System.Drawing.Point(657, 396);
            WijzigenBt.Name = "WijzigenBt";
            WijzigenBt.Size = new System.Drawing.Size(75, 23);
            WijzigenBt.TabIndex = 24;
            WijzigenBt.Text = "Wijzigen";
            WijzigenBt.UseVisualStyleBackColor = true;
            WijzigenBt.Click += new System.EventHandler(WijzigenBt_Click);
            // 
            // PfPb
            // 
            PfPb.Location = new System.Drawing.Point(519, 89);
            PfPb.Name = "PfPb";
            PfPb.Size = new System.Drawing.Size(150, 150);
            PfPb.TabIndex = 25;
            PfPb.TabStop = false;
            // 
            // GeslachtCb
            // 
            GeslachtCb.FormattingEnabled = true;
            GeslachtCb.Items.AddRange(new object[] {
            "Man/Vrouw",
            "Man",
            "Vrou"});
            GeslachtCb.Location = new System.Drawing.Point(113, 141);
            GeslachtCb.Name = "GeslachtCb";
            GeslachtCb.Size = new System.Drawing.Size(275, 21);
            GeslachtCb.TabIndex = 26;
            // 
            // uploadBt
            // 
            uploadBt.Location = new System.Drawing.Point(594, 248);
            uploadBt.Name = "uploadBt";
            uploadBt.Size = new System.Drawing.Size(75, 23);
            uploadBt.TabIndex = 27;
            uploadBt.Text = "Upload";
            uploadBt.UseVisualStyleBackColor = true;
            uploadBt.Click += new System.EventHandler(uploadBt_Click);
            // 
            // AdresTb
            // 
            AdresTb.Location = new System.Drawing.Point(113, 245);
            AdresTb.Multiline = true;
            AdresTb.Name = "AdresTb";
            AdresTb.Size = new System.Drawing.Size(275, 20);
            AdresTb.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(69, 248);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(34, 13);
            label12.TabIndex = 28;
            label12.Text = "Adres";
            // 
            // EmailTb
            // 
            EmailTb.Location = new System.Drawing.Point(113, 271);
            EmailTb.Multiline = true;
            EmailTb.Name = "EmailTb";
            EmailTb.Size = new System.Drawing.Size(275, 20);
            EmailTb.TabIndex = 31;
            // 
            // label123
            // 
            label123.AutoSize = true;
            label123.Location = new System.Drawing.Point(69, 277);
            label123.Name = "label123";
            label123.Size = new System.Drawing.Size(32, 13);
            label123.TabIndex = 30;
            label123.Text = "Email";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // GewichtTb
            // 
            GewichtTb.Location = new System.Drawing.Point(113, 219);
            GewichtTb.Multiline = true;
            GewichtTb.Name = "GewichtTb";
            GewichtTb.Size = new System.Drawing.Size(275, 20);
            GewichtTb.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(31, 222);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(46, 13);
            label13.TabIndex = 32;
            label13.Text = "Gewicht";
            // 
            // WijzigGebruikControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(GewichtTb);
            Controls.Add(label13);
            Controls.Add(EmailTb);
            Controls.Add(label123);
            Controls.Add(AdresTb);
            Controls.Add(label12);
            Controls.Add(uploadBt);
            Controls.Add(GeslachtCb);
            Controls.Add(PfPb);
            Controls.Add(WijzigenBt);
            Controls.Add(label10);
            Controls.Add(StadTb);
            Controls.Add(AdresNrTb);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(TelTb);
            Controls.Add(PostCodeTb);
            Controls.Add(label8);
            Controls.Add(CountryTb);
            Controls.Add(label7);
            Controls.Add(InsulineTb);
            Controls.Add(label6);
            Controls.Add(LengteTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AchterNaamTb);
            Controls.Add(label3);
            Controls.Add(VoorNaamTb);
            Controls.Add(label2);
            Controls.Add(IdTb);
            Controls.Add(label1);
            Name = "WijzigGebruikControl";
            Size = new System.Drawing.Size(753, 434);
            ((System.ComponentModel.ISupportInitialize)(PfPb)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.TextBox IdTb;
        private  System.Windows.Forms.Label label1;
        private static System.Windows.Forms.TextBox VoorNaamTb;
        private  System.Windows.Forms.Label label2;
        private static System.Windows.Forms.TextBox AchterNaamTb;
        private  System.Windows.Forms.Label label3;
        private  System.Windows.Forms.Label label4;
        private static System.Windows.Forms.TextBox LengteTb;
        private  System.Windows.Forms.Label label5;
        private static System.Windows.Forms.TextBox InsulineTb;
        private  System.Windows.Forms.Label label6;
        private static System.Windows.Forms.TextBox CountryTb;
        private  System.Windows.Forms.Label label7;
        private static System.Windows.Forms.TextBox PostCodeTb;
        private  System.Windows.Forms.Label label8;
        private static System.Windows.Forms.TextBox TelTb;
        private  System.Windows.Forms.Label label9;
        private  System.Windows.Forms.Label label10;
        private static System.Windows.Forms.TextBox StadTb;
        private static System.Windows.Forms.TextBox AdresNrTb;
        private  System.Windows.Forms.Label label11;
        private static System.Windows.Forms.Button WijzigenBt;
        private static System.Windows.Forms.PictureBox PfPb;
        private static System.Windows.Forms.ComboBox GeslachtCb;
        private static System.Windows.Forms.Button uploadBt;
        private static System.Windows.Forms.TextBox AdresTb;
        private  System.Windows.Forms.Label label12;
        private static System.Windows.Forms.TextBox EmailTb;
        private  System.Windows.Forms.Label label123;
        private  System.Windows.Forms.OpenFileDialog openFileDialog1;
        private static System.Windows.Forms.TextBox GewichtTb;
        private System.Windows.Forms.Label label13;
    }
}
