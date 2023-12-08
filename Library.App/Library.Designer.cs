using Library.Data;
using Library.Domain;

namespace Library.App
{
    partial class Library
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryLabel = new System.Windows.Forms.Label();
            this.libraryContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AccessibleName = "categoryComboBox";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(113, 76);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(311, 33);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedValueChanged += new System.EventHandler(this.categoryComboBox_SelectedValueChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AccessibleName = "titleLabel";
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(113, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 41);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Library System ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1606, 513);
            this.dataGridView1.TabIndex = 3;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AccessibleName = "categoryLabel";
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 79);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(88, 25);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category:";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 650);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "Library";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryContextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox categoryComboBox;
        private Label titleLabel;
        private DataGridView dataGridView1;
        private Label categoryLabel;
        private DataGridViewTextBoxColumn BookTitle;
        private DataGridViewTextBoxColumn BookISBN;
        private DataGridViewTextBoxColumn BookAuthor;
        private DataGridViewTextBoxColumn BookPublishDate;
        private DataGridViewTextBoxColumn BookPrice;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn categoriesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn booksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contextIdDataGridViewTextBoxColumn;
        private BindingSource libraryContextBindingSource;
    }
}