namespace sharpChores.Models;

public class Chore
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Color { get; set; }
    public string CompletionDate { get; set; }

    public Chore(int id, string title, string color, string completionDate)
    {
        Id = id;
        Title = title;
        Color = color;
        CompletionDate = completionDate;
    }
}