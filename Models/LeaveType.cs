using System.ComponentModel.DataAnnotations;

namespace TakeLeaveSystem.Models
{
    public class LeaveType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        public int DefaultDaysPerYear { get; set; }

        public bool IsPaid { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<LeaveRequest> LeaveRequests { get; set; }
            = new List<LeaveRequest>();

        public ICollection<LeaveBalance> LeaveBalances { get; set; }
            = new List<LeaveBalance>();
    }
}
