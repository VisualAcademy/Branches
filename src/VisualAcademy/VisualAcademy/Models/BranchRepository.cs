using Microsoft.EntityFrameworkCore;
using VisualAcademy.Data;

namespace VisualAcademy.Models
{
    public class BranchRepository : IBranchRepository
    {
        private readonly ApplicationDbContext _context;

        public BranchRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Branch>> GetAllBranches()
        {
            return await _context.Branches.ToListAsync();
        }

        public async Task<Branch> GetBranchById(int id)
        {
            return await _context.Branches.FindAsync(id);
        }

        public async Task AddBranch(Branch branch)
        {
            _context.Branches.Add(branch);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBranch(Branch branch)
        {
            _context.Branches.Update(branch);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBranch(int id)
        {
            var branch = await _context.Branches.FindAsync(id);
            if (branch != null)
            {
                _context.Branches.Remove(branch);
                await _context.SaveChangesAsync();
            }
        }
    }
}
