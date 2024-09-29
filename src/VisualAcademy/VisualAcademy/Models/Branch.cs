using System.ComponentModel.DataAnnotations;

namespace VisualAcademy.Models
{
    public class Branch
    {
        public int Id { get; set; }               // 자동 증가하는 고유 ID
        [Required]
        public string BranchName { get; set; } = null!;   // 지점 이름
        public string Location { get; set; } = null!;      // 지점 위치
        public string ContactNumber { get; set; } = null!; // 지점 연락처
        public DateTime EstablishedDate { get; set; } // 지점 설립일
        public bool IsActive { get; set; }        // 지점 활성 상태
    }
}
