using System;

using System.Windows.Forms;

namespace Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac1 = 0;
        object ilk_resim, ikinci_resim;
        int durum = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Dunya.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Agac.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();
            }
        }
private void pictureBox4_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Dunya.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Kaplan.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Kelebek.jpg");
            (sender as PictureBox).Enabled= false;

            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Kaplan.jpg");
            (sender as PictureBox).Enabled= false;

            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Kelebek.jpg");
            (sender as PictureBox).Enabled= false;
         
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((ilk_resim as PictureBox).ImageLocation == (ikinci_resim as PictureBox).ImageLocation)
            {
                sayac1++;
                (ilk_resim as PictureBox).Visible = false;
                (ikinci_resim as PictureBox).Visible = false;

            }
            if (sayac1 == 8)
            {
                timer2.Stop();
                MessageBox.Show("Tebrikler Başardınız.");
                Application.Exit();
            }

            else
            {
                (ilk_resim as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Kapak.jpg");
                (ikinci_resim as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Kapak.jpg");
                (ilk_resim as PictureBox).Enabled = true;
                (ikinci_resim as PictureBox).Enabled = true;
            }
            timer1.Stop();
        }
        int sayac = 45;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString();
            if (sayac == 0)
            {
                MessageBox.Show("Süreniz Doldu.");
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Lotus.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Lotus.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();

            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Araba.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();

            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Araba.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Koala.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Koala.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Aslan.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Aslan.jpg");
            (sender as PictureBox).Enabled = false;
            if (durum == 1)
            {
                ilk_resim = sender;

            }
            if (durum == 2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            durum++;
            (sender as PictureBox).Load("C:\\Users\\ferha\\Desktop\\C# Oyun\\Resimler\\Agac.jpg");
            (sender as PictureBox).Enabled= false;
            if(durum==1)
            {
                ilk_resim = sender;

            }
            if(durum==2)
            {
                ikinci_resim = sender;
                durum = 0;
                timer1.Start();
                
            }
        }
    }
}
