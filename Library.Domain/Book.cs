namespace Library.Domain
{
    public class Book
    {
        public string BookId { get; set; }
        public string BookISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal BasePrice { get; set; }
        public string Author { get; set; }
        public Category Category { get; set; }
    }
}