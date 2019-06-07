using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.DataModel
{
    [Table("ArticleFirstTypeTable")]
    public class ArticleFirstType
    {
        [Key]
        [ForeignKey("Article")]
        public int ID { get; set; }

        [Column("ArticleFirstTypeProperty")]
        [Required]
        [StringLength(500)]
        public string Property { get; set; }
        
        
        public virtual Article Article { get; set; }
    }
}
