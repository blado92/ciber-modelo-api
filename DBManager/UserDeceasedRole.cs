using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblUserDeceasedRole")]
    public class UserDeceasedRole
    {
        public int UserId { get; set; }
        public int DeceasedId { get; set; }
        public int RoleId { get; set; }
    }
}
