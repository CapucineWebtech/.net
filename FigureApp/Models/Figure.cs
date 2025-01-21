namespace FigureApp.Models
{
    public class Figure
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public decimal Size { get; set; }
        public string Color { get; set; } = "000000";
    }
}
