namespace Intelligent_Video_Surveillance_System.Shared.Models
{
    public class VideoEntity : BaseEntity
    {
        public DateTime VideoTime { get; set; }
        public string VideoPath { get; set; } = string.Empty;
        public int VideoDureation { get; set; }
    }
}
