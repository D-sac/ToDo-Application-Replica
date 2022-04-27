using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.entity;

namespace Main
{
    public partial class UserLogin : Form
    {
        Context context = new Context();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            var user = username.Text;
            var pass = userpass.Text;

            MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider();

            byte[] md5Array = mD5.ComputeHash(Encoding.UTF8.GetBytes(pass));

            StringBuilder @string = new StringBuilder();

            foreach ( var ens in md5Array)
            {
                @string.Append(ens.ToString("x2").ToLower());
            }

            pass = @string.ToString();

            var UserName = context.dbUsers.Where(context => context.ad == user).Count();

           
            var UserPassword = context.dbUsers.Where(context => context.ad == user)
            .Select(context => context.sifre).FirstOrDefault();

            bool verificationAd = string.IsNullOrEmpty(username.Text);
            bool verificationSifre = string.IsNullOrEmpty(userpass.Text);

            if (UserName < 1 || pass != UserPassword || verificationAd == true || verificationSifre == true)
            {
                label3.Text = "Kullanıcı adı hatalı veya boş!";
                label4.Text = "Şifre hatalı veya boş!";
                username.Clear();
                userpass.Clear();
            }
            else
            {
                MainScreen mainScreen = new MainScreen();

                mainScreen.SessionUserLoginName = username.Text;

                this.Hide();

                mainScreen.Show();
            }
        }
    }
}
