namespace APBDTEST.Models.DTOs
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string ProjectName { get; set; }
        public string TaskType { get; set; }
        
    }
}