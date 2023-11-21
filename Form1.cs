using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ürünlerin fiyatlarini tutacak dictionary
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Gazoz", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Lahmacun", 25.0m);
            urunFiyatlari.Add("İskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Makarna", 25.0m);
            urunFiyatlari.Add("Pasta", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);


            // Ürünlerin adetlerini tutacak dictionary
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Gazoz", 0);
            urunAdetleri.Add("Fanta", 0);
            urunAdetleri.Add("Çay", 0);
            urunAdetleri.Add("Lahmacun", 0);
            urunAdetleri.Add("İskender", 0);
            urunAdetleri.Add("Döner", 0);
            urunAdetleri.Add("Makarna", 0);
            urunAdetleri.Add("Pasta", 0);
            urunAdetleri.Add("Künefe", 0);

            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için degisken
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola.Text);
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxGazoz.Checked)
            {
                int adet = Convert.ToInt32(textBoxGazoz.Text);
                toplamFiyat += urunFiyatlari["Gazoz"] * adet;
                urunAdetleri["Gazoz"] = adet;
            }

            if (checkBoxFanta.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta.Text);
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay.Text);
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxLahmacun.Checked)
            {
                int adet = Convert.ToInt32(textBoxLahmacun.Text);
                toplamFiyat += urunFiyatlari["Lahmacun"] * adet;
                urunAdetleri["Lahmacun"] = adet;
            }
            if (checkBoxIskender.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender.Text);
                toplamFiyat += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
            }
            if (checkBoxDoner.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner.Text);
                toplamFiyat += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
            }
            if (checkBoxMakarna.Checked)
            {
                int adet = Convert.ToInt32(textBoxMakarna.Text);
                toplamFiyat += urunFiyatlari["Makarna"] * adet;
                urunAdetleri["Makarna"] = adet;
            }
            if (checkBoxPasta.Checked)
            {
                int adet = Convert.ToInt32(textBoxPasta.Text);
                toplamFiyat += urunFiyatlari["Pasta"] * adet;
                urunAdetleri["Pasta"] = adet;
            }
            if (checkBoxKunefe.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe.Text);
                toplamFiyat += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
            }
            label1.Text = $"Toplam Fiyat: {toplamFiyat} TL";
            foreach (var urun in urunAdetleri)
            {
                listBox1.Items.Add($"{urun.Key}: {urun.Value} adet");
            }








        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ürünlerin fiyatlarini tutacak dictionary
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Gazoz", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Lahmacun", 25.0m);
            urunFiyatlari.Add("İskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Makarna", 25.0m);
            urunFiyatlari.Add("Pasta", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);


            // Ürünlerin adetlerini tutacak dictionary
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Gazoz", 0);
            urunAdetleri.Add("Fanta", 0);
            urunAdetleri.Add("Çay", 0);
            urunAdetleri.Add("Lahmacun", 0);
            urunAdetleri.Add("İskender", 0);
            urunAdetleri.Add("Döner", 0);
            urunAdetleri.Add("Makarna", 0);
            urunAdetleri.Add("Pasta", 0);
            urunAdetleri.Add("Künefe", 0);


            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için degisken
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola2.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola2.Text);
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxGazoz2.Checked)
            {
                int adet = Convert.ToInt32(textBoxGazoz2.Text);
                toplamFiyat += urunFiyatlari["Gazoz"] * adet;
                urunAdetleri["Gazoz"] = adet;
            }

            if (checkBoxFanta2.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta2.Text);
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay2.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay2.Text);
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxLahmacun2.Checked)
            {
                int adet = Convert.ToInt32(textBoxLahmacun2.Text);
                toplamFiyat += urunFiyatlari["Lahmacun"] * adet;
                urunAdetleri["Lahmacun"] = adet;
            }
            if (checkBoxIskender2.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender2.Text);
                toplamFiyat += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
            }
            if (checkBoxDoner2.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner2.Text);
                toplamFiyat += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
            }
            if (checkBoxMakarna2.Checked)
            {
                int adet = Convert.ToInt32(textBoxMakarna2.Text);
                toplamFiyat += urunFiyatlari["Makarna"] * adet;
                urunAdetleri["Makarna"] = adet;
            }
            if (checkBoxPasta2.Checked)
            {
                int adet = Convert.ToInt32(textBoxPasta2.Text);
                toplamFiyat += urunFiyatlari["Pasta"] * adet;
                urunAdetleri["Pasta"] = adet;
            }
            if (checkBoxKunefe2.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe2.Text);
                toplamFiyat += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ürünlerin fiyatlarini tutacak dictionary
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Gazoz", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Lahmacun", 25.0m);
            urunFiyatlari.Add("İskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Makarna", 25.0m);
            urunFiyatlari.Add("Pasta", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);


            // Ürünlerin adetlerini tutacak dictionary
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Gazoz", 0);
            urunAdetleri.Add("Fanta", 0);
            urunAdetleri.Add("Çay", 0);
            urunAdetleri.Add("Lahmacun", 0);
            urunAdetleri.Add("İskender", 0);
            urunAdetleri.Add("Döner", 0);
            urunAdetleri.Add("Makarna", 0);
            urunAdetleri.Add("Pasta", 0);
            urunAdetleri.Add("Künefe", 0);


            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için degisken
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola3.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola3.Text);
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxGazoz3.Checked)
            {
                int adet = Convert.ToInt32(textBoxGazoz3.Text);
                toplamFiyat += urunFiyatlari["Gazoz"] * adet;
                urunAdetleri["Gazoz"] = adet;
            }

            if (checkBoxFanta3.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta3.Text);
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay3.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay3.Text);
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxLahmacun3.Checked)
            {
                int adet = Convert.ToInt32(textBoxLahmacun3.Text);
                toplamFiyat += urunFiyatlari["Lahmacun"] * adet;
                urunAdetleri["Lahmacun"] = adet;
            }
            if (checkBoxIskender3.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender3.Text);
                toplamFiyat += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
            }
            if (checkBoxDoner3.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner3.Text);
                toplamFiyat += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
            }
            if (checkBoxMakarna3.Checked)
            {
                int adet = Convert.ToInt32(textBoxMakarna3.Text);
                toplamFiyat += urunFiyatlari["Makarna"] * adet;
                urunAdetleri["Makarna"] = adet;
            }
            if (checkBoxPasta3.Checked)
            {
                int adet = Convert.ToInt32(textBoxPasta3.Text);
                toplamFiyat += urunFiyatlari["Pasta"] * adet;
                urunAdetleri["Pasta"] = adet;
            }
            if (checkBoxKunefe3.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe3.Text);
                toplamFiyat += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ürünlerin fiyatlarini tutacak dictionary
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Gazoz", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Lahmacun", 25.0m);
            urunFiyatlari.Add("İskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Makarna", 25.0m);
            urunFiyatlari.Add("Pasta", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);


            // Ürünlerin adetlerini tutacak dictionary
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Gazoz", 0);
            urunAdetleri.Add("Fanta", 0);
            urunAdetleri.Add("Çay", 0);
            urunAdetleri.Add("Lahmacun", 0);
            urunAdetleri.Add("İskender", 0);
            urunAdetleri.Add("Döner", 0);
            urunAdetleri.Add("Makarna", 0);
            urunAdetleri.Add("Pasta", 0);
            urunAdetleri.Add("Künefe", 0);


            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için degisken
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola4.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola4.Text);
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxGazoz4.Checked)
            {
                int adet = Convert.ToInt32(textBoxGazoz4.Text);
                toplamFiyat += urunFiyatlari["Gazoz"] * adet;
                urunAdetleri["Gazoz"] = adet;
            }

            if (checkBoxFanta4.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta4.Text);
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay4.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay4.Text);
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxLahmacun4.Checked)
            {
                int adet = Convert.ToInt32(textBoxLahmacun4.Text);
                toplamFiyat += urunFiyatlari["Lahmacun"] * adet;
                urunAdetleri["Lahmacun"] = adet;
            }
            if (checkBoxIskender4.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender4.Text);
                toplamFiyat += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
            }
            if (checkBoxDoner4.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner4.Text);
                toplamFiyat += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
            }
            if (checkBoxMakarna4.Checked)
            {
                int adet = Convert.ToInt32(textBoxMakarna4.Text);
                toplamFiyat += urunFiyatlari["Makarna"] * adet;
                urunAdetleri["Makarna"] = adet;
            }
            if (checkBoxPasta4.Checked)
            {
                int adet = Convert.ToInt32(textBoxPasta4.Text);
                toplamFiyat += urunFiyatlari["Pasta"] * adet;
                urunAdetleri["Pasta"] = adet;
            }
            if (checkBoxKunefe4.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe4.Text);
                toplamFiyat += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Ürünlerin fiyatlarini tutacak dictionary
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Gazoz", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Lahmacun", 25.0m);
            urunFiyatlari.Add("İskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Makarna", 25.0m);
            urunFiyatlari.Add("Pasta", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);


            // Ürünlerin adetlerini tutacak dictionary
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Gazoz", 0);
            urunAdetleri.Add("Fanta", 0);
            urunAdetleri.Add("Çay", 0);
            urunAdetleri.Add("Lahmacun", 0);
            urunAdetleri.Add("İskender", 0);
            urunAdetleri.Add("Döner", 0);
            urunAdetleri.Add("Makarna", 0);
            urunAdetleri.Add("Pasta", 0);
            urunAdetleri.Add("Künefe", 0);


            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için degisken
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola5.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola5.Text);
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxGazoz5.Checked)
            {
                int adet = Convert.ToInt32(textBoxGazoz5.Text);
                toplamFiyat += urunFiyatlari["Gazoz"] * adet;
                urunAdetleri["Gazoz"] = adet;
            }

            if (checkBoxFanta5.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta5.Text);
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay5.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay5.Text);
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxLahmacun5.Checked)
            {
                int adet = Convert.ToInt32(textBoxLahmacun5.Text);
                toplamFiyat += urunFiyatlari["Lahmacun"] * adet;
                urunAdetleri["Lahmacun"] = adet;
            }
            if (checkBoxIskender5.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender5.Text);
                toplamFiyat += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
            }
            if (checkBoxDoner5.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner5.Text);
                toplamFiyat += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
            }
            if (checkBoxMakarna5.Checked)
            {
                int adet = Convert.ToInt32(textBoxMakarna5.Text);
                toplamFiyat += urunFiyatlari["Makarna"] * adet;
                urunAdetleri["Makarna"] = adet;
            }
            if (checkBoxPasta5.Checked)
            {
                int adet = Convert.ToInt32(textBoxPasta5.Text);
                toplamFiyat += urunFiyatlari["Pasta"] * adet;
                urunAdetleri["Pasta"] = adet;
            }
            if (checkBoxKunefe5.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe5.Text);
                toplamFiyat += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
            }
        }
    }
}
