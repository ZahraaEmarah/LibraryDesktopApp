namespace Library.App
{
    partial class AddBookForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.priceUpandDown = new System.Windows.Forms.NumericUpDown();
            this.dollarSignLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpandDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(33, 96);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(99, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Book Title: ";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(33, 193);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(76, 25);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(33, 243);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(115, 25);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Publish Date:";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(33, 283);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(59, 25);
            this.isbnLabel.TabIndex = 3;
            this.isbnLabel.Text = "ISBN: ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(34, 332);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(58, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price: ";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(154, 93);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(605, 31);
            this.titleTextBox.TabIndex = 5;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(154, 190);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(316, 31);
            this.authorTextBox.TabIndex = 6;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(154, 283);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(316, 31);
            this.isbnTextBox.TabIndex = 7;
            // 
            // priceUpandDown
            // 
            this.priceUpandDown.Location = new System.Drawing.Point(154, 330);
            this.priceUpandDown.Name = "priceUpandDown";
            this.priceUpandDown.Size = new System.Drawing.Size(84, 31);
            this.priceUpandDown.TabIndex = 8;
            // 
            // dollarSignLabel
            // 
            this.dollarSignLabel.AutoSize = true;
            this.dollarSignLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dollarSignLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dollarSignLabel.Location = new System.Drawing.Point(244, 332);
            this.dollarSignLabel.Name = "dollarSignLabel";
            this.dollarSignLabel.Size = new System.Drawing.Size(23, 25);
            this.dollarSignLabel.TabIndex = 9;
            this.dollarSignLabel.Text = "$";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(154, 238);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(316, 31);
            this.dateTimePicker.TabIndex = 10;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(647, 394);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(112, 34);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Book";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(33, 145);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(84, 25);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(154, 142);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(316, 33);
            this.categoryComboBox.TabIndex = 14;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
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
            this.Name = "AddBookForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceUpandDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private Label authorLabel;
        private Label dateLabel;
        private Label isbnLabel;
        private Label priceLabel;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private TextBox isbnTextBox;
        private NumericUpDown priceUpandDown;
        private Label dollarSignLabel;
        private DateTimePicker dateTimePicker;
        private Button AddBtn;
        private Label label1;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
    }
}