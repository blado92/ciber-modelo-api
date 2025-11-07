using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblFields")]
    public class Fields
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
