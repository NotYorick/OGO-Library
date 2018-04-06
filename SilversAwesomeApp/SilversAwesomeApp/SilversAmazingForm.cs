using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Library;
using Library.Models;

namespace SilversAwesomeApp
{
    public partial class SilversAmazingForm : Form
    {
        private readonly LibraryFactory _libraryFactory;
        private IEnumerable<ILibraryItem> _libraryItems;

        public SilversAmazingForm()
        {
            InitializeComponent();

            _libraryFactory = new LibraryFactory("SilversAmazingConnectionString");
            
            UpdateDataSet();

            listBox1.DataSource = _libraryItems;
            listBox1.DisplayMember = "DisplayMember";
        }

        private void UpdateDataSet()
        {
            _libraryItems = _libraryFactory.GetAllItems();
            listBox1.DataSource = _libraryItems;
        }

        #region OldStuff

        private void tabUser_Click(object sender, EventArgs e)
        {
            tabUserLbl.Text = "Button is clicked";
        }

        private void tabAdmin_Click(object sender, EventArgs e)
        {
            tabAdminlbl.Text = "Button is clicked";
        }

        private void tabAccount_Click(object sender, EventArgs e)
        {
            tabAccountLbl.Text = "Button is clicked";
        }

        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                libraryBtn.Enabled = false;
                return;
            }

            libraryBtn.Enabled = true;

            var selectedItem = (ILibraryItem)listBox1.SelectedItem;
            idTxt.Text = selectedItem.Id.ToString();
            nameTxt.Text = selectedItem.Name;
            typeTxt.Text = selectedItem.Type.ToString();
            boughtTxt.Text = selectedItem.BoughtWhen.ToString(CultureInfo.InvariantCulture);
            availableTxt.Text = selectedItem.Available.ToString();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = (ILibraryItem)listBox1.SelectedItem;
            switch (selectedItem.Available)
            {
                case true:
                    _libraryFactory.BorrowItem(selectedItem.Id);
                    break;
                case false:
                    _libraryFactory.ReturnItem(selectedItem.Id);
                    break;
            }

            UpdateDataSet();
        }

        private void SilversAmazingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
