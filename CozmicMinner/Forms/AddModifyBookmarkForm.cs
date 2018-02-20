using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using DevExpress.XtraEditors;

namespace CozmicMinner.Forms
{
    using MinnerDataAccess;

    public partial class AddModifyBookmarkForm : XtraForm
    {
        public AddModifyBookmarkForm()
        {
            this.InitializeComponent();
            this.FillBookmarkCombo();
        }

        void FillControls()
        {
            var selectedBookmark = this.GetSelectedBookmark();
            this.txtBookmarkAddress.Text = selectedBookmark.BookmarkAddress;
            this.cmbBookmarkIndex.Text = selectedBookmark.BookmarkIndex.ToString();
        }

        Bookmark GetSelectedBookmark()
        {
            var RepositoryFactory = new MinnerDataFactory(new MiningDbContext());
            return
                RepositoryFactory.BookmarkRepository.Find(x => x.BookmarkAddress == this.cmbBookmarkAddress.Text);
        }

        private void cmbBookmarkAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillControls();
        }

        /// <summary>
        /// FillBookmarkCombo
        /// </summary>
        private void FillBookmarkCombo()
        {
            this.cmbBookmarkAddress.Properties.Items.Clear();
            var RepositoryFactory = new MinnerDataFactory(new MiningDbContext());
            var bookmarks = RepositoryFactory.BookmarkRepository.GetAll();
            foreach (var b in bookmarks)
            {
                this.cmbBookmarkAddress.Properties.Items.Add(b.BookmarkAddress);
            }

        }
    }
}