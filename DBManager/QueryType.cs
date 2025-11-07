using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblQueryType")]
    public class QueryType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
