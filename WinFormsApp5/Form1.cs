namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Kullanici_Adi = new List<string>();
        List<string> Kullanici_Sifre = new List<string>();
        List<string> Kullanici_Anahtar = new List<string>();
        string kullanici_adi = "emre123";
        string sifre = "123456";
        int sayac = 5;
        int deneme = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici_Adi.Add(textBox1.Text);
            Kullanici_Sifre.Add(textBox3.Text);
            Kullanici_Anahtar.Add(textBox2.Text);
            if (textBox1.Text == kullanici_adi && textBox3.Text == sifre)
            {
                label5.Text = "Basariyla Giris Yaptiniz";
            }
            else
            {
                while (sayac > 0)
                {
                    sayac -= 1;
                    label5.Text = "Kullanici adi veya Sifre Hatali.Kalan Hakkýnýz " + sayac;
                    string degerler = Kullanici_Adi[deneme] + " " + Kullanici_Sifre[deneme] + " " + Kullanici_Anahtar[deneme];
                    Hatali_Girisler.Items.Add(degerler);
                    deneme += 1;
                    if (sayac == 0)
                    {
                        label5.Text = "Hatali giris hakkiniz doldu!";
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hatali_Girisler.Items.Clear();
            sayac = 5;
        }
    }
}