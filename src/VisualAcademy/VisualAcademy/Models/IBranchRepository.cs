namespace VisualAcademy.Models
{
    public interface IBranchRepository
    {
        Task<IEnumerable<Branch>> GetAllBranches();
        Task<Branch> GetBranchById(int id);
        Task AddBranch(Branch branch);
        Task UpdateBranch(Branch branch);
        Task DeleteBranch(int id);
    }
}
