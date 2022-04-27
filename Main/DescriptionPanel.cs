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

namespace Main
{
    public partial class DescriptionPanel : Form
    {
        Context contex = new Context();
        public DescriptionPanel()
        {
            InitializeComponent();
        }
        public int UserID;
        public int SessionUserID { get => UserID; set => UserID = value; }

        public string CategoryName;
        public string SessionCategoryName { get => CategoryName; set => CategoryName = value; }
        private void DescriptionPanel_Load(object sender, EventArgs e)
        {
            var VerificationGetDescription = contex.dbCategories
                .Where(x => x.User.id == SessionUserID)
                .Where(x => x.cName == SessionCategoryName)
                .Select(x => x.description).FirstOrDefault();

            RichDescription.Text = VerificationGetDescription;
        }
    }
}
