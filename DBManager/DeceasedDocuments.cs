using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblDeceasedDocuments")]
    public class DeceasedDocuments
    {
        public int Id { get; set; }
        public int DeceasedId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }
}
