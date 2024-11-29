namespace EmployeeManagement.Models.Base
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? RemoveDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
