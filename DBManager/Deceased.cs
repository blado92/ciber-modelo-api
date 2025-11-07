using System.ComponentModel.DataAnnotations.Schema;

namespace DBManager
{
    [Table("tblDeceased")]
    public class Deceased
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EPS { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DeceasedDate { get; set; }
        public DateTime Created { get; set; }
    }
}
