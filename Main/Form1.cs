using Main.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.IO;

namespace Main
{
    public partial class Form1 : Form
    {
        Context context = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            c.Database.CreateIfNotExists();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bool verificationAd = string.IsNullOrEmpty(Tad.Text);
            bool verificationYas = string.IsNullOrEmpty(Convert.ToString(Tyas.Text));
            bool verificationMail = string.IsNullOrEmpty(Tmail.Text);
            bool verificationSifre = string.IsNullOrEmpty(Tsifre.Text);
            bool verificationSifre2 = string.IsNullOrEmpty(Tsifre2.Text);

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Tmail.Text);

            MailMethod();

            if (match.Success)
            {
                if (verificationAd == true || verificationYas == true || verificationMail == true || verificationSifre == true || verificationSifre2 == true)
                {
                    labelAd.Text = "Kullanıcı Adı Boş Kalamaz!";
                    labelYas.Text = "Yaş Boş Kalamaz!";
                    labelMail.Text = "Mail Boş Kalamaz!";
                    labelSifre.Text = "Şifre Boş Kalamaz!";
                    labelSifre2.Text = "Şifre Boş Kalamaz!";
                    Tsifre.Clear();
                    Tsifre2.Clear();
                }
                else
                {
                    dbUser InsertdbUser = new dbUser()
                    {
                        ad = Tad.Text,
                        yas = Convert.ToInt32(Tyas.Text),
                        mail = Tmail.Text,
                        sifre = Tsifre.Text
                    };

                    if (InsertdbUser.sifre == Tsifre2.Text)
                    {

                        MessageBox.Show("Kayıt Başarılı..");

                        MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider();

                        byte[] md5Array = mD5.ComputeHash(Encoding.UTF8.GetBytes(InsertdbUser.sifre));

                        StringBuilder @string = new StringBuilder();

                        foreach (byte ens in md5Array)
                            @string.Append(ens.ToString("x2").ToLower());

                        InsertdbUser.sifre = @string.ToString();

                        context.dbUsers.Add(InsertdbUser);

                        context.SaveChanges();

                        UserLogin userLogin = new UserLogin();
                        this.Hide();
                        userLogin.Show();
                    }
                }
            }
            else
            {
                labelMail.Text = "Mail adresinizi kontrol ediniz..";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            this.Hide();
            userLogin.Show();
        }

        private void MailMethod() 
        {
            string DirectoryPath = @"C:\TodoSettings";
            string FilePath = @"C:\TodoSettings\MailAddress.txt";
            string FileName = "MailAddress.txt";
            string MailAddress = Tmail.Text;

            if (System.IO.Directory.Exists(DirectoryPath))
            {
                if (System.IO.File.Exists(FilePath))
                {
                    System.IO.File.WriteAllText(@"C:\TodoSettings\MailAddress.txt", MailAddress);
                }
                else
                {
                    string TargetPath = System.IO.Path.Combine(@"C:\TodoSettings", FileName);
                    System.IO.File.Create(TargetPath);

                    System.IO.File.WriteAllText(@"C:\TodoSettings\MailAddress.txt", MailAddress);
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(DirectoryPath);
                string TargetPath = System.IO.Path.Combine(@"C:\TodoSettings", FileName);
                System.IO.File.Create(TargetPath);

                System.IO.File.WriteAllText(@"C:\TodoSettings\MailAddress.txt", MailAddress);
            }
        }
    }
}