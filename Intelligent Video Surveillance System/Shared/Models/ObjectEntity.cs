namespace Intelligent_Video_Surveillance_System.Shared.Models;
public class ObjectEntity : BaseEntity
{
    public ObjectType Type { get; set; }
}

public enum ObjectType
{
    keyboard, mouse, monitor, desktop
};