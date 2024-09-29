using Microsoft.AspNetCore.Mvc;
using VisualAcademy.Models;
using VisualAcademy.Services;

namespace VisualAcademy.Controllers
{
    [Route("api/branches")]
    [ApiController]
    public class BranchesServicesController : ControllerBase
    {
        private readonly BranchService _service;

        public BranchesServicesController(BranchService service)
        {
            _service = service;
        }

        // Get all branches
        [HttpGet]
        public async Task<IActionResult> GetAllBranches()
        {
            var branches = await _service.GetAllBranches();
            return Ok(branches);
        }

        // Create a new branch
        [HttpPost]
        public async Task<IActionResult> CreateBranch([FromBody] Branch branch)
        {
            if (ModelState.IsValid)
            {
                await _service.AddBranch(branch);
                return Ok();
            }
            return BadRequest();
        }

        // Get a branch by id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBranchById(int id)
        {
            var branch = await _service.GetBranchById(id);
            if (branch == null)
            {
                return NotFound();
            }
            return Ok(branch);
        }

        // Edit a branch
        [HttpPut("{id}")]
        public async Task<IActionResult> EditBranch(int id, [FromBody] Branch branch)
        {
            if (id != branch.Id || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _service.UpdateBranch(branch);
            return Ok();
        }

        // Delete a branch
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            await _service.DeleteBranch(id);
            return Ok();
        }
    }
}
