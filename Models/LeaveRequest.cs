using System.ComponentModel.DataAnnotations;
using TakeLeaveSystem.Enums;

namespace TakeLeaveSystem.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public User Employee { get; set; } = null!;

        public int LeaveTypeId { get; set; }

        public LeaveType LeaveType { get; set; } = null!;

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public int TotalDays { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Reason { get; set; } = string.Empty;

        public LeaveRequestStatus Status { get; set; }
            = LeaveRequestStatus.Pending;

        public int? ReviewedById { get; set; }

        public User? ReviewedBy { get; set; }

        [MaxLength(1000)]
        public string? ReviewComment { get; set; }

        public DateTime? ReviewedAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }
}
