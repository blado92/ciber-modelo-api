using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblFieldAccessLevel")]
    public class FieldAccessLevel
    {
        public int QueryTypeId { get; set; }
        public int AccessLevelId { get; set; }
        public int FieldId { get; set; }
    }
}
