namespace TakeLeaveSystem.Models
{
    public class LeaveBalance
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public User Employee { get; set; } = null!;

        public int LeaveTypeId { get; set; }

        public LeaveType LeaveType { get; set; } = null!;

        public int Year { get; set; }

        public int TotalDays { get; set; }

        public int UsedDays { get; set; }

        public int RemainingDays => TotalDays - UsedDays;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }
}
