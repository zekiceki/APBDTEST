using System;
using System.Threading.Tasks;
using System.Transactions;
using APBDTEST.Models.DTOs;

namespace APBDTEST.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        

        public async Task<MemberAndTasksDTO> GetMemberAndTasks(int memberId)
        {
            
            throw new NotImplementedException();
        }

        public async Task<bool> ProjectExists(int projectId)
        {
            
            throw new NotImplementedException();
        }

        public async Task DeleteProjectAndTasks(int projectId)
        {
            
            throw new NotImplementedException();
        }

        public async Task<TransactionScope> BeginTransactionAsync()
        {
            
            throw new NotImplementedException();
        }
    }
}