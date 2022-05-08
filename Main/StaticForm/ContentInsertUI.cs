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
    public partial class ContentInsertUI : Form
    {
        Context Context = new Context();
        public string GetCategoryName;
        public string GetSetCategoryName { get => GetCategoryName; set => GetCategoryName = value; }
        public string UserLogin;
        public string SessionUserLoginName { get => UserLogin; set => UserLogin = value; }
        public string GetContentNameText;
        public string SetContentText { get => GetContentNameText; set => GetContentNameText = value; }
        public ContentInsertUI()
        {
            InitializeComponent();
        }

        private void ContentInsertUI_Load(object sender, EventArgs e)
        {
            var GetContent = Context.dbContents
                .Where(d => d.dbCategory.User.ad == SessionUserLoginName
                &&
                d.dbCategory.cName == GetSetCategoryName
                &&
                d.conName == SetContentText)
                .Select(d => d.con_tent)
                .ToList();

            var ContentCount = GetContent.Count();

            for (int i = 0; i < ContentCount; i++)
            {
                string Content = GetContent[i];
                Label ContentLabel = new Label();
            }
        }
    }
}
