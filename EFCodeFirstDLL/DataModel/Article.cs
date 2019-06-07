using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public int ArticleFirstTypeFK { get; set; }
        [ForeignKey("ArticleFirstType")]
        public virtual ArticleFirstType ArticleFirstType { get; set; }

        //public int ArticleSecondTypeFK { get; set; }
        [ForeignKey("ArticleSecondType")]
        public virtual ArticleSecondType ArticleSecondType { get; set; }
    }
}
