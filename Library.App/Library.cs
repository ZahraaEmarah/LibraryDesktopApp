using Library.Data;
using Library.Domain;
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

        private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)categoryComboBox.SelectedItem;
            
            if(selectedCategory != null)
            {
                var resultIndex = categoryComboBox.FindStringExact(selectedCategory.Title);
                if (resultIndex > -1)
                {
                    GetCategoryWithBooks(selectedCategory.Title);
                }
            }
        }

        void GetCategoryWithBooks(String TargetCategory)
        {
            using var context = new LibraryContext();
            var category = context.Categories.Include(a => a.Books).First(c => c.Title == TargetCategory);

            if(category.Books.Count > 0)
            {
                BindDataGridView(category.Books);
            }

        }

        void BindDataGridView(List<Book> books)
        {
            List<BookDTO> booksList = books.Select(book => new BookDTO
            {
                Title = book.Title,
                Author = book.Author,
                BookISBN = book.BookISBN,
                PublishDate = book.PublishDate,
                BasePrice = book.BasePrice
            }).ToList();
            dataGridView1.DataSource = booksList;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddBookForm f = new AddBookForm();
            f.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            UpdateBookForm f = new UpdateBookForm();
            f.Show();
        }
    }
}