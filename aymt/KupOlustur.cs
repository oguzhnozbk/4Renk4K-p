using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aymt
{
    public partial class KupOlustur : Form
    {
        public static int[,] olstrKup = new int[4, 6];
        int[] kup = new int[6];
        int i = 4;
        public KupOlustur()
        {
            InitializeComponent();
            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 6; j++)
                {
                    kup[j] = 4;
                    olstrKup[k, j] = 4;
                }
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 anafrm = new Form1();
            anafrm.Show();
        }
     
        private void kup1scm_CheckedChanged(object sender, EventArgs e)
        {
            i = 0;
            if (olstrKup[0,0]!=4)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j==0)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel1.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel1.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel1.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel1.BackColor = Color.ForestGreen;
                        }    
                    }
                    if (j == 1)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel2.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel2.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel2.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel2.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 2)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel3.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel3.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel3.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel3.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 3)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel4.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel4.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel4.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel4.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 4)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel5.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel5.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel5.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel5.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 5)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel6.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel6.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel6.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel6.BackColor = Color.ForestGreen;
                        }
                    }
                }
            }
            else
            {
                panel1.BackColor = Color.Empty;
                panel2.BackColor = Color.Empty;
                panel3.BackColor = Color.Empty;
                panel4.BackColor = Color.Empty;
                panel5.BackColor = Color.Empty;
                panel6.BackColor = Color.Empty;
            }
        }

        private void kup2scm_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
            if (olstrKup[i, 0] != 4)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 0)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel1.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel1.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel1.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel1.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 1)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel2.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel2.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel2.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel2.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 2)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel3.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel3.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel3.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel3.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 3)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel4.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel4.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel4.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel4.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 4)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel5.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel5.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel5.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel5.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 5)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel6.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel6.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel6.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel6.BackColor = Color.ForestGreen;
                        }
                    }
                }
            }
            else
            {
                panel1.BackColor = Color.Empty;
                panel2.BackColor = Color.Empty;
                panel3.BackColor = Color.Empty;
                panel4.BackColor = Color.Empty;
                panel5.BackColor = Color.Empty;
                panel6.BackColor = Color.Empty;
            }
        }

        private void kup3scm_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
            if (olstrKup[i, 0] != 4)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 0)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel1.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel1.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel1.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel1.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 1)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel2.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel2.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel2.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel2.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 2)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel3.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel3.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel3.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel3.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 3)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel4.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel4.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel4.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel4.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 4)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel5.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel5.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel5.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel5.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 5)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel6.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel6.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel6.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel6.BackColor = Color.ForestGreen;
                        }
                    }
                }
            }
            else
            {
                panel1.BackColor = Color.Empty;
                panel2.BackColor = Color.Empty;
                panel3.BackColor = Color.Empty;
                panel4.BackColor = Color.Empty;
                panel5.BackColor = Color.Empty;
                panel6.BackColor = Color.Empty;
            }
        }

        private void kup4scm_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
            if (olstrKup[i, 0] != 4)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 0)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel1.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel1.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel1.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel1.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 1)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel2.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel2.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel2.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel2.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 2)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel3.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel3.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel3.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel3.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 3)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel4.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel4.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel4.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel4.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 4)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel5.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel5.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel5.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel5.BackColor = Color.ForestGreen;
                        }
                    }
                    if (j == 5)
                    {
                        if (olstrKup[i, j] == 0)
                        {
                            panel6.BackColor = Color.Red;
                        }
                        if (olstrKup[i, j] == 1)
                        {
                            panel6.BackColor = Color.Blue;
                        }
                        if (olstrKup[i, j] == 2)
                        {
                            panel6.BackColor = Color.Yellow;
                        }
                        if (olstrKup[i, j] == 3)
                        {
                            panel6.BackColor = Color.ForestGreen;
                        }
                    }
                }
            }
            else
            {
                panel1.BackColor = Color.Empty;
                panel2.BackColor = Color.Empty;
                panel3.BackColor = Color.Empty;
                panel4.BackColor = Color.Empty;
                panel5.BackColor = Color.Empty;
                panel6.BackColor = Color.Empty;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (i==4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel1.BackColor = Color.Red;
                kup[0] = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel1.BackColor = Color.Blue;
                kup[0] = 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel1.BackColor = Color.Yellow;
                kup [0] = 2;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel1.BackColor = Color.ForestGreen;
                kup[0] = 3;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel2.BackColor = Color.Red;
                kup[1] = 0;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel2.BackColor = Color.Blue;
                kup[1] = 1;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel2.BackColor = Color.Yellow;
                kup[1] = 2;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel2.BackColor = Color.ForestGreen;
                kup[1] = 3;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel3.BackColor = Color.Red;
                kup[2] = 0;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel3.BackColor = Color.Blue;
                kup[2] = 1;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel3.BackColor = Color.Yellow;
                kup[2] = 2;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel3.BackColor = Color.ForestGreen;
                kup[2] = 3;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel4.BackColor = Color.Red;
                kup[3] = 0;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel4.BackColor = Color.Blue;
                kup[3] = 1;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel4.BackColor = Color.Yellow;
                kup[3] = 2;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel4.BackColor = Color.ForestGreen;
                kup[3] = 3;
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel5.BackColor = Color.Red;
                kup[4] = 0;
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel5.BackColor = Color.Blue;
                kup[4] = 1;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel5.BackColor = Color.Yellow;
                kup[4] = 2;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel5.BackColor = Color.ForestGreen;
                kup[4] = 3;
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel6.BackColor = Color.Red;
                kup[5] = 0;
            }
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel6.BackColor = Color.Blue;
                kup[5] = 1;
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel6.BackColor = Color.Yellow;
                kup[5] = 2;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 4)
            {
                MessageBox.Show("Lütfen Hangi Küp için işlem yapacağınızı seçiniz.");
            }
            else
            {
                panel6.BackColor = Color.ForestGreen;
                kup[5] = 3;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int k = 0, m = 0, s = 0, y = 0;
            for (int q = 0; q < 6; q++)
            {
                if (kup[q]==0)
                {
                    k = 1;
                }
                if (kup[q]==1)
                {
                    m = 1;
                }
                if (kup[q]==2)
                {
                    s = 1;
                }
                if (kup[q]==3)
                {
                    y = 1;
                }
            }
            if (k==1 && m==1 && s==1 && y==1)
            {
                for (int w = 0; w < 6; w++)
                {
                    olstrKup[i, w] = kup[w];
                }
                MessageBox.Show((i+1) + ". Küp'ünüz başarılı bir şekilde kaydedilmiştir.");
            }
            else
            {
                MessageBox.Show("Lütfen her renkten en az 1 tane olacak şekilde seçimizini tekrar yapınız.");
            }
        }
    }
}
