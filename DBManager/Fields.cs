using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblFields")]
    public class Fields
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Order { get; set; }
    }
}
