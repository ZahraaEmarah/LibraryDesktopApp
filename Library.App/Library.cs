using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.App
{
    public partial class Library : Form
    {
        LibraryContext LibContext;
        public Library()
        {
            LibContext = new LibraryContext();
            InitializeComponent();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            LibContext.Books.Load();
            populate_categoriesComboBox();
        }

        private void populate_categoriesComboBox()
        {
            LibContext.Categories.Load();

            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Title";
            categoryComboBox.DataSource = LibContext.Categories.Local.ToBindingList();
        }
    }
}