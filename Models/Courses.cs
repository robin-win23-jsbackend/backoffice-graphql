namespace Backoffice.Models;

public class Courses
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public decimal Price { get; set; }
    public int Hours { get; set; }
    public string? ImageUrl { get; set; }
}
