namespace APBDTEST.Models.DTOs
{
    public class NewTaskDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int ProjectId { get; set; }
        public string TaskType { get; set; }
        
    }
}