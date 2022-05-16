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

        public string CategoryID;
        public string SetCategoryID { get => CategoryID; set => CategoryID = value; }

        public string ContentID;
        public string SetContentID { get => ContentID; set => ContentID = value; }

        public ContentInsertUI()
        {
            InitializeComponent();

            this.FormClosing += TextEditor_Closing;
        }

        private void ContentInsertUI_Load(object sender, EventArgs e)
        {
            var GetCategoryID = Context.dbCategories
                .Where(x => x.cID.ToString() == CategoryID)
                .Select(x => x.cID)
                .FirstOrDefault();

            string Content = Context.dbContents
                .Where(x => x.conID.ToString() == ContentID)
                .Select(x => x.con_tent)
                .FirstOrDefault();

            TextEditor.DocumentHTML = Content;
        }

        private void TextEditor_Closing(object sender, FormClosingEventArgs e)
        {
            var dialog = MessageBox.Show("Kaydedilsin mi?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            
            if (dialog == DialogResult.Yes)
            {

                var GetContentName = Context.dbContents
                .Where(x => x.conID.ToString() == ContentID)
                .Select(x => x.conName)
                .FirstOrDefault();

                if (GetContentName == null)
                {
                    int SetCategoryID = Convert.ToInt32(CategoryID);

                    dbContent dbContent = new dbContent()
                    {
                        conName = GetContentNameText,
                        con_tent = TextEditor.DocumentHTML,
                        conYear = DateTime.Now,
                        //CategoryID = Query gelecek...
                    };

                    Context.dbContents.Add(dbContent);

                    Context.SaveChanges();
                }
                else
                {
                    using (var Context = new Context())
                    {
                        var Content = Context.dbContents
                            .Where(x => x.con_tent.Contains(x.con_tent))
                            .ToList();
                        Content.ForEach(a =>
                        {
                            a.con_tent = TextEditor.DocumentHTML;
                        }
                       );
                        Context.SaveChanges();
                    }
                }
            }
            else
            {

            }
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
