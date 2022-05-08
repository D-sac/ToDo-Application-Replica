using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.entity;

namespace Main.StaticForm
{
    public partial class ContentUI : Form
    {
        Context Context = new Context();
        public string GetCategoryName;
        public string GetSetCategoryName { get => GetCategoryName; set => GetCategoryName = value; }
        public string UserLogin;
        public string SessionUserLoginName { get => UserLogin; set => UserLogin = value; }
        public ContentUI()
        {
            InitializeComponent();
        }

        private void ContentUI_Load(object sender, EventArgs e)
        {
            var GetContentName = Context.dbContents
                .Where(w => w.dbCategory.User.ad == SessionUserLoginName
                &&
                w.dbCategory.cName == GetSetCategoryName)
                .Select(w => w.conName)
                .ToList();

            var SetContentName = GetContentName.Count();

            for (int j = 0; j < SetContentName; j++)
            {
                string ContentName = GetContentName[j];
                Label ContentLabel = new Label();
                ContentLabel.Text = ContentName;
                ContentLabel.Width = 480;
                ContentLabel.Height = 25;
                ContentLabel.TextAlign = ContentAlignment.MiddleCenter;
                ContentLabel.BackColor = Color.White;
                ContentLabel.ForeColor = Color.Black;
                ContentList.Controls.Add(ContentLabel);
                ContentLabel.DoubleClick += new EventHandler(ContentLabelDoubleClick);
            }
        }
        private void ContentLabelDoubleClick(object sender, EventArgs e)
        {
            ContentInsertUI ContentInsertUI = new ContentInsertUI();
            Label ContentLabel = new Label();
            ContentLabel.Text = sender.ToString();
            string Content = ContentLabel.Text.Substring(34);

            ContentInsertUI.GetContentNameText = Content;
            ContentInsertUI.GetCategoryName = GetSetCategoryName;
            ContentInsertUI.SessionUserLoginName = SessionUserLoginName;

            ContentInsertUI.Show();
        }

        private void btnContentAdd_Click(object sender, EventArgs e)
        {
            dbContent dbContent = new dbContent()
            {
                conName = txtContent.Text,
                CategoryID = Context.dbContents
                .Where(w => w.dbCategory.User.ad == SessionUserLoginName
                &&
                w.dbCategory.cName == GetSetCategoryName)
                .Select(w => w.dbCategory.cID)
                .FirstOrDefault(),
                conYear = DateTime.Now
            };

            Context.dbContents.Add(dbContent);
            Context.SaveChanges();

            var GetCategoryID = Context.dbContents
                .Where(w => w.dbCategory.User.ad == SessionUserLoginName
                &&
                w.dbCategory.cName == GetSetCategoryName)
                .Select(w => w.CategoryID)
                .FirstOrDefault();

            var ContentNameMirroring = Context.dbContents
                .Where(w => w.dbCategory.User.ad == SessionUserLoginName
                &&
                w.dbCategory.cName == GetSetCategoryName
                &&
                w.conID == GetCategoryID)
                .Select(w => w.conName)
                .DefaultIfEmpty()
                .FirstOrDefault();

            Label ContentLabel = new Label();
            ContentLabel.Text = ContentNameMirroring;
            ContentLabel.Width = 480;
            ContentLabel.Height = 25;
            ContentLabel.TextAlign = ContentAlignment.MiddleCenter;
            ContentLabel.BackColor = Color.White;
            ContentLabel.ForeColor = Color.Black;
            ContentList.Controls.Add(ContentLabel);
        }
    }
}
