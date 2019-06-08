using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.DataModel
{
    [Table("ArticleCommonTable")]
    public class Article
    {
        [Key]
        public int ID { get; set; }

        [Column("ArticleTitle")]
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Column("Type")]
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [ForeignKey("ArticleFirstType")]
        public virtual ArticleFirstType ArticleFirstType { get; set; }

        [ForeignKey("ArticleSecondType")]
        public virtual ArticleSecondType ArticleSecondType { get; set; }
    }
}
