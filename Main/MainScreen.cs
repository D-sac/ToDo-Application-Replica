using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.entity;
using Main.Migrations;
using Main.StaticForm;

namespace Main
{
    public partial class MainScreen : Form
    {
        public string UserLogin;
        public string SessionUserLoginName { get => UserLogin; set => UserLogin = value; }

        Context context = new Context();
        public MainScreen()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        void SendMail()
        {
            string Mail = context.dbUsers
            .Where(x => x.ad == SessionUserLoginName)
            .Select(x => x.mail)
            .FirstOrDefault();

            MailMessage Message = new MailMessage();
            SmtpClient Client = new SmtpClient();

            Message.From = new MailAddress("ToDodeneme@hotmail.com");
            Message.Subject = "Hoşgeldin";
            Message.Body = "Deneme1";
            Message.To.Add(Mail);

            Client.Credentials = new System.Net.NetworkCredential("ToDodeneme@hotmail.com", "deneme4545");
            Client.Port = 587;
            Client.Host = "smtp.live.com";
            Client.EnableSsl = true;
            Client.Send(Message);
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            var ContentID = context.dbContents
                .Where(x => x.dbCategory.User.ad == UserLogin)
                .Select(x => x.conID)
                .ToList();

            var ContentName = context.dbContents
                .Where(x => x.dbCategory.User.ad == UserLogin)
                .Select(x => x.conName)
                .ToList();

            var GetTableCategory = context.dbCategories
                .Include(x => x.User)
                .Where(x => x.User.ad == SessionUserLoginName)
                .ToList();

            var CName = context.dbCategories
               .Where(o => o.User.ad == SessionUserLoginName)
               .ToList();

            var ButtonCount = CName.Count();
            int ContentIDCount = ContentID.Count();

            for (int i = 0; i < ButtonCount; i++)
            {
                string cname = CName[i].cName;
                Label CategoryName = new Label();
                CategoryName.Text = cname;
                CategoryName.Width = 180;
                CategoryName.BorderStyle = BorderStyle.FixedSingle;
                CategoryName.TextAlign = ContentAlignment.MiddleCenter;
                CategoryName.BackColor = Color.White;
                CategoryName.ForeColor = Color.Black;
                Categories.Controls.Add(CategoryName);
                CategoryName.DoubleClick += new EventHandler(GetCategoryClick);

                for (int j = 0; j < ContentIDCount; j++)
                {


                }
            }
            SendMail();
        }

        private void GetCategoryClick(object sender, EventArgs e)
        {
            Label CategoryNameLabel = new Label();
            ContentUI ContentUI = new ContentUI();
            CategoryNameLabel.Text = sender.ToString();
            string CategoryName = CategoryNameLabel.Text.Substring(34);

            ContentUI.GetCategoryName = CategoryName;
            ContentUI.UserLogin = UserLogin;

            ContentUI.MdiParent = this;
            ContentUI.Show();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dbCategory CategoryInputName = new dbCategory()
            {
                cName = txtCategoryName.Text,
                UserID = context.dbUsers
                .Where(x => x.ad == SessionUserLoginName)
                .Select(x => x.id)
                .FirstOrDefault()
            };

            context.dbCategories.Add(CategoryInputName);
            context.SaveChanges();

            Label CategoryName = new Label();
            CategoryName.Text = txtCategoryName.Text;
            CategoryName.Width = 180;
            CategoryName.BorderStyle = BorderStyle.FixedSingle;
            CategoryName.TextAlign = ContentAlignment.MiddleCenter;
            CategoryName.BackColor = Color.White;
            CategoryName.ForeColor = Color.Black;
            Categories.Controls.Add(CategoryName);

            CategoryName.DoubleClick += new EventHandler(GetCategoryClick);
        }
    }
}
