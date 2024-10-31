namespace BigFootLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        public bool IsCheckedOut { get; set; }
        public int CheckOutPersonId { get; set; }
        public DateTime DueForReturn { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string CoverImgUrl { get; set; }
    }
}
