namespace APBDTEST.Models.DTOs
{
    public class MemberAndTasksDTO
    {
        public MemberDTO Member { get; set; }
        public List<TaskDTO> AssignedTasks { get; set; }
        public List<TaskDTO> CreatedTasks { get; set; }
    }
}