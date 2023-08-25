namespace PasoParolaOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFalse = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.BOS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(564, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Location = new System.Drawing.Point(564, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFalse);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblTrue);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(564, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(141, 81);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 29);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Başla";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(342, 117);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğru:";
            // 
            // lblTrue
            // 
            this.lblTrue.AutoSize = true;
            this.lblTrue.Location = new System.Drawing.Point(105, 30);
            this.lblTrue.Name = "lblTrue";
            this.lblTrue.Size = new System.Drawing.Size(26, 29);
            this.lblTrue.TabIndex = 1;
            this.lblTrue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yanlış:";
            // 
            // lblFalse
            // 
            this.lblFalse.AutoSize = true;
            this.lblFalse.Location = new System.Drawing.Point(307, 30);
            this.lblFalse.Name = "lblFalse";
            this.lblFalse.Size = new System.Drawing.Size(26, 29);
            this.lblFalse.TabIndex = 3;
            this.lblFalse.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(403, 318);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(278, 78);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(62, 48);
            this.buttonA.TabIndex = 4;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(346, 78);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(62, 48);
            this.buttonB.TabIndex = 5;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(414, 78);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(62, 48);
            this.buttonC.TabIndex = 6;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(482, 132);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(62, 48);
            this.buttonD.TabIndex = 7;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ç";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(482, 186);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(62, 48);
            this.buttonE.TabIndex = 9;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(482, 240);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(62, 48);
            this.buttonF.TabIndex = 10;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(482, 294);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(62, 48);
            this.buttonG.TabIndex = 11;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(482, 348);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(62, 48);
            this.buttonH.TabIndex = 12;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(482, 402);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(62, 48);
            this.buttonI.TabIndex = 13;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 48);
            this.button2.TabIndex = 14;
            this.button2.Text = "İ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(415, 456);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(62, 48);
            this.buttonJ.TabIndex = 15;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(347, 456);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(62, 48);
            this.buttonK.TabIndex = 16;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(279, 456);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(62, 48);
            this.buttonL.TabIndex = 17;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(211, 456);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(62, 48);
            this.buttonM.TabIndex = 18;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(143, 456);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(62, 48);
            this.buttonN.TabIndex = 19;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(74, 456);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(62, 48);
            this.buttonO.TabIndex = 20;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 48);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ö";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(6, 402);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(62, 48);
            this.buttonP.TabIndex = 22;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(6, 348);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(62, 48);
            this.buttonR.TabIndex = 23;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(6, 294);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(62, 48);
            this.buttonS.TabIndex = 24;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 48);
            this.button4.TabIndex = 25;
            this.button4.Text = "Ş";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(6, 186);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(62, 48);
            this.buttonT.TabIndex = 26;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(6, 132);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(62, 48);
            this.buttonU.TabIndex = 27;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 48);
            this.button5.TabIndex = 28;
            this.button5.Text = "Ü";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(74, 78);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(62, 48);
            this.buttonV.TabIndex = 29;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(142, 78);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(62, 48);
            this.buttonY.TabIndex = 30;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(210, 78);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(62, 48);
            this.buttonZ.TabIndex = 31;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            // 
            // BOS
            // 
            this.BOS.AutoSize = true;
            this.BOS.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOS.Location = new System.Drawing.Point(251, 9);
            this.BOS.Name = "BOS";
            this.BOS.Size = new System.Drawing.Size(444, 41);
            this.BOS.TabIndex = 32;
            this.BOS.Text = "PASOPAROLA OYUNU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(971, 542);
            this.Controls.Add(this.BOS);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.buttonJ);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFalse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTrue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Label BOS;
    }
}

