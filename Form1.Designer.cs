namespace BudgetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ValHusleje = new TextBox();
            lblFællesUdgifter = new Label();
            ValInternet = new TextBox();
            lblHusleje = new Label();
            lblInternet = new Label();
            ValFællesUdgift1 = new TextBox();
            lblDelFællesUdgifter = new Label();
            ValDelFælles = new TextBox();
            NameFællesUdgift1 = new TextBox();
            lblColon1 = new Label();
            lblTotalFællesUdgifter = new Label();
            ValTotalFælles = new Label();
            lblFællesPrPerson = new Label();
            ValFællesPrPerson = new Label();
            lblMineUdgifter = new Label();
            lblMineFælles = new Label();
            ValMineFælles = new Label();
            lblForsikringer = new Label();
            ValForsikringer = new TextBox();
            lblAbonnementer = new Label();
            ValAbonnementer = new TextBox();
            lblBenzin = new Label();
            ValBenzin = new TextBox();
            lblLøn = new Label();
            ValLøn = new TextBox();
            lblOpsparing = new Label();
            ValOpsparing = new TextBox();
            ValAntalUger = new TextBox();
            lblAntalUger = new Label();
            lblMadbudget = new Label();
            ValMadbudget = new TextBox();
            lblUgentligtMadbudget = new Label();
            ValUgentligtMadbudget = new Label();
            llblBuffer = new Label();
            ValBuffer = new Label();
            NameEkstraUdgift1 = new TextBox();
            ValEkstraUdgift1 = new TextBox();
            OtherColonlbl = new Label();
            lblEkstraFælles = new Label();
            NameFællesUdgift2 = new TextBox();
            lblColon2 = new Label();
            ValFællesUdgift2 = new TextBox();
            lblEkstraUdgifter = new Label();
            NameEkstraUdgift2 = new TextBox();
            label9 = new Label();
            ValEkstraUdgift2 = new TextBox();
            SuspendLayout();
            // 
            // ValHusleje
            // 
            ValHusleje.Location = new Point(177, 36);
            ValHusleje.Name = "ValHusleje";
            ValHusleje.Size = new Size(100, 23);
            ValHusleje.TabIndex = 0;
            ValHusleje.TextChanged += textBox1_TextChanged;
            // 
            // lblFællesUdgifter
            // 
            lblFællesUdgifter.AutoSize = true;
            lblFællesUdgifter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFællesUdgifter.Location = new Point(58, 9);
            lblFællesUdgifter.Name = "lblFællesUdgifter";
            lblFællesUdgifter.Size = new Size(95, 15);
            lblFællesUdgifter.TabIndex = 1;
            lblFællesUdgifter.Text = "Fælles Udgifter:";
            // 
            // ValInternet
            // 
            ValInternet.Location = new Point(177, 65);
            ValInternet.Name = "ValInternet";
            ValInternet.Size = new Size(100, 23);
            ValInternet.TabIndex = 2;
            ValInternet.TextChanged += ValInternet_TextChanged;
            // 
            // lblHusleje
            // 
            lblHusleje.AutoSize = true;
            lblHusleje.Location = new Point(58, 39);
            lblHusleje.Name = "lblHusleje";
            lblHusleje.Size = new Size(49, 15);
            lblHusleje.TabIndex = 3;
            lblHusleje.Text = "Husleje:";
            lblHusleje.Click += label2_Click;
            // 
            // lblInternet
            // 
            lblInternet.AutoSize = true;
            lblInternet.Location = new Point(58, 68);
            lblInternet.Name = "lblInternet";
            lblInternet.Size = new Size(51, 15);
            lblInternet.TabIndex = 4;
            lblInternet.Text = "Internet:";
            // 
            // ValFællesUdgift1
            // 
            ValFællesUdgift1.Location = new Point(177, 123);
            ValFællesUdgift1.Name = "ValFællesUdgift1";
            ValFællesUdgift1.Size = new Size(100, 23);
            ValFællesUdgift1.TabIndex = 6;
            ValFællesUdgift1.TextChanged += ValFællesUdgift1_TextChanged;
            // 
            // lblDelFællesUdgifter
            // 
            lblDelFællesUdgifter.AutoSize = true;
            lblDelFællesUdgifter.Location = new Point(57, 195);
            lblDelFællesUdgifter.Name = "lblDelFællesUdgifter";
            lblDelFællesUdgifter.Size = new Size(112, 15);
            lblDelFællesUdgifter.TabIndex = 7;
            lblDelFællesUdgifter.Text = "Del fælles udgifter i:";
            // 
            // ValDelFælles
            // 
            ValDelFælles.Location = new Point(177, 192);
            ValDelFælles.Name = "ValDelFælles";
            ValDelFælles.Size = new Size(41, 23);
            ValDelFælles.TabIndex = 8;
            ValDelFælles.TextChanged += ValDelFælles_TextChanged;
            // 
            // NameFællesUdgift1
            // 
            NameFællesUdgift1.Location = new Point(58, 123);
            NameFællesUdgift1.Name = "NameFællesUdgift1";
            NameFællesUdgift1.Size = new Size(101, 23);
            NameFællesUdgift1.TabIndex = 9;
            NameFællesUdgift1.TextChanged += textBox1_TextChanged_1;
            // 
            // lblColon1
            // 
            lblColon1.AutoSize = true;
            lblColon1.Location = new Point(161, 126);
            lblColon1.Name = "lblColon1";
            lblColon1.Size = new Size(10, 15);
            lblColon1.TabIndex = 10;
            lblColon1.Text = ":";
            // 
            // lblTotalFællesUdgifter
            // 
            lblTotalFællesUdgifter.AutoSize = true;
            lblTotalFællesUdgifter.Location = new Point(52, 311);
            lblTotalFællesUdgifter.Name = "lblTotalFællesUdgifter";
            lblTotalFællesUdgifter.Size = new Size(117, 15);
            lblTotalFællesUdgifter.TabIndex = 12;
            lblTotalFællesUdgifter.Text = "Total Fælles Udgifter:";
            // 
            // ValTotalFælles
            // 
            ValTotalFælles.AutoSize = true;
            ValTotalFælles.Location = new Point(177, 311);
            ValTotalFælles.Name = "ValTotalFælles";
            ValTotalFælles.Size = new Size(13, 15);
            ValTotalFælles.TabIndex = 13;
            ValTotalFælles.Text = "0";
            // 
            // lblFællesPrPerson
            // 
            lblFællesPrPerson.AutoSize = true;
            lblFællesPrPerson.Location = new Point(28, 336);
            lblFællesPrPerson.Name = "lblFællesPrPerson";
            lblFællesPrPerson.Size = new Size(141, 15);
            lblFællesPrPerson.TabIndex = 14;
            lblFællesPrPerson.Text = "Fælles udgifter pr person:";
            lblFællesPrPerson.Click += label2_Click_1;
            // 
            // ValFællesPrPerson
            // 
            ValFællesPrPerson.AutoSize = true;
            ValFællesPrPerson.Location = new Point(177, 336);
            ValFællesPrPerson.Name = "ValFællesPrPerson";
            ValFællesPrPerson.Size = new Size(13, 15);
            ValFællesPrPerson.TabIndex = 15;
            ValFællesPrPerson.Text = "0";
            // 
            // lblMineUdgifter
            // 
            lblMineUdgifter.AutoSize = true;
            lblMineUdgifter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMineUdgifter.Location = new Point(386, 9);
            lblMineUdgifter.Name = "lblMineUdgifter";
            lblMineUdgifter.Size = new Size(89, 15);
            lblMineUdgifter.TabIndex = 16;
            lblMineUdgifter.Text = "Mine Udgifter:";
            // 
            // lblMineFælles
            // 
            lblMineFælles.AutoSize = true;
            lblMineFælles.Location = new Point(370, 68);
            lblMineFælles.Name = "lblMineFælles";
            lblMineFælles.Size = new Size(136, 15);
            lblMineFælles.TabIndex = 17;
            lblMineFælles.Text = "Andel af Fælles Udgifter:";
            // 
            // ValMineFælles
            // 
            ValMineFælles.AutoSize = true;
            ValMineFælles.Location = new Point(512, 68);
            ValMineFælles.Name = "ValMineFælles";
            ValMineFælles.Size = new Size(13, 15);
            ValMineFælles.TabIndex = 18;
            ValMineFælles.Text = "0";
            // 
            // lblForsikringer
            // 
            lblForsikringer.AutoSize = true;
            lblForsikringer.Location = new Point(386, 97);
            lblForsikringer.Name = "lblForsikringer";
            lblForsikringer.Size = new Size(72, 15);
            lblForsikringer.TabIndex = 19;
            lblForsikringer.Text = "Forsikringer:";
            // 
            // ValForsikringer
            // 
            ValForsikringer.Location = new Point(512, 94);
            ValForsikringer.Name = "ValForsikringer";
            ValForsikringer.Size = new Size(100, 23);
            ValForsikringer.TabIndex = 20;
            ValForsikringer.TextChanged += ValForsikringer_TextChanged;
            // 
            // lblAbonnementer
            // 
            lblAbonnementer.AutoSize = true;
            lblAbonnementer.Location = new Point(386, 126);
            lblAbonnementer.Name = "lblAbonnementer";
            lblAbonnementer.Size = new Size(90, 15);
            lblAbonnementer.TabIndex = 21;
            lblAbonnementer.Text = "Abonnementer:";
            // 
            // ValAbonnementer
            // 
            ValAbonnementer.Location = new Point(512, 123);
            ValAbonnementer.Name = "ValAbonnementer";
            ValAbonnementer.Size = new Size(100, 23);
            ValAbonnementer.TabIndex = 22;
            ValAbonnementer.TextChanged += ValAbonnementer_TextChanged;
            // 
            // lblBenzin
            // 
            lblBenzin.AutoSize = true;
            lblBenzin.Location = new Point(386, 155);
            lblBenzin.Name = "lblBenzin";
            lblBenzin.Size = new Size(45, 15);
            lblBenzin.TabIndex = 23;
            lblBenzin.Text = "Benzin:";
            // 
            // ValBenzin
            // 
            ValBenzin.Location = new Point(512, 152);
            ValBenzin.Name = "ValBenzin";
            ValBenzin.Size = new Size(100, 23);
            ValBenzin.TabIndex = 24;
            ValBenzin.TextChanged += ValBenzin_TextChanged;
            // 
            // lblLøn
            // 
            lblLøn.AutoSize = true;
            lblLøn.Location = new Point(386, 39);
            lblLøn.Name = "lblLøn";
            lblLøn.Size = new Size(30, 15);
            lblLøn.TabIndex = 25;
            lblLøn.Text = "Løn:";
            // 
            // ValLøn
            // 
            ValLøn.Location = new Point(512, 36);
            ValLøn.Name = "ValLøn";
            ValLøn.Size = new Size(100, 23);
            ValLøn.TabIndex = 26;
            ValLøn.TextChanged += ValLøn_TextChanged;
            // 
            // lblOpsparing
            // 
            lblOpsparing.AutoSize = true;
            lblOpsparing.Location = new Point(386, 184);
            lblOpsparing.Name = "lblOpsparing";
            lblOpsparing.Size = new Size(65, 15);
            lblOpsparing.TabIndex = 27;
            lblOpsparing.Text = "Opsparing:";
            // 
            // ValOpsparing
            // 
            ValOpsparing.Location = new Point(512, 181);
            ValOpsparing.Name = "ValOpsparing";
            ValOpsparing.Size = new Size(100, 23);
            ValOpsparing.TabIndex = 28;
            ValOpsparing.TextChanged += OpsparingVal_TextChanged;
            // 
            // ValAntalUger
            // 
            ValAntalUger.Location = new Point(512, 362);
            ValAntalUger.Name = "ValAntalUger";
            ValAntalUger.Size = new Size(41, 23);
            ValAntalUger.TabIndex = 29;
            ValAntalUger.TextChanged += ValAntalUger_TextChanged;
            // 
            // lblAntalUger
            // 
            lblAntalUger.AutoSize = true;
            lblAntalUger.Location = new Point(370, 365);
            lblAntalUger.Name = "lblAntalUger";
            lblAntalUger.Size = new Size(124, 15);
            lblAntalUger.TabIndex = 30;
            lblAntalUger.Text = "Antal uger i måneden:";
            // 
            // lblMadbudget
            // 
            lblMadbudget.AutoSize = true;
            lblMadbudget.Location = new Point(386, 336);
            lblMadbudget.Name = "lblMadbudget";
            lblMadbudget.Size = new Size(72, 15);
            lblMadbudget.TabIndex = 31;
            lblMadbudget.Text = "Madbudget:";
            // 
            // ValMadbudget
            // 
            ValMadbudget.Location = new Point(512, 333);
            ValMadbudget.Name = "ValMadbudget";
            ValMadbudget.Size = new Size(100, 23);
            ValMadbudget.TabIndex = 32;
            ValMadbudget.TextChanged += ValMadbudget_TextChanged;
            // 
            // lblUgentligtMadbudget
            // 
            lblUgentligtMadbudget.AutoSize = true;
            lblUgentligtMadbudget.Location = new Point(370, 405);
            lblUgentligtMadbudget.Name = "lblUgentligtMadbudget";
            lblUgentligtMadbudget.Size = new Size(124, 15);
            lblUgentligtMadbudget.TabIndex = 33;
            lblUgentligtMadbudget.Text = "Ugentligt Madbudget:";
            // 
            // ValUgentligtMadbudget
            // 
            ValUgentligtMadbudget.AutoSize = true;
            ValUgentligtMadbudget.Location = new Point(512, 405);
            ValUgentligtMadbudget.Name = "ValUgentligtMadbudget";
            ValUgentligtMadbudget.Size = new Size(13, 15);
            ValUgentligtMadbudget.TabIndex = 34;
            ValUgentligtMadbudget.Text = "0";
            // 
            // llblBuffer
            // 
            llblBuffer.AutoSize = true;
            llblBuffer.Location = new Point(386, 447);
            llblBuffer.Name = "llblBuffer";
            llblBuffer.Size = new Size(42, 15);
            llblBuffer.TabIndex = 35;
            llblBuffer.Text = "Buffer:";
            // 
            // ValBuffer
            // 
            ValBuffer.AutoSize = true;
            ValBuffer.Location = new Point(512, 447);
            ValBuffer.Name = "ValBuffer";
            ValBuffer.Size = new Size(13, 15);
            ValBuffer.TabIndex = 36;
            ValBuffer.Text = "0";
            // 
            // NameEkstraUdgift1
            // 
            NameEkstraUdgift1.Location = new Point(386, 239);
            NameEkstraUdgift1.Name = "NameEkstraUdgift1";
            NameEkstraUdgift1.Size = new Size(100, 23);
            NameEkstraUdgift1.TabIndex = 37;
            // 
            // ValEkstraUdgift1
            // 
            ValEkstraUdgift1.Location = new Point(512, 239);
            ValEkstraUdgift1.Name = "ValEkstraUdgift1";
            ValEkstraUdgift1.Size = new Size(100, 23);
            ValEkstraUdgift1.TabIndex = 38;
            ValEkstraUdgift1.TextChanged += ValEkstraUdgift1_TextChanged;
            // 
            // OtherColonlbl
            // 
            OtherColonlbl.AutoSize = true;
            OtherColonlbl.Location = new Point(496, 242);
            OtherColonlbl.Name = "OtherColonlbl";
            OtherColonlbl.Size = new Size(10, 15);
            OtherColonlbl.TabIndex = 39;
            OtherColonlbl.Text = ":";
            // 
            // lblEkstraFælles
            // 
            lblEkstraFælles.AutoSize = true;
            lblEkstraFælles.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblEkstraFælles.Location = new Point(58, 97);
            lblEkstraFælles.Name = "lblEkstraFælles";
            lblEkstraFælles.Size = new Size(143, 15);
            lblEkstraFælles.TabIndex = 40;
            lblEkstraFælles.Text = "evt. ekstra fælles udgifter:";
            // 
            // NameFællesUdgift2
            // 
            NameFællesUdgift2.Location = new Point(59, 152);
            NameFællesUdgift2.Name = "NameFællesUdgift2";
            NameFællesUdgift2.Size = new Size(100, 23);
            NameFællesUdgift2.TabIndex = 41;
            // 
            // lblColon2
            // 
            lblColon2.AutoSize = true;
            lblColon2.Location = new Point(161, 155);
            lblColon2.Name = "lblColon2";
            lblColon2.Size = new Size(10, 15);
            lblColon2.TabIndex = 42;
            lblColon2.Text = ":";
            // 
            // ValFællesUdgift2
            // 
            ValFællesUdgift2.Location = new Point(177, 152);
            ValFællesUdgift2.Name = "ValFællesUdgift2";
            ValFællesUdgift2.Size = new Size(100, 23);
            ValFællesUdgift2.TabIndex = 43;
            ValFællesUdgift2.TextChanged += ValFællesUdgift2_TextChanged;
            // 
            // lblEkstraUdgifter
            // 
            lblEkstraUdgifter.AutoSize = true;
            lblEkstraUdgifter.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblEkstraUdgifter.Location = new Point(386, 213);
            lblEkstraUdgifter.Name = "lblEkstraUdgifter";
            lblEkstraUdgifter.Size = new Size(109, 15);
            lblEkstraUdgifter.TabIndex = 44;
            lblEkstraUdgifter.Text = "evt. ekstra udgifter:";
            // 
            // NameEkstraUdgift2
            // 
            NameEkstraUdgift2.Location = new Point(386, 268);
            NameEkstraUdgift2.Name = "NameEkstraUdgift2";
            NameEkstraUdgift2.Size = new Size(100, 23);
            NameEkstraUdgift2.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(496, 271);
            label9.Name = "label9";
            label9.Size = new Size(10, 15);
            label9.TabIndex = 46;
            label9.Text = ":";
            // 
            // ValEkstraUdgift2
            // 
            ValEkstraUdgift2.Location = new Point(512, 268);
            ValEkstraUdgift2.Name = "ValEkstraUdgift2";
            ValEkstraUdgift2.Size = new Size(100, 23);
            ValEkstraUdgift2.TabIndex = 47;
            ValEkstraUdgift2.TextChanged += ValEkstraUdgift2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 551);
            Controls.Add(ValEkstraUdgift2);
            Controls.Add(label9);
            Controls.Add(NameEkstraUdgift2);
            Controls.Add(lblEkstraUdgifter);
            Controls.Add(ValFællesUdgift2);
            Controls.Add(lblColon2);
            Controls.Add(NameFællesUdgift2);
            Controls.Add(lblEkstraFælles);
            Controls.Add(OtherColonlbl);
            Controls.Add(ValEkstraUdgift1);
            Controls.Add(NameEkstraUdgift1);
            Controls.Add(ValBuffer);
            Controls.Add(llblBuffer);
            Controls.Add(ValUgentligtMadbudget);
            Controls.Add(lblUgentligtMadbudget);
            Controls.Add(ValMadbudget);
            Controls.Add(lblMadbudget);
            Controls.Add(lblAntalUger);
            Controls.Add(ValAntalUger);
            Controls.Add(ValOpsparing);
            Controls.Add(lblOpsparing);
            Controls.Add(ValLøn);
            Controls.Add(lblLøn);
            Controls.Add(ValBenzin);
            Controls.Add(lblBenzin);
            Controls.Add(ValAbonnementer);
            Controls.Add(lblAbonnementer);
            Controls.Add(ValForsikringer);
            Controls.Add(lblForsikringer);
            Controls.Add(ValMineFælles);
            Controls.Add(lblMineFælles);
            Controls.Add(lblMineUdgifter);
            Controls.Add(ValFællesPrPerson);
            Controls.Add(lblFællesPrPerson);
            Controls.Add(ValTotalFælles);
            Controls.Add(lblTotalFællesUdgifter);
            Controls.Add(lblColon1);
            Controls.Add(NameFællesUdgift1);
            Controls.Add(ValDelFælles);
            Controls.Add(lblDelFællesUdgifter);
            Controls.Add(ValFællesUdgift1);
            Controls.Add(lblInternet);
            Controls.Add(lblHusleje);
            Controls.Add(ValInternet);
            Controls.Add(lblFællesUdgifter);
            Controls.Add(ValHusleje);
            Name = "Form1";
            Text = "Budget";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ValHusleje;
        private Label lblFællesUdgifter;
        private TextBox ValInternet;
        private Label lblHusleje;
        private Label lblInternet;
        private TextBox ValFællesUdgift1;
        private Label lblDelFællesUdgifter;
        private TextBox ValDelFælles;
        private TextBox NameFællesUdgift1;
        private Label lblColon1;
        private Label lblTotalFællesUdgifter;
        private Label ValTotalFælles;
        private Label lblFællesPrPerson;
        private Label ValFællesPrPerson;
        private Label lblMineUdgifter;
        private Label lblMineFælles;
        private Label ValMineFælles;
        private Label lblForsikringer;
        private TextBox ValForsikringer;
        private Label lblAbonnementer;
        private TextBox ValAbonnementer;
        private Label lblBenzin;
        private TextBox ValBenzin;
        private Label lblLøn;
        private TextBox ValLøn;
        private Label lblOpsparing;
        private TextBox ValOpsparing;
        private TextBox ValAntalUger;
        private Label lblAntalUger;
        private Label lblMadbudget;
        private TextBox ValMadbudget;
        private Label lblUgentligtMadbudget;
        private Label ValUgentligtMadbudget;
        private Label llblBuffer;
        private Label ValBuffer;
        private TextBox NameEkstraUdgift1;
        private TextBox ValEkstraUdgift1;
        private Label OtherColonlbl;
        private Label lblEkstraFælles;
        private TextBox NameFællesUdgift2;
        private Label lblColon2;
        private TextBox ValFællesUdgift2;
        private Label lblEkstraUdgifter;
        private TextBox NameEkstraUdgift2;
        private Label label9;
        private TextBox ValEkstraUdgift2;
    }
}
