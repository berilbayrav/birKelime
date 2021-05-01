using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHarfGetir_Click(object sender, EventArgs e)
        {
            // Sesli ve sessiz harflerin tutulduğu diziler
            string[] sesli = { "A", "E", "I", "İ", "O", "Ö", "U", "Ü" };
            string[] sessiz = { "B", "C", "Ç", "D", "F", "G", "Ğ", "H", "J", "K", "L", "M", "N", "P", "R", "S", "Ş", "T", "V", "Y", "Z" };
            Random random = new Random();
            
            for (int i = 0; i < 4; i++)   // 4 adet sesli ve 4 adet sessiz harf oluşturuyorum.
            {
                txtHarfler.Text += sessiz[random.Next(sessiz.Length)].ToLower();
                txtHarfler.Text += sesli[random.Next(sesli.Length)].ToLower();
            }
            // 1 tane de random joker harf oluşturup textboxa atıyorum
            txtJoker.Text = sessiz[random.Next(sessiz.Length)].ToLower();

        }
        // Karıştır butonuna bastığımızda tüm harfleri karıştırıyor
        private void btnKaristir_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == false && radioButton2.Checked==false)
            {
                MessageBox.Show("Joker harfi kullanıp kullanmayacağınızı seçiniz");
            }
            // Joker harfi kullanıp kullanmayacağımız spruluyor eğer kullanmak istersek bu bloğun içine giriyor.
            if (radioButton1.Checked == true)
            {
                
                string uret = "";
                // string.Concat metoduyla textboxlarda yazan harfleri birleştiriyorum
                uret = string.Concat(txtHarfler.Text,txtJoker.Text);
                // string olan uret değişkenimi char tipine dönüştürüp harfleri dizide tutuyorum
                char[] degisken = uret.ToCharArray();
                // uret adlı değişkenimin uzunluğunu sayi adlı dizimin uzunluğuna atıyorum
                string[] sayi = new string[uret.Count()]; 
                for (int i = 0; i < uret.Count(); i++)
                {
                    sayi[i] = degisken[i].ToString();
                }

                // En az 3 harfli kelimeler bulcağımız için kombinasyonu 3'ten başlatıyorum
                int kombinasyon = 3;

                // Kombinasyon kodum
                for (int i = 0; i <= sayi.Length; i++)
                {
                    var sonuc = Deneme.Combinations(sayi, kombinasyon);
                    foreach (var item in sonuc)
                    {
                        string s = string.Join("", item.ToArray());
                        listBox1.Items.Add(s);
                    }
                    kombinasyon++;
                }


                MessageBox.Show("Karıştırma bitmiştir.");
            }

            // Eğer joker harf'i kullanmak istemezsek bu kod parçasının içine giriliyor ve aynı işlemler yapılıyor
            if (radioButton2.Checked == true)
            {
                string uret = "";
                uret = txtHarfler.Text;
                char[] degisken = txtHarfler.Text.ToCharArray();
                string[] sayi = new string[txtHarfler.Text.Count()];
                for (int i = 0; i < txtHarfler.Text.Count(); i++)
                {
                    sayi[i] = degisken[i].ToString();
                }
               
                int kombinasyon = 3;

                for (int i = 0; i <= sayi.Length; i++)
                {
                    var sonuc = Deneme.Combinations(sayi, kombinasyon);
                    foreach (var item in sonuc)
                    {
                        string s = string.Join("", item.ToArray());
                        listBox1.Items.Add(s);
                    }
                    kombinasyon++;
                }

               

                MessageBox.Show("Karıştırma bitmiştir.");
            }
        }
           
        private void btnListele_Click(object sender, EventArgs e)
        {

            // Access bağlantımı açıyorum ve tablomdan kelimeleri alıp komut nesnemin içine atıyorum
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ulker\Desktop\Bir_Kelime\sozluk2.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select kelime from tablo", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();

            // Listbox1'de karıştırılan harflerle database'mdeki harflere bakıp karşılaştırma yapıyor eğer aynı uzunlukta ve aynı harflerden oluşuyorsa listbox2'ye kaydediyor.
            while (dr.Read())
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString() == dr[0].ToString())
                    {
                        listBox2.Items.Add(dr[0].ToString());
                    }
                    if (dr[0].ToString().Length == listBox1.Items[i].ToString().Length)
                    {
                        if (dr[0].ToString().Contains(listBox1.Items[i].ToString()))
                        {
                            listBox2.Items.Add(dr[0].ToString());
                        }
                        
                    }
                    
                }
            }
            baglanti.Close();

            
            // Listbox2'de aynı olan kelimeleri siliyorum
            string[] arr = new string[listBox2.Items.Count];
            listBox2.Items.CopyTo(arr, 0);
            var arr2 = arr.Distinct();
            listBox2.Items.Clear();
            foreach (string s in arr2)
            {
                listBox2.Items.Add(s);
            }
            MessageBox.Show("İşlem bitmiştir");
        }

        private void btnKelimeGetir_Click(object sender, EventArgs e)
        {
            int puan = 0;
            int uzunluk = 0;
            string enUzun = "";

            //listbox2 deki değerleri diziye atıp en uzun kelimeyi textboxa yazıran kod
            string[] veriler1 = new string[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                veriler1[i] = listBox2.Items[i].ToString();
            }
            for (int i = 0; i < veriler1.Length; i++)
            {
                if (veriler1[i].Length > uzunluk)
                {
                    uzunluk = veriler1[i].Length;
                    enUzun = veriler1[i];

                }
                txtKelime.Text = enUzun;

            }

            //harf sayısına göre puanlama yapıyor
            if (txtKelime.Text.Length == 3)
            {
                puan += 3;
                lblPuan.Text = puan.ToString();
            }
            else if (txtKelime.Text.Length == 4)
            {
                puan += 4;
                lblPuan.Text = puan.ToString();
            }
            else if (txtKelime.Text.Length == 5)
            {
                puan += 5;
                lblPuan.Text = puan.ToString();
            }
            else if (txtKelime.Text.Length == 6)
            {
                puan += 7;
                lblPuan.Text = puan.ToString();
            }
            else if (txtKelime.Text.Length == 7)
            {
                puan += 9;
                lblPuan.Text = puan.ToString();
            }
            else if (txtKelime.Text.Length == 8)
            {
                puan += 11;
                lblPuan.Text = puan.ToString();
            }
            else if (txtKelime.Text.Length == 9)
            {
                puan += 15;
                lblPuan.Text = puan.ToString();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Temizle butonuna basınca textboxları label'ı radioButton'ların değerlerini siliyor
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            txtHarfler.Clear();
            txtKelime.Clear();
            lblPuan.Text = string.Empty;
            txtJoker.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtHarfler.Enabled = false;
            txtJoker.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Çarpı butonuna basınca uygulamadan çıkıyor
            Application.Exit();
        }

        private void oyunHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Üst taraftaki context menü stripte yer alan Oyun Hakkında'ya basınca ekranda gelmesini istediğim yazı
            MessageBox.Show("Oyunun amacı;8 harf ve 1 adet joker harfi kullanarak anlamlı kelimeler oluşturmak ve database'deki var olan kelimelerle karşılaştırarak en uzun kelimeyi ekrana getirmektir. Ekrana gelen kelime uzunluğuna göre de puan verilmektedir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHarfler.Enabled = false;
            txtJoker.Enabled = false;
            txtKelime.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHarfler.Enabled = true;
            txtJoker.Enabled = true;
            MessageBox.Show("Lütfen 4 adet sesli ve 4 adet sessiz harf giriniz. Joker harf kullanıp kullanmayacağınızı seçin ve ona göre joker harf de giriniz.");
        }
    }
}

// Kombinasyon kodu
public static class Deneme
{
    public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
    {
        return k == 0 ? new[] { new T[0] } : elements.SelectMany((e, i) => elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));
    }
}


