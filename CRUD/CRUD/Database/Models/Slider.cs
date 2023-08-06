namespace CRUD.Database.Models;

public class Slider
{
    public Slider(string title, string description, string image, string button, int order)
    {
        Title = title;
        Description = description;
        Image = image;
        Button = button;
        Order = order;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Button { get; set; }
    public int Order { get; set; }

}
