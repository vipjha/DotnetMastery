using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class EmpLeave
    {
        public int LeaveId { get; set; }
        public string LeaveType { get; set; }
        public DateTime LeaveDate { get; set; }
        public int EmpId { get; set; }
        [ForeignKey("EmpId")]
        public Employee Employee { get; set; }
    }
}
