using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblValidationState")]
    public class ValidationState
    {
        public int UserId { get; set; }
        public int DeceasedId { get; set; }
        public string FileUrl { get; set; }
        public Nullable<Boolean> State { get; set; }
        public DateTime ValidationDate { get; set; }
    }
}
