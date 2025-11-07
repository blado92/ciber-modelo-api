using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblAccessLevel")]
    public class AccessLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
