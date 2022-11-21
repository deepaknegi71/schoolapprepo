using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace amitranetapi.Entities
{
    [Table("School")]
    public class School
    {
        [Key,Required]
        public int id { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string name { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string short_name { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string description { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string affiliation { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string phone { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string photo_path { get; set; }
        public int organization_id { get; set; }
        public DateTime establish_date { get; set; }
        public DateTime access_expired_date { get; set; }
        public bool active { get; set; }
        public Int64 created_by { get; set; }
        public DateTime created_on { get; set; }
        public Int64 modified_by { get; set; }
        public DateTime modified_on { get; set; }

    }
}
