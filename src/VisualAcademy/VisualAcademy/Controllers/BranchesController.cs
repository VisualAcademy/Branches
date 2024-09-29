using Microsoft.AspNetCore.Mvc;
using VisualAcademy.Models;
using VisualAcademy.Services;

namespace VisualAcademy.Controllers
{
    [Route("Branches")]
    public class BranchesController : Controller
    {
        private readonly BranchService _service;

        public BranchesController(BranchService service)
        {
            _service = service;
        }

        // Index 액션: 지점 목록을 보여주는 페이지
        public async Task<IActionResult> Index()
        {
            var branches = await _service.GetAllBranches();
            return View(branches);  // Index.cshtml 뷰를 렌더링
        }
    }
}
