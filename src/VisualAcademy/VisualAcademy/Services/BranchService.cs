using VisualAcademy.Models;

namespace VisualAcademy.Services
{
    public class BranchService
    {
        private readonly IBranchRepository _repository;

        public BranchService(IBranchRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Branch>> GetAllBranches()
        {
            return await _repository.GetAllBranches();
        }

        public async Task<Branch> GetBranchById(int id)
        {
            return await _repository.GetBranchById(id);
        }

        public async Task AddBranch(Branch branch)
        {
            await _repository.AddBranch(branch);
        }

        public async Task UpdateBranch(Branch branch)
        {
            await _repository.UpdateBranch(branch);
        }

        public async Task DeleteBranch(int id)
        {
            await _repository.DeleteBranch(id);
        }
    }
}
