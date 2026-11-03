namespace ProyectoG4Backend.Models;

public class TaskItem
{
    public string Id { get; set; } = string.Empty;
    
    public string Title { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public string Priority { get; set; } = "media";
    
    public string UserId { get; set; } = string.Empty;
    
    public string CreatedAt { get; set; } = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
}