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
            var GetCategoryID = Context.dbCategories
                .Where(x => x.User.ad == UserLogin)
                .Select(x => x.cID)
                .ToList();
            //Categori isimleri'nin hepsi geliyor!
            var GetContentName = Context.dbContents
                .Where(x => x.dbCategory.User.ad == UserLogin)
                .Select(x => x.conName)
                .ToList();

            var GetContentID = Context.dbContents
                .Where(x => x.dbCategory.User.ad == UserLogin)
                .Select(x => x.conID)
                .ToList();

            var SetCategoryID = GetCategoryID.Count();

            var SetContentName = GetContentName.Count();

            var SetContentID = GetContentID.Count();

            for (int j = 0; j < SetContentName; j++)
            {
                string ContentName = GetContentName[j];
                string ContentID = GetContentID[j].ToString();
                string CategoryID = GetCategoryID[j].ToString();
                Label ContentLabel = new Label();
                ContentLabel.Text = ContentName;
                ContentLabel.AccessibleDefaultActionDescription = ContentID;
                ContentLabel.AccessibleDescription = CategoryID;
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
            ContentInsertUI ContentInsert = new ContentInsertUI();
            Label ContentLabel = (Label)sender;

            ContentInsert.SetContentID = ContentLabel.AccessibleDefaultActionDescription;
            ContentInsert.SetCategoryID = ContentLabel.AccessibleDescription;
            ContentInsert.GetContentNameText = ContentLabel.Text;
            ContentInsert.GetCategoryName = GetSetCategoryName;
            ContentInsert.SessionUserLoginName = SessionUserLoginName;
            ContentInsert.Show();
        }

        private void btnContentAdd_Click(object sender, EventArgs e)
        {
            dbContent dbContent = new dbContent()
            {
                conName = txtContent.Text,
                CategoryID = Context.dbCategories
                .Where(x => x.cName == GetCategoryName)
                .Select(x => x.cID)
                .FirstOrDefault(),
                conYear = DateTime.Now
            };

            Context.dbContents.Add(dbContent);
            Context.SaveChanges();

            var GetCategoryID = Context.dbContents
                .Where(x => x.dbCategory.cName == GetCategoryName)
                .Select(x => x.CategoryID)
                .FirstOrDefault();

            var ContentName = Context.dbContents
                .Where(x => x.conName == txtContent.Text)
                .Select(x => x.conName)
                .FirstOrDefault();

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
}
