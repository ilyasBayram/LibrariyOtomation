using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrariyOtomation
{
    public partial class BookSave : Form
    {
        public BookSave()
        {
            InitializeComponent();
        }

        DbLibraryOtomationEntities2 db = new DbLibraryOtomationEntities2();

        void CmBoxPublishNameFill()
        {
            var query = from item in db.TblPublisher select new { item.PublisherName, item.PublisherID };

            cmBoxPublisherName.DataSource = query.ToList();
            cmBoxPublisherName.DisplayMember = "PublisherName";
            cmBoxPublisherName.ValueMember = "PublisherID";
            cmBoxPublisherName.SelectedIndex = -1;
        }

        private void BookSave_Load(object sender, EventArgs e)
        {
            cmBoxBookStuation.SelectedIndex = 0;

            CmBoxPublishNameFill(); 
            
        }

        private void cmBoxPublisherName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
