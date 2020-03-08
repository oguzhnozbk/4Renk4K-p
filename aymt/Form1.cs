using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace aymt
{
    public partial class Form1 : Form
    {
        int[,] Kupler = new int[4, 6];
        int[,] baglar = new int[4, 30];
        int[,] genelGraf = new int[4, 3];
        int[,] cozumGraflari = new int[2, 4];
        int[,] cozumGrafindakiRenklerinBagSayilari = new int[2, 4];
        int[,] Renk = new int[4, 4];
        int onay = 0;
        public Form1()
        {
            InitializeComponent();
            labelGenelGrafKırmızı_Kırmızı.Text = "";
            labelGenelGrafKırmızı_Mavi.Text = "";
            labelGenelGrafKırmızı_Sari.Text = "";
            labelGenelGrafKırmızı_Yesil.Text = "";
            labelGenelGrafMavi_Mavi.Text = "";
            labelGenelGrafMavi_Sari.Text = "";
            labelGenelGrafMavi_Yesil.Text = "";
            labelGenelGrafSari_Sari.Text = "";
            labelGenelGrafSari_Yesil.Text = "";
            labelGenelGrafYesil_Yesil.Text = "";
            label10.Text = ""; label11.Text = ""; label12.Text = ""; label13.Text = ""; label14.Text = ""; label15.Text = "";
            label16.Text = ""; label17.Text = ""; label18.Text = ""; label19.Text = ""; label2.Text = ""; label20.Text = "";
            label21.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = ""; label6.Text = ""; label7.Text = "";
            label8.Text = ""; label9.Text = "";
        }
        void ElileolusturulanKupleriForm1eAl()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Kupler[i, j] = KupOlustur.olstrKup[i, j];
                }
            }
        }
        void KupleriEkranaYazdir()
        {
            panel1.BackColor = Color.Black;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (Kupler[i,j]==0)
                    {
                        if (i==0)
                        {
                            if (j==0)
                            {
                                pBox00.BackColor = Color.Red;
                            }
                            if (j==1)
                            {
                                pBox01.BackColor = Color.Red;
                            }
                            if (j==2)
                            {
                                pBox02.BackColor = Color.Red;
                            }
                            if (j==3)
                            {
                                pBox03.BackColor = Color.Red;
                            }
                            if (j==4)
                            {
                                pBox04.BackColor = Color.Red;
                            }
                            if (j==5)
                            {
                                pBox05.BackColor = Color.Red;
                            }
                        }
                        if (i==1)
                        {
                            if (j==0)
                            {
                                pBox10.BackColor = Color.Red;
                            }
                            if (j==1)
                            {
                                pBox11.BackColor = Color.Red;
                            }
                            if (j==2)
                            {
                                pBox12.BackColor = Color.Red;
                            }
                            if (j==3)
                            {
                                pBox13.BackColor = Color.Red;
                            }
                            if (j==4)
                            {
                                pBox14.BackColor = Color.Red;
                            }
                            if (j==5)
                            {
                                pBox15.BackColor = Color.Red;
                            }
                        }
                        if (i==2)
                        {
                            if (j==0)
                            {
                                pBox20.BackColor = Color.Red;
                            }
                            if (j==1)
                            {
                                pBox21.BackColor = Color.Red;
                            }
                            if (j==2)
                            {
                                pBox22.BackColor = Color.Red;
                            }
                            if (j==3)
                            {
                                pBox23.BackColor = Color.Red;
                            }
                            if (j==4)
                            {
                                pBox24.BackColor = Color.Red;
                            }
                            if (j==5)
                            {
                                pBox25.BackColor = Color.Red;
                            }
                        }
                        if (i==3)
                        {
                            if (j==0)
                            {
                                pBox30.BackColor = Color.Red;
                            }
                            if (j==1)
                            {
                                pBox31.BackColor = Color.Red;
                            }
                            if (j==2)
                            {
                                pBox32.BackColor = Color.Red;
                            }
                            if (j==3)
                            {
                                pBox33.BackColor = Color.Red;
                            }
                            if (j==4)
                            {
                                pBox34.BackColor = Color.Red;
                            }
                            if (j==5)
                            {
                                pBox35.BackColor = Color.Red;
                            }
                        }
                    }
                    if (Kupler[i, j] == 1)
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                pBox00.BackColor = Color.Blue;
                            }
                            if (j == 1)
                            {
                                pBox01.BackColor = Color.Blue;
                            }
                            if (j == 2)
                            {
                                pBox02.BackColor = Color.Blue;
                            }
                            if (j == 3)
                            {
                                pBox03.BackColor = Color.Blue;
                            }
                            if (j == 4)
                            {
                                pBox04.BackColor = Color.Blue;
                            }
                            if (j == 5)
                            {
                                pBox05.BackColor = Color.Blue;
                            }
                        }
                        if (i == 1)
                        {
                            if (j == 0)
                            {
                                pBox10.BackColor = Color.Blue;
                            }
                            if (j == 1)
                            {
                                pBox11.BackColor = Color.Blue;
                            }
                            if (j == 2)
                            {
                                pBox12.BackColor = Color.Blue;
                            }
                            if (j == 3)
                            {
                                pBox13.BackColor = Color.Blue;
                            }
                            if (j == 4)
                            {
                                pBox14.BackColor = Color.Blue;
                            }
                            if (j == 5)
                            {
                                pBox15.BackColor = Color.Blue;
                            }
                        }
                        if (i == 2)
                        {
                            if (j == 0)
                            {
                                pBox20.BackColor = Color.Blue;
                            }
                            if (j == 1)
                            {
                                pBox21.BackColor = Color.Blue;
                            }
                            if (j == 2)
                            {
                                pBox22.BackColor = Color.Blue;
                            }
                            if (j == 3)
                            {
                                pBox23.BackColor = Color.Blue;
                            }
                            if (j == 4)
                            {
                                pBox24.BackColor = Color.Blue;
                            }
                            if (j == 5)
                            {
                                pBox25.BackColor = Color.Blue;
                            }
                        }
                        if (i == 3)
                        {
                            if (j == 0)
                            {
                                pBox30.BackColor = Color.Blue;
                            }
                            if (j == 1)
                            {
                                pBox31.BackColor = Color.Blue;
                            }
                            if (j == 2)
                            {
                                pBox32.BackColor = Color.Blue;
                            }
                            if (j == 3)
                            {
                                pBox33.BackColor = Color.Blue;
                            }
                            if (j == 4)
                            {
                                pBox34.BackColor = Color.Blue;
                            }
                            if (j == 5)
                            {
                                pBox35.BackColor = Color.Blue;
                            }
                        }
                    }
                    if (Kupler[i, j] == 2)
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                pBox00.BackColor = Color.Yellow;
                            }
                            if (j == 1)
                            {
                                pBox01.BackColor = Color.Yellow;
                            }
                            if (j == 2)
                            {
                                pBox02.BackColor = Color.Yellow;
                            }
                            if (j == 3)
                            {
                                pBox03.BackColor = Color.Yellow;
                            }
                            if (j == 4)
                            {
                                pBox04.BackColor = Color.Yellow;
                            }
                            if (j == 5)
                            {
                                pBox05.BackColor = Color.Yellow;
                            }
                        }
                        if (i == 1)
                        {
                            if (j == 0)
                            {
                                pBox10.BackColor = Color.Yellow;
                            }
                            if (j == 1)
                            {
                                pBox11.BackColor = Color.Yellow;
                            }
                            if (j == 2)
                            {
                                pBox12.BackColor = Color.Yellow;
                            }
                            if (j == 3)
                            {
                                pBox13.BackColor = Color.Yellow;
                            }
                            if (j == 4)
                            {
                                pBox14.BackColor = Color.Yellow;
                            }
                            if (j == 5)
                            {
                                pBox15.BackColor = Color.Yellow;
                            }
                        }
                        if (i == 2)
                        {
                            if (j == 0)
                            {
                                pBox20.BackColor = Color.Yellow;
                            }
                            if (j == 1)
                            {
                                pBox21.BackColor = Color.Yellow;
                            }
                            if (j == 2)
                            {
                                pBox22.BackColor = Color.Yellow;
                            }
                            if (j == 3)
                            {
                                pBox23.BackColor = Color.Yellow;
                            }
                            if (j == 4)
                            {
                                pBox24.BackColor = Color.Yellow;
                            }
                            if (j == 5)
                            {
                                pBox25.BackColor = Color.Yellow;
                            }
                        }
                        if (i == 3)
                        {
                            if (j == 0)
                            {
                                pBox30.BackColor = Color.Yellow;
                            }
                            if (j == 1)
                            {
                                pBox31.BackColor = Color.Yellow;
                            }
                            if (j == 2)
                            {
                                pBox32.BackColor = Color.Yellow;
                            }
                            if (j == 3)
                            {
                                pBox33.BackColor = Color.Yellow;
                            }
                            if (j == 4)
                            {
                                pBox34.BackColor = Color.Yellow;
                            }
                            if (j == 5)
                            {
                                pBox35.BackColor = Color.Yellow;
                            }
                        }
                    }
                    if (Kupler[i, j] == 3)
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                pBox00.BackColor = Color.ForestGreen;
                            }
                            if (j == 1)
                            {
                                pBox01.BackColor = Color.ForestGreen;
                            }
                            if (j == 2)
                            {
                                pBox02.BackColor = Color.ForestGreen;
                            }
                            if (j == 3)
                            {
                                pBox03.BackColor = Color.ForestGreen;
                            }
                            if (j == 4)
                            {
                                pBox04.BackColor = Color.ForestGreen;
                            }
                            if (j == 5)
                            {
                                pBox05.BackColor = Color.ForestGreen;
                            }
                        }
                        if (i == 1)
                        {
                            if (j == 0)
                            {
                                pBox10.BackColor = Color.ForestGreen;
                            }
                            if (j == 1)
                            {
                                pBox11.BackColor = Color.ForestGreen;
                            }
                            if (j == 2)
                            {
                                pBox12.BackColor = Color.ForestGreen;
                            }
                            if (j == 3)
                            {
                                pBox13.BackColor = Color.ForestGreen;
                            }
                            if (j == 4)
                            {
                                pBox14.BackColor = Color.ForestGreen;
                            }
                            if (j == 5)
                            {
                                pBox15.BackColor = Color.ForestGreen;
                            }
                        }
                        if (i == 2)
                        {
                            if (j == 0)
                            {
                                pBox20.BackColor = Color.ForestGreen;
                            }
                            if (j == 1)
                            {
                                pBox21.BackColor = Color.ForestGreen;
                            }
                            if (j == 2)
                            {
                                pBox22.BackColor = Color.ForestGreen;
                            }
                            if (j == 3)
                            {
                                pBox23.BackColor = Color.ForestGreen;
                            }
                            if (j == 4)
                            {
                                pBox24.BackColor = Color.ForestGreen;
                            }
                            if (j == 5)
                            {
                                pBox25.BackColor = Color.ForestGreen;
                            }
                        }
                        if (i == 3)
                        {
                            if (j == 0)
                            {
                                pBox30.BackColor = Color.ForestGreen;
                            }
                            if (j == 1)
                            {
                                pBox31.BackColor = Color.ForestGreen;
                            }
                            if (j == 2)
                            {
                                pBox32.BackColor = Color.ForestGreen;
                            }
                            if (j == 3)
                            {
                                pBox33.BackColor = Color.ForestGreen;
                            }
                            if (j == 4)
                            {
                                pBox34.BackColor = Color.ForestGreen;
                            }
                            if (j == 5)
                            {
                                pBox35.BackColor = Color.ForestGreen;
                            }
                        }
                    }
                }
            }
        }
        void baglanti()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    baglar[i, j] = 0;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (Kupler[i,0]==0 && Kupler[i,2]==0)
                {
                    baglar[i, 0] = 1; // ( i + 1 ). Küpün Kırmızı - Kırmızı arasında bağı var.
                }
                if ((Kupler[i,0]==0 && Kupler[i,2]==1)||(Kupler[i,0]==1 && Kupler[i,2]==0))
                {
                    baglar[i, 1] = 1; // ( i+ 1). Küpün Kırmızı- Mavi arasında bağı var. 
                }
                if ((Kupler[i, 0] == 0 && Kupler[i, 2] == 2) || (Kupler[i, 0] == 2 && Kupler[i, 2] == 0))
                {
                    baglar[i, 2] = 1;
                }
                if ((Kupler[i, 0] == 0 && Kupler[i, 2] == 3) || (Kupler[i, 0] == 3 && Kupler[i, 2] == 0))
                {
                    baglar[i, 3] = 1;
                }
                if (Kupler[i, 0] == 1 && Kupler[i, 2] == 1)
                {
                    baglar[i, 4] = 1;
                }
                if ((Kupler[i, 0] == 1 && Kupler[i, 2] == 2) || (Kupler[i, 0] == 2 && Kupler[i, 2] == 1))
                {
                    baglar[i, 5] = 1;
                }
                if ((Kupler[i, 0] == 1 && Kupler[i, 2] == 3) || (Kupler[i, 0] == 3 && Kupler[i, 2] == 1))
                {
                    baglar[i, 6] = 1;
                }
                if (Kupler[i, 0] == 2 && Kupler[i, 2] == 2)
                {
                    baglar[i, 7] = 1;
                }
                if ((Kupler[i, 0] == 2 && Kupler[i, 2] == 3) || (Kupler[i, 0] == 3 && Kupler[i, 2] == 2))
                {
                    baglar[i, 8] = 1;
                }
                if (Kupler[i, 0] == 3 && Kupler[i, 2] == 3)
                {
                    baglar[i, 9] = 1;
                }
                if (Kupler[i, 1] == 0 && Kupler[i, 3] == 0)
                {
                    baglar[i, 10] = 1; // ( i + 1 ). Küpün Kırmızı - Kırmızı arasında bağı var.
                }
                if ((Kupler[i, 1] == 0 && Kupler[i, 3] == 1) || (Kupler[i, 1] == 1 && Kupler[i, 3] == 0))
                {
                    baglar[i, 11] = 1; // ( i+ 1). Küpün Kırmızı- Mavi arasında bağı var. 
                }
                if ((Kupler[i, 1] == 0 && Kupler[i, 3] == 2) || (Kupler[i, 1] == 2 && Kupler[i, 3] == 0))
                {
                    baglar[i, 12] = 1;
                }
                if ((Kupler[i, 1] == 0 && Kupler[i, 3] == 3) || (Kupler[i, 1] == 3 && Kupler[i, 3] == 0))
                {
                    baglar[i, 13] = 1;
                }
                if (Kupler[i, 1] == 1 && Kupler[i, 3] == 1)
                {
                    baglar[i, 14] = 1;
                }
                if ((Kupler[i, 1] == 1 && Kupler[i, 3] == 2) || (Kupler[i, 1] == 2 && Kupler[i, 3] == 1))
                {
                    baglar[i, 15] = 1;
                }
                if ((Kupler[i, 1] == 1 && Kupler[i, 3] == 3) || (Kupler[i, 1] == 3 && Kupler[i, 3] == 1))
                {
                    baglar[i, 16] = 1;
                }
                if (Kupler[i, 1] == 2 && Kupler[i, 3] == 2)
                {
                    baglar[i, 17] = 1;
                }
                if ((Kupler[i, 1] == 2 && Kupler[i, 3] == 3) || (Kupler[i, 1] == 3 && Kupler[i, 3] == 2))
                {
                    baglar[i, 18] = 1;
                }
                if (Kupler[i, 1] == 3 && Kupler[i, 3] == 3)
                {
                    baglar[i, 19] = 1;
                }
                if (Kupler[i, 4] == 0 && Kupler[i, 5] == 0)
                {
                    baglar[i, 20] = 1; // ( i + 1 ). Küpün Kırmızı - Kırmızı arasında bağı var.
                }
                if ((Kupler[i, 4] == 0 && Kupler[i, 5] == 1) || (Kupler[i, 4] == 1 && Kupler[i, 5] == 0))
                {
                    baglar[i, 21] = 1; // ( i+ 1). Küpün Kırmızı- Mavi arasında bağı var. 
                }
                if ((Kupler[i, 4] == 0 && Kupler[i, 5] == 2) || (Kupler[i, 4] == 2 && Kupler[i, 5] == 0))
                {
                    baglar[i, 22] = 1;
                }
                if ((Kupler[i, 4] == 0 && Kupler[i, 5] == 3) || (Kupler[i, 4] == 3 && Kupler[i, 5] == 0))
                {
                    baglar[i, 23] = 1;
                }
                if (Kupler[i, 4] == 1 && Kupler[i, 5] == 1)
                {
                    baglar[i, 24] = 1;
                }
                if ((Kupler[i, 4] == 1 && Kupler[i, 5] == 2) || (Kupler[i, 4] == 2 && Kupler[i, 5] == 1))
                {
                    baglar[i, 25] = 1;
                }
                if ((Kupler[i, 4] == 1 && Kupler[i, 5] == 3) || (Kupler[i, 4] == 3 && Kupler[i, 5] == 1))
                {
                    baglar[i, 26] = 1;
                }
                if (Kupler[i, 4] == 2 && Kupler[i, 5] == 2)
                {
                    baglar[i, 27] = 1;
                }
                if ((Kupler[i, 4] == 2 && Kupler[i, 5] == 3) || (Kupler[i, 4] == 3 && Kupler[i, 5] == 2))
                {
                    baglar[i, 28] = 1;
                }
                if (Kupler[i, 4] == 3 && Kupler[i, 5] == 3)
                {
                    baglar[i, 29] = 1;
                }
            }
        }
        void genelGrafOlustur()
        {
            int q = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (baglar[i,j]==1)
                    {
                        genelGraf[i, q] = j;
                        q++;
                    }
                }
                q = 0;
            }
        }
        void GraflariOlustur()
        {
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                cozumGraflari[0, i] = genelGraf[i, r.Next(3)];
            }
            for (int j = 0; j < 4; j++)
            {
            grafaynı:
                cozumGraflari[1, j] = genelGraf[j, r.Next(3)];
            if (cozumGraflari[0, j] == cozumGraflari[1, j]) goto grafaynı;
            }
        }
        void RenklerinBagSayilari()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cozumGrafindakiRenklerinBagSayilari[i, j] = 0;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (cozumGraflari[i,j] == 0 || cozumGraflari[i,j] == 10 || cozumGraflari[i,j] == 20)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 0]++; cozumGrafindakiRenklerinBagSayilari[i, 0]++;
                    }
                    if (cozumGraflari[i,j] == 1 || cozumGraflari[i,j] == 11 || cozumGraflari[i,j] == 21)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 0]++; cozumGrafindakiRenklerinBagSayilari[i, 1]++;
                    }
                    if (cozumGraflari[i,j] == 2 || cozumGraflari[i,j] == 12 || cozumGraflari[i,j] == 22)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 0]++; cozumGrafindakiRenklerinBagSayilari[i, 2]++;
                    }
                    if (cozumGraflari[i,j] == 3 || cozumGraflari[i,j] == 13 || cozumGraflari[i,j] == 23)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 0]++; cozumGrafindakiRenklerinBagSayilari[i, 3]++;
                    }
                    if (cozumGraflari[i,j] == 4 || cozumGraflari[i,j] == 14 || cozumGraflari[i,j] == 24)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 1]++; cozumGrafindakiRenklerinBagSayilari[i, 1]++;
                    }
                    if (cozumGraflari[i,j] == 5 || cozumGraflari[i,j] == 15 || cozumGraflari[i,j] == 25)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 1]++; cozumGrafindakiRenklerinBagSayilari[i, 2]++;
                    }
                    if (cozumGraflari[i,j] == 6 || cozumGraflari[i,j] == 16 || cozumGraflari[i,j] == 26)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 1]++; cozumGrafindakiRenklerinBagSayilari[i, 3]++;
                    }
                    if (cozumGraflari[i,j] == 7 || cozumGraflari[i,j] == 17 || cozumGraflari[i,j] == 27)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 2]++; cozumGrafindakiRenklerinBagSayilari[i, 2]++;
                    }
                    if (cozumGraflari[i,j] == 8 || cozumGraflari[i,j] == 18 || cozumGraflari[i,j] == 28)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 2]++; cozumGrafindakiRenklerinBagSayilari[i, 3]++;
                    }
                    if (cozumGraflari[i,j] == 9 || cozumGraflari[i,j] == 19 || cozumGraflari[i,j] == 29)
                    {
                        cozumGrafindakiRenklerinBagSayilari[i, 3]++; cozumGrafindakiRenklerinBagSayilari[i, 3]++;
                    }
                }
            }
        }
        void cozumGrafibul()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox4.Items.Clear();

            baglanti();
            genelGrafOlustur();
            for (int i = 0; i < 350000; i++)
            {
                listBox4.Items.Add(i);
                GraflariOlustur();
                RenklerinBagSayilari();
                if (
                cozumGrafindakiRenklerinBagSayilari[0, 0] == 2 &&
                cozumGrafindakiRenklerinBagSayilari[0, 1] == 2 &&
                cozumGrafindakiRenklerinBagSayilari[0, 2] == 2 &&
                cozumGrafindakiRenklerinBagSayilari[0, 3] == 2 &&
                cozumGrafindakiRenklerinBagSayilari[1, 0] == 2 &&
                cozumGrafindakiRenklerinBagSayilari[1, 1] == 2 &&
                cozumGrafindakiRenklerinBagSayilari[1, 2] == 2 &&
                cozumGrafindakiRenklerinBagSayilari[1, 3] == 2 
                    )
                {
                    onay = 1;
                    break;
                }
            }
            listBox1.Items.Add("1. Graf ");

                for (int f = 0; f < 4; f++)
                {
                    listBox1.Items.Add(cozumGraflari[0, f]);
                }

            listBox2.Items.Add("2. Graf ");
                for (int k = 0; k < 4; k++)
                {
                    listBox2.Items.Add(cozumGraflari[1, k]);

                }
        }
        void Araislem()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Renk[i, j] = 4;
                }
            }
            ////
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (cozumGraflari[i,j] == 0 || cozumGraflari[i,j] == 10 || cozumGraflari[i,j] == 20)
                    {
                        Renk[j, i] = 0; Renk[j, i + 2] = 0;
                    }
                    if (cozumGraflari[i,j] == 1 || cozumGraflari[i,j] == 11 || cozumGraflari[i,j] == 21)
                    {
                        Renk[j, i] = 0; Renk[j, i + 2] = 1;
                    }
                    if (cozumGraflari[i,j] == 2 || cozumGraflari[i,j] == 12 || cozumGraflari[i,j] == 22)
                    {
                        Renk[j, i] = 0; Renk[j, i + 2] = 2;
                    }
                    if (cozumGraflari[i,j] == 3 || cozumGraflari[i,j] == 13 || cozumGraflari[i,j] == 23)
                    {
                        Renk[j, i] = 0; Renk[j, i + 2] = 3;
                    }
                    if (cozumGraflari[i,j] == 4 || cozumGraflari[i,j] == 14 || cozumGraflari[i,j] == 24)
                    {
                        Renk[j, i] = 1; Renk[j, i + 2] = 1;
                    }
                    if (cozumGraflari[i,j] == 5 || cozumGraflari[i,j] == 15 || cozumGraflari[i,j] == 25)
                    {
                        Renk[j, i] = 1; Renk[j, i + 2] = 2;
                    }
                    if (cozumGraflari[i,j] == 6 || cozumGraflari[i,j] == 16 || cozumGraflari[i,j] == 26)
                    {
                        Renk[j, i] = 1; Renk[j, i + 2] = 3;
                    }
                    if (cozumGraflari[i,j] == 7 || cozumGraflari[i,j] == 17 || cozumGraflari[i,j] == 27)
                    {
                        Renk[j, i] = 2; Renk[j, i + 2] = 2;
                    }
                    if (cozumGraflari[i,j] == 8 || cozumGraflari[i,j] == 18 || cozumGraflari[i,j] == 28)
                    {
                        Renk[j, i] = 2; Renk[j, i + 2] = 3;
                    }
                    if (cozumGraflari[i,j] == 9 || cozumGraflari[i,j] == 19 || cozumGraflari[i,j] == 29)
                    {
                        Renk[j, i] = 3; Renk[j, i + 2] = 3;
                    }
                }
            }
        }
        void sonuc()
        {
        enbasadön:
            int yöndegistir = 0;
            int temp = 4;
            if (Renk[0,0] == Renk[1,0] || Renk[0,2] == Renk[1,2] || yöndegistir ==1)
            {
                temp = Renk[1, 0];
                Renk[1, 0] = Renk[1, 2];
                Renk[1, 2] = temp;
                if (Renk[0,0] == Renk[1,0] || Renk[0,2] == Renk[1,2] || yöndegistir ==1 )
                {
                    temp = Renk[1, 0];
                    Renk[1, 0] = Renk[1, 1];
                    Renk[1, 1] = Renk[1, 2];
                    Renk[1, 2] = Renk[1, 3];
                    Renk[1, 3] = temp;
                    yöndegistir = 0;
                    goto enbasadön;
                }
            }
            if (Renk[0,1] == Renk[1,1] || Renk[0,3] == Renk[1,3])
            {
                temp = Renk[1, 1];
                Renk[1, 1] = Renk[1, 3];
                Renk[1, 3] = temp;
                if (Renk[0,1] == Renk[1,1] || Renk[0,3] == Renk[1,3])
                {
                    yöndegistir = 1;
                    goto enbasadön;
                }
            }
ikinciyedön:
            if (Renk[0,0]==Renk[2,0] || Renk[0,2] == Renk[2,2] || Renk[1,0]==Renk[2,0] || Renk[1,2]==Renk[2,2] || yöndegistir ==2)
            {
                temp = Renk[2, 0];
                Renk[2, 0] = Renk[2, 2];
                Renk[2, 2] = temp;
                if (Renk[0,0]==Renk[2,0] || Renk[0,2] == Renk[2,2] || Renk[1,0]==Renk[2,0] || Renk[1,2]==Renk[2,2] || yöndegistir == 2)
                {
                    temp = Renk[2, 0];
                    Renk[2, 0] = Renk[2, 1];
                    Renk[2, 1] = Renk[2, 2];
                    Renk[2, 2] = Renk[2, 3];
                    Renk[2, 3] = temp;
                    yöndegistir = 0;
                    goto ikinciyedön;
                }
            }
            if (Renk[0,1]==Renk[2,1] || Renk[0,3] == Renk[2,3] || Renk[1,1]==Renk[2,1] || Renk[1,3]==Renk[2,3])
            {
                temp = Renk[2, 1];
                Renk[2, 1] = Renk[2, 3];
                Renk[2, 3] = temp;
                if (Renk[0,1]==Renk[2,1] || Renk[0,3] == Renk[2,3] || Renk[1,1]==Renk[2,1] || Renk[1,3]==Renk[2,3])
                {
                    yöndegistir = 2;
                    goto ikinciyedön;
                }
            }
üçüncüyedön:
            if (Renk[0,0]==Renk[3,0] || Renk[1,0]==Renk[3,0] || Renk[2,0]==Renk[3,0] || Renk[0,2]==Renk[3,2] || Renk[1,2] == Renk[3,2] || Renk[2,2] ==Renk[3,2])
            {
                temp = Renk[3, 0];
                Renk[3, 0] = Renk[3, 2];
                Renk[3, 2] = temp;
                if (Renk[0,0]==Renk[3,0] || Renk[1,0]==Renk[3,0] || Renk[2,0]==Renk[3,0] || Renk[0,2]==Renk[3,2] || Renk[1,2] == Renk[3,2] || Renk[2,2] ==Renk[3,2])
                {
                    temp = Renk[3, 0];
                    Renk[3, 0] = Renk[3, 1];
                    Renk[3, 1] = Renk[3, 2];
                    Renk[3, 2] = Renk[3, 3];
                    Renk[3, 3] = temp;
                    goto üçüncüyedön;
                }
            }
            if(Renk[0,1]==Renk[3,1] || Renk[1,1]==Renk[3,1] || Renk[2,1]==Renk[3,1] || Renk[0,3]==Renk[3,3] || Renk[1,3] == Renk[3,3] || Renk[2,3] ==Renk[3,3])
            {
                temp = Renk[3, 1];
                Renk[3, 1] = Renk[3, 3];
                Renk[3, 3] = temp;
                if (Renk[0,1]==Renk[3,1] || Renk[1,1]==Renk[3,1] || Renk[2,1]==Renk[3,1] || Renk[0,3]==Renk[3,3] || Renk[1,3] == Renk[3,3] || Renk[2,3] ==Renk[3,3])
                {
                    MessageBox.Show("Hata !");
                }
            }
        }
        void genelGrafiEkranaYazdir()
        {
            listBox3.Items.Clear();
            pBoxGenelGrafKırmızı.BackColor = Color.Red;
            pBoxGenelGrafMavi.BackColor = Color.Blue;
            pBoxGenelGrafSarı.BackColor = Color.Yellow;
            pBoxGenelGrafYesil.BackColor = Color.ForestGreen;
            labelGenelGrafKırmızı_Kırmızı.Text = "";
            labelGenelGrafKırmızı_Mavi.Text = "";
            labelGenelGrafKırmızı_Sari.Text = "";
            labelGenelGrafKırmızı_Yesil.Text = "";
            labelGenelGrafMavi_Mavi.Text = "";
            labelGenelGrafMavi_Sari.Text = "";
            labelGenelGrafMavi_Yesil.Text = "";
            labelGenelGrafSari_Sari.Text = "";
            labelGenelGrafSari_Yesil.Text = "";
            labelGenelGrafYesil_Yesil.Text = "";
            Bitmap n_n1 = new Bitmap(25, 25);
            Bitmap x1 = new Bitmap(150,150);
            Bitmap yatay1 = new Bitmap(110, 25);
            Bitmap dikey1 = new Bitmap(25, 110);
            pBoxGenelGraf_X.Image = x1;
            pBoxGenelGrafKırmızı_Kırmızı.Image = n_n1;
            pBoxGenelGrafMavi_Mavi.Image = n_n1;
            pBoxGenelGrafSari_Sari.Image = n_n1;
            pBoxGenelGrafYesil_Yesil.Image = n_n1;
            pBoxGenelGrafKırmızı_Mavi.Image = yatay1;
            pBoxGenelGrafKırmızı_Sari.Image = dikey1;
            pBoxGenelGrafMavi_Yesil.Image = dikey1;
            pBoxGenelGrafSari_Yesil.Image = yatay1;
            Bitmap n_n = new Bitmap(25, 25);
            Bitmap x = new Bitmap(150, 150);
            Bitmap yatay = new Bitmap(110, 25);
            Bitmap dikey = new Bitmap(25, 110);
            for (int i = 0; i < 110; i++)
            {
                yatay.SetPixel(i, 13, Color.Black);
                dikey.SetPixel(13, i, Color.Black);
            }
            for (int i = 0; i < 25; i++)
            {
                n_n.SetPixel(0, i, Color.Black);
                n_n.SetPixel(i, 0, Color.Black);
                n_n.SetPixel(24, i, Color.Black);
                n_n.SetPixel(i, 24, Color.Black);
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (genelGraf[i, j] == 0 || genelGraf[i, j] == 10 || genelGraf[i, j] == 20)
                    {
                        labelGenelGrafKırmızı_Kırmızı.Text += Convert.ToString(i + 1) + "  ";
                        pBoxGenelGrafKırmızı_Kırmızı.Image = n_n;
                    }
                    if (genelGraf[i, j] == 1 || genelGraf[i, j] == 11 || genelGraf[i, j] == 21)
                    {
                        labelGenelGrafKırmızı_Mavi.Text += Convert.ToString(i + 1) + "  ";
                        pBoxGenelGrafKırmızı_Mavi.Image = yatay;
                    }
                    if (genelGraf[i, j] == 2 || genelGraf[i, j] == 12 || genelGraf[i, j] == 22)
                    {
                        pBoxGenelGrafKırmızı_Sari.Image = dikey;
                        labelGenelGrafKırmızı_Sari.Text += Convert.ToString(i + 1) + "  ";
                    }
                    if (genelGraf[i, j] == 3 || genelGraf[i, j] == 13 || genelGraf[i, j] == 23)
                    {
                        labelGenelGrafKırmızı_Yesil.Text += Convert.ToString(i + 1) + "  ";
                        for (int k = 1; k < 150; k++)
                        {
                            x.SetPixel(k, k, Color.Black);
                        }
                        pBoxGenelGraf_X.Image = x;
                    }
                    if (genelGraf[i, j] == 4 || genelGraf[i, j] == 14 || genelGraf[i, j] == 24)
                    {
                        labelGenelGrafMavi_Mavi.Text += Convert.ToString(i + 1) + "  ";
                        pBoxGenelGrafMavi_Mavi.Image = n_n;
                    }
                    if (genelGraf[i, j] == 5 || genelGraf[i, j] == 15 || genelGraf[i, j] == 25)
                    {
                        int q = 149;
                        labelGenelGrafMavi_Sari.Text += Convert.ToString(i + 1) + "  ";
                        for (int k = 1; k < 149; k++)
                        {
                            x.SetPixel(q--, k, Color.Black);
                        }
                        pBoxGenelGraf_X.Image = x;
                    }
                    if (genelGraf[i, j] == 6 || genelGraf[i, j] == 16 || genelGraf[i, j] == 26)
                    {
                        labelGenelGrafMavi_Yesil.Text += Convert.ToString(i + 1) + "  ";
                        pBoxGenelGrafMavi_Yesil.Image = dikey;
                    }
                    if (genelGraf[i, j] == 7 || genelGraf[i, j] == 17 || genelGraf[i, j] == 27)
                    {
                        labelGenelGrafSari_Sari.Text += Convert.ToString(i + 1) + "  ";
                        pBoxGenelGrafSari_Sari.Image = n_n;
                    }
                    if (genelGraf[i, j] == 8 || genelGraf[i, j] == 18 || genelGraf[i, j] == 28)
                    {
                        pBoxGenelGrafSari_Yesil.Image = yatay;
                        labelGenelGrafSari_Yesil.Text += Convert.ToString(i + 1) + "  ";
                    }
                    if (genelGraf[i, j] == 9 || genelGraf[i, j] == 19 || genelGraf[i, j] == 29)
                    {
                        pBoxGenelGrafYesil_Yesil.Image = n_n;
                        labelGenelGrafYesil_Yesil.Text += Convert.ToString(i + 1) + "  ";
                    }
                }
            }
            listBox3.Items.Add("Genel Graf : ");
            for (int i = 0; i < 4; i++)
            {
               listBox3.Items.Add((i + 1) + ". Kup :"+genelGraf[i,0]+"  "+genelGraf[i,1]+"  "+genelGraf[i,2]);
            }
        }
        void cozumGraflarınıEkranaYazdir()
        {
            pictureBox11.BackColor = Color.Red;            pictureBox24.BackColor = Color.Red;
            pictureBox23.BackColor = Color.Blue;            pictureBox10.BackColor = Color.Blue;
            pictureBox12.BackColor = Color.Yellow;            pictureBox25.BackColor = Color.Yellow;
            pictureBox26.BackColor = Color.ForestGreen;            pictureBox13.BackColor = Color.ForestGreen;
            label10.Text = ""; label11.Text = ""; label12.Text = ""; label13.Text = ""; label14.Text = ""; label15.Text = "";
            label16.Text = ""; label17.Text = ""; label18.Text = ""; label19.Text = ""; label2.Text = ""; label20.Text = "";
            label21.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = ""; label6.Text = ""; label7.Text = "";
            label8.Text = ""; label9.Text = "";
            Bitmap n_n1 = new Bitmap(25, 25);
            Bitmap x1 = new Bitmap(150, 150);
            Bitmap yatay1 = new Bitmap(110, 25);
            Bitmap dikey1 = new Bitmap(25, 110);
            pictureBox1.Image = n_n1; pictureBox2.Image = n_n1; pictureBox3.Image = n_n1; pictureBox4.Image = n_n1;
            pictureBox14.Image = n_n1; pictureBox15.Image = n_n1; pictureBox16.Image = n_n1; pictureBox17.Image = n_n1;
            pictureBox18.Image = x1; pictureBox5.Image = x1;
            pictureBox8.Image = yatay1; pictureBox9.Image = yatay1; pictureBox21.Image = yatay1; pictureBox22.Image = yatay1;
            pictureBox6.Image = dikey1; pictureBox7.Image = dikey1; pictureBox19.Image = dikey1; pictureBox20.Image = dikey1;
            Bitmap n_n = new Bitmap(25, 25);
            Bitmap x = new Bitmap(150, 150);
            Bitmap yatay = new Bitmap(110, 25);
            Bitmap dikey = new Bitmap(25, 110);
            for (int i = 0; i < 110; i++)
            {
                yatay.SetPixel(i, 13, Color.Black);
                dikey.SetPixel(13, i, Color.Black);
            }
            for (int i = 0; i < 25; i++)
            {
                n_n.SetPixel(0, i, Color.Black);
                n_n.SetPixel(i, 0, Color.Black);
                n_n.SetPixel(24, i, Color.Black);
                n_n.SetPixel(i, 24, Color.Black);
            }
            for (int i = 0; i < 2; i++)
            {
                if (i==0)
                {
                    for (int q = 0; q < 4; q++)
                    {
                        if (cozumGraflari[i, q] == 0 || cozumGraflari[i, q] == 10 || cozumGraflari[i, q] == 20)
                        {
                            label2.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox1.Image = n_n;
                        }
                        if (cozumGraflari[i, q] == 1 || cozumGraflari[i, q] == 11 || cozumGraflari[i, q] == 21)
                        {
                            label3.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox9.Image = yatay;
                        }
                        if (cozumGraflari[i, q] == 2 || cozumGraflari[i, q] == 12 || cozumGraflari[i, q] == 22)
                        {
                            label6.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox6.Image = dikey;
                        }
                        if (cozumGraflari[i, q] == 3 || cozumGraflari[i, q] == 13 || cozumGraflari[i, q] == 23)
                        {
                            for (int k = 1; k < 150; k++)
                            {
                                x.SetPixel(k, k, Color.Black);
                            }
                            label5.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox5.Image = x;
                        }
                        if (cozumGraflari[i, q] == 4 || cozumGraflari[i, q] == 14 || cozumGraflari[i, q] == 24)
                        {
                            label4.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox2.Image = n_n;
                        }
                        if (cozumGraflari[i, q] == 5 || cozumGraflari[i, q] == 15 || cozumGraflari[i, q] == 25)
                        {
                            int w = 149;
                            for (int k = 1; k < 149; k++)
                            {
                                x.SetPixel(w--, k, Color.Black);
                            }
                            label9.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox5.Image = x;
                        }
                        if (cozumGraflari[i, q] == 6 || cozumGraflari[i, q] == 16 || cozumGraflari[i, q] == 26)
                        {
                            label7.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox7.Image = dikey;
                        }
                        if (cozumGraflari[i, q] == 7 || cozumGraflari[i, q] == 17 || cozumGraflari[i, q] == 27)
                        {
                            label8.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox4.Image = n_n;
                        }
                        if (cozumGraflari[i, q] == 8 || cozumGraflari[i, q] == 18 || cozumGraflari[i, q] == 28)
                        {
                            label11.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox8.Image = yatay;
                        }
                        if (cozumGraflari[i, q] == 9 || cozumGraflari[i, q] == 19 || cozumGraflari[i, q] == 29)
                        {
                            label10.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox3.Image = n_n;
                        }
                    }
                }
                if (i==1)
                {
                    for (int q = 0; q < 4; q++)
                    {
                        if (cozumGraflari[i, q] == 0 || cozumGraflari[i, q] == 10 || cozumGraflari[i, q] == 20)
                        {
                            label12.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox14.Image = n_n;
                        }
                        if (cozumGraflari[i, q] == 1 || cozumGraflari[i, q] == 11 || cozumGraflari[i, q] == 21)
                        {
                            label13.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox22.Image = yatay;
                        }
                        if (cozumGraflari[i, q] == 2 || cozumGraflari[i, q] == 12 || cozumGraflari[i, q] == 22)
                        {
                            label16.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox19.Image = dikey;
                        }
                        if (cozumGraflari[i, q] == 3 || cozumGraflari[i, q] == 13 || cozumGraflari[i, q] == 23)
                        {
                            for (int k = 1; k < 150; k++)
                            {
                                x.SetPixel(k, k, Color.Black);
                            }
                            label15.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox18.Image = x;
                        }
                        if (cozumGraflari[i, q] == 4 || cozumGraflari[i, q] == 14 || cozumGraflari[i, q] == 24)
                        {
                            label14.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox15.Image = n_n;
                        }
                        if (cozumGraflari[i, q] == 5 || cozumGraflari[i, q] == 15 || cozumGraflari[i, q] == 25)
                        {
                            int w = 149;
                            for (int k = 1; k < 149; k++)
                            {
                                x.SetPixel(w--, k, Color.Black);
                            }
                            label19.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox18.Image = x;
                        }
                        if (cozumGraflari[i, q] == 6 || cozumGraflari[i, q] == 16 || cozumGraflari[i, q] == 26)
                        {
                            label17.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox20.Image = dikey;
                        }
                        if (cozumGraflari[i, q] == 7 || cozumGraflari[i, q] == 17 || cozumGraflari[i, q] == 27)
                        {
                            label18.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox17.Image = n_n;
                        }
                        if (cozumGraflari[i, q] == 8 || cozumGraflari[i, q] == 18 || cozumGraflari[i, q] == 28)
                        {
                            label21.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox21.Image = yatay;
                        }
                        if (cozumGraflari[i, q] == 9 || cozumGraflari[i, q] == 19 || cozumGraflari[i, q] == 29)
                        {
                            label20.Text += Convert.ToString((q + 1) + "  ");
                            pictureBox16.Image = n_n;
                        }
                    }
                }
            }
        }
        void Cozum()
        {
            
            cozumGrafibul();
            genelGrafiEkranaYazdir();
            if (onay==1)
            {
                Araislem();
                sonuc();
                cozumGraflarınıEkranaYazdir();
                sonucuEkranaYazdir();
                onay = 0;
                MessageBox.Show("Sonuç bulundu.");
                
            }
            else
            {
                czmgrfsil();
                MessageBox.Show("Sonuç bulunamadı.");
            }
        }
        void czmgrfsil()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            pictureBox11.BackColor = Color.Empty; pictureBox24.BackColor = Color.Empty;
            pictureBox23.BackColor = Color.Empty; pictureBox10.BackColor = Color.Empty;
            pictureBox12.BackColor = Color.Empty; pictureBox25.BackColor = Color.Empty;
            pictureBox26.BackColor = Color.Empty; pictureBox13.BackColor = Color.Empty;
            pb01.BackColor = Color.Empty; pb02.BackColor = Color.Empty; pb03.BackColor = Color.Empty; pb04.BackColor = Color.Empty;
            pb11.BackColor = Color.Empty; pb12.BackColor = Color.Empty; pb13.BackColor = Color.Empty; pb14.BackColor = Color.Empty;
            pb21.BackColor = Color.Empty; pb22.BackColor = Color.Empty; pb23.BackColor = Color.Empty; pb24.BackColor = Color.Empty;
            pb31.BackColor = Color.Empty; pb32.BackColor = Color.Empty; pb33.BackColor = Color.Empty; pb34.BackColor = Color.Empty;
            label10.Text = ""; label11.Text = ""; label12.Text = ""; label13.Text = ""; label14.Text = ""; label15.Text = "";
            label16.Text = ""; label17.Text = ""; label18.Text = ""; label19.Text = ""; label2.Text = ""; label20.Text = "";
            label21.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = ""; label6.Text = ""; label7.Text = "";
            label8.Text = ""; label9.Text = "";
            Bitmap n_n1 = new Bitmap(25, 25);
            Bitmap x1 = new Bitmap(150, 150);
            Bitmap yatay1 = new Bitmap(110, 25);
            Bitmap dikey1 = new Bitmap(25, 110);
            pictureBox1.Image = n_n1; pictureBox2.Image = n_n1; pictureBox3.Image = n_n1; pictureBox4.Image = n_n1;
            pictureBox14.Image = n_n1; pictureBox15.Image = n_n1; pictureBox16.Image = n_n1; pictureBox17.Image = n_n1;
            pictureBox18.Image = x1; pictureBox5.Image = x1;
            pictureBox8.Image = yatay1; pictureBox9.Image = yatay1; pictureBox21.Image = yatay1; pictureBox22.Image = yatay1;
            pictureBox6.Image = dikey1; pictureBox7.Image = dikey1; pictureBox19.Image = dikey1; pictureBox20.Image = dikey1;

        }
        void sonucuEkranaYazdir()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int q = 0; q < 4; q++)
                {
                    if (i==0)
                    {
                        if (q == 0)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb01.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb01.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb01.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb01.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 1)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb02.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb02.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb02.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb02.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 2)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb03.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb03.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb03.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb03.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 3)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb04.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb04.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb04.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb04.BackColor = Color.ForestGreen;
                            }
                        }
                    }
                    if (i==1)
                    {
                        if (q == 0)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb11.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb11.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb11.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb11.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 1)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb12.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb12.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb12.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb12.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 2)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb13.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb13.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb13.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb13.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 3)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb14.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb14.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb14.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb14.BackColor = Color.ForestGreen;
                            }
                        }
                    }
                    if (i==2)
                    {
                        if (q == 0)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb21.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb21.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb21.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb21.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 1)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb22.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb22.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb22.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb22.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 2)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb23.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb23.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb23.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb23.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 3)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb24.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb24.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb24.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb24.BackColor = Color.ForestGreen;
                            }
                        }
                    }
                    if (i==3)
                    {
                        if (q == 0)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb31.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb31.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb31.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb31.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 1)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb32.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb32.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb32.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb32.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 2)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb33.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb33.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb33.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb33.BackColor = Color.ForestGreen;
                            }
                        }
                        if (q == 3)
                        {
                            if (Renk[i, q] == 0)
                            {
                                pb34.BackColor = Color.Red;
                            }
                            if (Renk[i, q] == 1)
                            {
                                pb34.BackColor = Color.Blue;
                            }
                            if (Renk[i, q] == 2)
                            {
                                pb34.BackColor = Color.Yellow;
                            }
                            if (Renk[i, q] == 3)
                            {
                                pb34.BackColor = Color.ForestGreen;
                            }
                        }
                    }
                }
            }
        }
        void asd()
        {
            StreamWriter yaz = new StreamWriter(@"" + "kupler.txt");
            for (int i = 0; i < 6165; i++)
            {
                randomKupOlustur();
                cozumGrafibul();
                if (onay==1)
                {
                    Araislem();
                    sonuc();
                    onay = 0;
                    yaz.WriteLine(Convert.ToString(i + 1) + " . Kup icin sonuc : " + Convert.ToString(Renk[0, 0]) + " " + Convert.ToString(Renk[0, 1]) + " " + Convert.ToString(Renk[0, 2]) + " " + Convert.ToString(Renk[0, 3]) + " " + Convert.ToString(Renk[1, 0]) + " " + Convert.ToString(Renk[1,1]) + " " + Convert.ToString(Renk[1, 2]) + " " + Convert.ToString(Renk[1, 3]) + " " + Convert.ToString(Renk[2, 0]) + " " + Convert.ToString(Renk[2, 1]) + " " + Convert.ToString(Renk[2, 2]) + " " + Convert.ToString(Renk[2, 3]) + " " + Convert.ToString(Renk[3, 0]) + " " + Convert.ToString(Renk[3, 1]) + " " + Convert.ToString(Renk[3, 2]) + " " + Convert.ToString(Renk[3, 3]) + " dir.");
                    listBox5.Items.Add("Sonuç Bulundu.");
                }
                else
                {
                    yaz.WriteLine(Convert.ToString(i + 1) + " . Kup icin sonuc yoktur.");
                    listBox5.Items.Add("Sonuç Bulunamadı.");
                }
            }
            MessageBox.Show("işlem tamam");
            yaz.Close();
        }
        void randomKupOlustur()
        {
            int k = 0, m = 0, s = 0, y = 0;
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
            rndmTkrarKup:
                for (int j = 0; j < 6; j++)
                {
                    Kupler[i, j] = r.Next(4);
                }
                for (int q = 0; q < 6; q++)
                {
                    if (Kupler[i, q] == 0)
                    {
                        k = 1;
                    }
                    if (Kupler[i, q] == 1)
                    {
                        m = 1;
                    }
                    if (Kupler[i, q] == 2)
                    {
                        s = 1;
                    }
                    if (Kupler[i, q] == 3)
                    {
                        y = 1;
                    }
                }
                if (k == 1 && m == 1 && s == 1 && y == 1)
                {
                    k = 0; m = 0; s = 0; y = 0;
                }
                else
                {
                    k = 0; m = 0; s = 0; y = 0;
                    goto rndmTkrarKup;
                }

            }
        }

        private void btnManuel_Click(object sender, EventArgs e)
        {
            this.Hide();
            KupOlustur kup = new KupOlustur();
            kup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            randomKupOlustur();
            KupleriEkranaYazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElileolusturulanKupleriForm1eAl();
            KupleriEkranaYazdir();
        }

        private void btnCozum_Click(object sender, EventArgs e)
        {
            Cozum();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            czmgrfsil();
            labelGenelGrafKırmızı_Kırmızı.Text = "";
            labelGenelGrafKırmızı_Mavi.Text = "";
            labelGenelGrafKırmızı_Sari.Text = "";
            labelGenelGrafKırmızı_Yesil.Text = "";
            labelGenelGrafMavi_Mavi.Text = "";
            labelGenelGrafMavi_Sari.Text = "";
            labelGenelGrafMavi_Yesil.Text = "";
            labelGenelGrafSari_Sari.Text = "";
            labelGenelGrafSari_Yesil.Text = "";
            labelGenelGrafYesil_Yesil.Text = "";
            label10.Text = ""; label11.Text = ""; label12.Text = ""; label13.Text = ""; label14.Text = ""; label15.Text = "";
            label16.Text = ""; label17.Text = ""; label18.Text = ""; label19.Text = ""; label2.Text = ""; label20.Text = "";
            label21.Text = ""; label3.Text = ""; label4.Text = ""; label5.Text = ""; label6.Text = ""; label7.Text = "";
            label8.Text = ""; label9.Text = "";
            pictureBox11.BackColor = Color.Empty; pictureBox24.BackColor = Color.Empty;
            pictureBox23.BackColor = Color.Empty; pictureBox10.BackColor = Color.Empty;
            pictureBox12.BackColor = Color.Empty; pictureBox25.BackColor = Color.Empty;
            pictureBox26.BackColor = Color.Empty; pictureBox13.BackColor = Color.Empty;
            pBoxGenelGrafKırmızı.BackColor = Color.Empty;
            pBoxGenelGrafMavi.BackColor = Color.Empty;
            pBoxGenelGrafSarı.BackColor = Color.Empty;
            pBoxGenelGrafYesil.BackColor = Color.Empty;
            pBox00.BackColor = Color.Empty;
            pBox01.BackColor = Color.Empty;
            pBox02.BackColor = Color.Empty;
            pBox03.BackColor = Color.Empty;
            pBox04.BackColor = Color.Empty;
            pBox05.BackColor = Color.Empty;
            pBox10.BackColor = Color.Empty;
            pBox11.BackColor = Color.Empty;
            pBox12.BackColor = Color.Empty;
            pBox13.BackColor = Color.Empty;
            pBox14.BackColor = Color.Empty;
            pBox15.BackColor = Color.Empty;
            pBox20.BackColor = Color.Empty;
            pBox21.BackColor = Color.Empty;
            pBox22.BackColor = Color.Empty;
            pBox23.BackColor = Color.Empty;
            pBox24.BackColor = Color.Empty;
            pBox25.BackColor = Color.Empty;
            pBox30.BackColor = Color.Empty;
            pBox31.BackColor = Color.Empty;
            pBox32.BackColor = Color.Empty;
            pBox33.BackColor = Color.Empty;
            pBox34.BackColor = Color.Empty;
            pBox35.BackColor = Color.Empty;
            panel1.BackColor = Color.Empty;
            Bitmap n_n1 = new Bitmap(25, 25);
            Bitmap x1 = new Bitmap(150, 150);
            Bitmap yatay1 = new Bitmap(110, 25);
            Bitmap dikey1 = new Bitmap(25, 110);
            pictureBox1.Image = n_n1; pictureBox2.Image = n_n1; pictureBox3.Image = n_n1; pictureBox4.Image = n_n1;
            pictureBox14.Image = n_n1; pictureBox15.Image = n_n1; pictureBox16.Image = n_n1; pictureBox17.Image = n_n1;
            pictureBox18.Image = x1; pictureBox5.Image = x1;
            pictureBox8.Image = yatay1; pictureBox9.Image = yatay1; pictureBox21.Image = yatay1; pictureBox22.Image = yatay1;
            pictureBox6.Image = dikey1; pictureBox7.Image = dikey1; pictureBox19.Image = dikey1; pictureBox20.Image = dikey1;
            pBoxGenelGraf_X.Image = x1;
            pBoxGenelGrafKırmızı_Kırmızı.Image = n_n1;
            pBoxGenelGrafMavi_Mavi.Image = n_n1;
            pBoxGenelGrafSari_Sari.Image = n_n1;
            pBoxGenelGrafYesil_Yesil.Image = n_n1;
            pBoxGenelGrafKırmızı_Mavi.Image = yatay1;
            pBoxGenelGrafKırmızı_Sari.Image = dikey1;
            pBoxGenelGrafMavi_Yesil.Image = dikey1;
            pBoxGenelGrafSari_Yesil.Image = yatay1;
        }

        private void btnKombinasyon_Click(object sender, EventArgs e)
        {
            asd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
