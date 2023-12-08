namespace Library.App
{
    partial class UpdateBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dollarSignLabel = new System.Windows.Forms.Label();
            this.priceUpandDown = new System.Windows.Forms.NumericUpDown();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.booksComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpandDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Book";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(146, 317);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(316, 31);
            this.dateTimePicker.TabIndex = 21;
            // 
            // dollarSignLabel
            // 
            this.dollarSignLabel.AutoSize = true;
            this.dollarSignLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dollarSignLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dollarSignLabel.Location = new System.Drawing.Point(236, 404);
            this.dollarSignLabel.Name = "dollarSignLabel";
            this.dollarSignLabel.Size = new System.Drawing.Size(23, 25);
            this.dollarSignLabel.TabIndex = 20;
            this.dollarSignLabel.Text = "$";
            // 
            // priceUpandDown
            // 
            this.priceUpandDown.Location = new System.Drawing.Point(146, 402);
            this.priceUpandDown.Name = "priceUpandDown";
            this.priceUpandDown.Size = new System.Drawing.Size(84, 31);
            this.priceUpandDown.TabIndex = 19;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(146, 359);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(316, 31);
            this.isbnTextBox.TabIndex = 18;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(146, 273);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(316, 31);
            this.authorTextBox.TabIndex = 17;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(146, 177);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(605, 31);
            this.titleTextBox.TabIndex = 16;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(25, 404);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(58, 25);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Price: ";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(25, 362);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(59, 25);
            this.isbnLabel.TabIndex = 14;
            this.isbnLabel.Text = "ISBN: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(25, 317);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(115, 25);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Publish Date:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(25, 276);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(76, 25);
            this.authorLabel.TabIndex = 12;
            this.authorLabel.Text = "Author: ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(25, 180);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(99, 25);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Book Title: ";
            // 
            // booksComboBox
            // 
            this.booksComboBox.FormattingEnabled = true;
            this.booksComboBox.Location = new System.Drawing.Point(236, 87);
            this.booksComboBox.Name = "booksComboBox";
            this.booksComboBox.Size = new System.Drawing.Size(453, 33);
            this.booksComboBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Choose Book:";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(661, 451);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 34);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.deleteBtn.Location = new System.Drawing.Point(543, 451);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(146, 224);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(316, 33);
            this.categoryComboBox.TabIndex = 27;
            // 
            // UpdateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.booksComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dollarSignLabel);
            this.Controls.Add(this.priceUpandDown);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBookForm";
            this.Text = "UpdateBookForm";
            this.Load += new System.EventHandler(this.UpdateBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceUpandDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label dollarSignLabel;
        private NumericUpDown priceUpandDown;
        private TextBox isbnTextBox;
        private TextBox authorTextBox;
        private TextBox titleTextBox;
        private Label priceLabel;
        private Label isbnLabel;
        private Label dateLabel;
        private Label authorLabel;
        private Label titleLabel;
        private ComboBox booksComboBox;
        private Label label2;
        private Button updateBtn;
        private Button deleteBtn;
        private Label label3;
        private ComboBox categoryComboBox;
    }
}