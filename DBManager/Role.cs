using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblRole")]
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
