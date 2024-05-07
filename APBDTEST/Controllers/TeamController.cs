using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using APBDTEST.Models.DTOs;
using APBDTEST.Repositories;

namespace APBDTEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;

        public TeamController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamMemberAndTasks(int id)
        {
            try
            {
                var memberAndTasks = await _teamRepository.GetMemberAndTasks(id);

                if (memberAndTasks == null)
                    return NotFound($"Team member with ID - {id} not found");

                return Ok(memberAndTasks);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectAndTasks(int id)
        {
            try
            {
                using (var transaction = await _teamRepository.BeginTransactionAsync())
                {
                    var projectExists = await _teamRepository.ProjectExists(id);
                    if (!projectExists)
                        return NotFound($"Project with ID - {id} not found");

                    await _teamRepository.DeleteProjectAndTasks(id);

                    transaction.Complete();

                    return NoContent();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

    }
}