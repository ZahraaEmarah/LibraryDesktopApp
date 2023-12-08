using Library.Data;
using Library.Domain;
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
using System.Windows.Forms.VisualStyles;

namespace Library.App
{
    public partial class UpdateBookForm : Form
    {
        LibraryContext LibContext;
        BindingList<Book> books;
        public UpdateBookForm()
        {
            LibContext= new LibraryContext();
            InitializeComponent();
        }
        private void populate_categoryComboBox()
        {
            LibContext.Categories.Load();

            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Title";
            categoryComboBox.DataSource = LibContext.Categories.Local.ToBindingList();
        }

        private void populate_booksComboBox()
        {
            LibContext.Books.Load();

            booksComboBox.ValueMember = "BookId";
            booksComboBox.DisplayMember = "Title";
            booksComboBox.DataSource = LibContext.Books.Local.ToBindingList();
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {
            books = LibContext.Books.Local.ToBindingList();
            populate_categoryComboBox();
            populate_booksComboBox();
            bind_data();
        }

        private void bind_data()
        {
            titleTextBox.DataBindings.Add("Text", books, "Title");
            authorTextBox.DataBindings.Add("Text", books, "Author");
            isbnTextBox.DataBindings.Add("Text", books, "BookISBN");
            dateTimePicker.DataBindings.Add("Text", books, "PublishDate");
            priceUpandDown.DataBindings.Add("Text", books, "BasePrice");
            categoryComboBox.DataBindings.Add("Text", books, "Category.Title");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            LibContext.SaveChanges();
            MessageBox.Show("Updated Successfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            LibContext.Remove(booksComboBox.SelectedItem);
            booksComboBox.SelectedItem = books[0];
            LibContext.SaveChanges();
            MessageBox.Show("Deleted Successfully");
        }
    }
}
