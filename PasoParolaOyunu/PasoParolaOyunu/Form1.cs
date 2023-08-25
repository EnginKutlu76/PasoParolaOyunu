using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasoParolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        int soruNo = 0, dogru = 0, yanlis = 0;

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString();
            if (soruNo == 1)
            {
                richTextBox1.Text = "Türkiyenin başkenti neresidir?";
                buttonA.BackColor = Color.Yellow;
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Misketin diğer yaygın adı";
                buttonB.BackColor = Color.Yellow;
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların Kutsal Günü";
                buttonC.BackColor = Color.Yellow;
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Ülkemizde en çok içilen içicek";
                button1.BackColor = Color.Yellow;
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Greenland hangi ülkeye bağlıdır?";
                buttonD.BackColor = Color.Yellow;
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Yılda 2 günde gece ve gündüzün eşit olması";
                buttonE.BackColor = Color.Yellow;
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Arabalarda genellikle 1 elde bir de ayakta bulunan durma sistemi";
                buttonF.BackColor = Color.Yellow;
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Türkiyenin en çok şampiyon olan takımı";
                buttonG.BackColor = Color.Yellow;
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "bir ülkeyi yöneten büyük soylu aile";
                buttonH.BackColor = Color.Yellow;
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Türkiyenin en çok ülkeyle sınırı olan ili";
                buttonI.BackColor = Color.Yellow;
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Büyük baş hayvan";
                button2.BackColor = Color.Yellow;
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Atariye atılan bozukluk";
                buttonJ.BackColor = Color.Yellow;
            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Ekimden sonra gelen ay";
                buttonK.BackColor = Color.Yellow;
            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Hollanda da en çok yetişen çiçek türü";
                buttonL.BackColor = Color.Yellow;
            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "Tantunisi ile meşhur ilimiz";
                buttonM.BackColor = Color.Yellow;
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "pozitif ya da negatif olmayan";
                buttonN.BackColor = Color.Yellow;
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Osmanlı İmparatorluğunun kurucusu";
                buttonO.BackColor = Color.Yellow;
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "kişisel hususi";
                button3.BackColor = Color.Yellow;
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "Asker";
                buttonP.BackColor = Color.Yellow;
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "15.Yüzyılda Avrupada ortaya çıkan yeniden doğuş akımı";
                buttonR.BackColor = Color.Yellow;
            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "yeni doğan bebeklerin besin kaynağı";
                buttonS.BackColor = Color.Yellow;
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Suriyenin başkenti";
                button4.BackColor = Color.Yellow;
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Çıkarılan ilk Türk elektrikli araba markası";
                buttonT.BackColor = Color.Yellow;
            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Dünyadaki eski kalıntıları sahiplenen ve koruyan kuruluş";
                buttonU.BackColor = Color.Yellow;
            }
            if (soruNo == 25)
            {
                richTextBox1.Text = "Yüksekokul";
                button5.BackColor = Color.Yellow;
            }
            if (soruNo == 26)
            {
                richTextBox1.Text = "Papanın bulunduğu ülke";
                buttonV.BackColor = Color.Yellow;
            }
            if (soruNo == 27)
            {
                richTextBox1.Text = "Kanun";
                buttonY.BackColor = Color.Yellow;
            }
            if (soruNo == 28)
            {
                richTextBox1.Text = "Siyah beyaz çizgili 4 ayaklı toynağı bulunan hayvan";
                buttonZ.BackColor = Color.Yellow;
            }



        }
          private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:
                        if (textBox1.Text == "ankara")
                        {
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonA.BackColor= Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        } break;
                    case 2:
                        if (textBox1.Text == "bilye")
                        {
                            buttonB.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                    break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "çay")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "danimarka")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ekinoks")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "fren")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "galatasaray")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "hanedan")
                        {
                            buttonH.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "ığdır")
                        {
                            buttonI.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "inek")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "jeton")
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "kasım")
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "lale")
                        {
                            buttonL.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "mersin")
                        {
                            buttonM.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "nötr")
                        {
                            buttonN.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "osman gazi")
                        {
                            buttonO.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "özel")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "piyade")
                        {
                            buttonP.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "rönesans")
                        {
                            buttonR.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "süt")
                        {
                            buttonS.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "şam")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "togg")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "unesco")
                        {
                            buttonU.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 25:
                        if (textBox1.Text == "üniversite")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 26:
                        if (textBox1.Text == "vatikan")
                        {
                            buttonV.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 27:
                        if (textBox1.Text == "yasa")
                        {
                            buttonY.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;
                    case 28:
                        if (textBox1.Text == "zebra")
                        {
                            buttonZ.BackColor = Color.Green;
                            dogru++;
                            lblTrue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            yanlis++;
                            lblFalse.Text = yanlis.ToString();
                        }
                        break;

                }
            }
        }
    }
}
