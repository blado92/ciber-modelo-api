using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblAccessMatrix")]
    public class AccessMatrix
    {
        public int RoleId { get; set; }
        public int QueryTypeId { get; set; }
        public int AccessLevelId { get; set; }
    }
}
