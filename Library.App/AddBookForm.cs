using Library.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.App
{
    public partial class AddBookForm : Form
    {
        LibraryContext LibContext;
        public AddBookForm()
        {
            LibContext = new LibraryContext();
            InitializeComponent();
        }
        private void populate_categoryComboBox()
        {
            LibContext.Categories.Load();

            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Title";
            categoryComboBox.DataSource = LibContext.Categories.Local.ToBindingList();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            populate_categoryComboBox();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Add TO DB Logic
        }
    }
}
