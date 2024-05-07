using System.Threading.Tasks;
using System.Transactions;
using APBDTEST.Models.DTOs;

namespace APBDTEST.Repositories
{
    public interface ITeamRepository
    {
        Task<MemberAndTasksDTO> GetMemberAndTasks(int memberId);
        Task<bool> ProjectExists(int projectId);
        Task DeleteProjectAndTasks(int projectId);
        Task<TransactionScope> BeginTransactionAsync();
    }
}