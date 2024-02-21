namespace BlazorApp;

public class TodoItem
{
    public string Title { get; set; }
    public bool IsDone { get; set; } = false;
    public bool IsDisabled { get; set; } = true;
}