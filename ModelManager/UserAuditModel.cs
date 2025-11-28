namespace ModelManager
{
    public class UserAuditModel
    {
        public int UserId { get; set; }
        public Nullable<int> DeceasedId { get; set; }
        public string EventDescription { get; set; }
    }
}
