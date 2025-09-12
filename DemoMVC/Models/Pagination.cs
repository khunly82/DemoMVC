namespace DemoMVC.Models
{
    public class Pagination
    {
        public int CurrentPage { get; set; }
        public string Controller { get; set; } = null!;
        public string Action { get; set; } = null!;
        public int PageMax { get; set; }
        public int Range { get; set; }
    }
}
