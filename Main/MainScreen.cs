using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.entity;
using Main.Migrations;

namespace Main
{
    public partial class MainScreen : Form
    {
        Context context = new Context();

        public MainScreen()
        {
            InitializeComponent();
        }
        public string UserLogin;
        public string SessionUserLoginName { get => UserLogin; set => UserLogin = value; }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            var query1 = context.dbCategories
                .Include(x => x.User)
                .Where(x => x.User.ad == SessionUserLoginName)
                .ToList();

            dataGridView1.DataSource = query1.ToList();

            var CName = context.dbCategories
               .Where(o => o.User.ad == SessionUserLoginName).ToList();
            var ButtonCount = CName.Count();

            for (int i = 0; i < ButtonCount; i++)
            {
                string cname = CName[i].cName;
                ToolTip ToolTip = new ToolTip();
                Label CategoryName = new Label();
                ToolTip.SetToolTip(CategoryName, "deneme");
                CategoryName.Text = cname;
                CategoryName.ContextMenuStrip = BtnDescription;
                CategoryName.Width = 180;
                CategoryName.BorderStyle = BorderStyle.FixedSingle;
                CategoryName.TextAlign = ContentAlignment.MiddleCenter;
                CategoryName.BackColor = Color.White;
                CategoryName.ForeColor = Color.Black;
                Categories.Controls.Add(CategoryName);

            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dbCategory CategoryInputName = new dbCategory()
            {
                cName = txtCategoryName.Text,
                UserID = context.dbCategories
                  .Where(x => x.User.ad == SessionUserLoginName)
                  .Select(x => x.User.id).FirstOrDefault()
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
        }

        private void açıklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var UserIDTransfer = context.dbCategories
                .Where(x => x.User.ad == SessionUserLoginName)
                .Select(x => x.UserID)
                .FirstOrDefault();
            var CategoryTransfer = context.dbCategories
                .Where(x => x.User.id == UserIDTransfer)
                .Select(x => x.cName)
                .ToList()
                .ToString();
            DescriptionPanel DescriptionPanel = new DescriptionPanel();
            DescriptionPanel.SessionUserID = UserIDTransfer;
            DescriptionPanel.SessionCategoryName = CategoryTransfer;
            DescriptionPanel.Show();
        }
    }
}
