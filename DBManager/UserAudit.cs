using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblUserAudit")]
    public class UserAudit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public Nullable<int> DeceasedId { get; set; }
        public string EventDescription { get; set; }
        public DateTime Created { get; set; }
    }
}
